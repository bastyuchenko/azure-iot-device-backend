using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Azure.Messaging.EventHubs.Consumer;
using Microsoft.Azure.Devices;
using Microsoft.Azure.Devices.Shared;
using Message = Microsoft.Azure.Devices.Message;
using Azure.Messaging.EventHubs.Processor;
using Azure.Messaging.EventHubs;
using Azure.Storage.Blobs;
using System.Diagnostics.Tracing;
using Newtonsoft.Json;

namespace IoT.Backend
{
    public partial class BackForm : Form
    {
        private static ServiceClient _serviceClient;

        private Parameters _parameters;

        private RegistryManager registryManager;

        EventProcessorClient processor;

        public BackForm()
        {
            _parameters = new Parameters();

            var options = new ServiceClientOptions
            {
                SdkAssignsMessageId = SdkAssignsMessageId.WhenUnset
            };

            _serviceClient = ServiceClient.CreateFromConnectionString(_parameters.IoTHubConnectionString, _parameters.TransportType, options);
            registryManager = RegistryManager.CreateFromConnectionString(_parameters.IoTHubConnectionString);

            InitializeComponent();
        }

        private async void btnStartReceiving_Click(object sender, EventArgs e)
        {
            // Either the connection string must be supplied, or the set of endpoint, name, and shared access key must be.
            if (string.IsNullOrWhiteSpace(_parameters.EventHubConnectionString)) MessageBox.Show("error");

            Log("IoT Hub Quickstarts - Read device to cloud messages. Ctrl-C to exit.\r\n");

            var storageClient = new BlobContainerClient(_parameters.BlobStorageConnectionString, "event-hub-checkpoints");
            processor = new EventProcessorClient(storageClient, EventHubConsumerClient.DefaultConsumerGroupName,
                _parameters.EventHubConnectionString);

            processor.ProcessEventAsync += ProcessEventHandler;
            processor.ProcessErrorAsync += ProcessErrorHandler;

            await processor.StartProcessingAsync();
        }

        private async void btnStopReceiving_Click(object sender, EventArgs e)
        {
            try
            {
                await processor.StopProcessingAsync();
            }
            finally
            {
                // To prevent leaks, the handlers should be removed when processing is complete.
                processor.ProcessEventAsync -= ProcessEventHandler;
                processor.ProcessErrorAsync -= ProcessErrorHandler;
            }
        }

        private async Task ProcessEventHandler(ProcessEventArgs partitionEvent)
        {
            Log($"Message received on partition {partitionEvent.Partition.PartitionId}:");

            var EventBody = Encoding.UTF8.GetString(partitionEvent.Data.EventBody.ToArray());
            tbReceivedMsg.AppendText(JsonConvert.SerializeObject(
                new
                {
                    EventBody,
                    partitionEvent.Data.Properties,
                    partitionEvent.Data.SystemProperties,
                }, Formatting.Indented));

            // Update checkpoint in the blob storage so that the app receives only new events the next time it's run
            await partitionEvent.UpdateCheckpointAsync(partitionEvent.CancellationToken);
        }

        private Task ProcessErrorHandler(ProcessErrorEventArgs arg)
        {
            Log($"ERROR: {arg.Exception.Message}");
            return Task.CompletedTask;
        }

        private async void btnSendToDevice_Click(object sender, EventArgs e)
        {
            var sendTask = SendC2dMessagesAsync(CancellationToken.None);
            var receiveTask = ReceiveMessageFeedbacksAsync(CancellationToken.None);

            await Task.WhenAll(sendTask, receiveTask);
        }

        private async Task ReceiveMessageFeedbacksAsync(CancellationToken token)
        {
            // It is important to note that receiver only gets feedback messages when the device is actively running and acting on messages.
            Log("Starting to listen to feedback messages");

            var feedbackReceiver = _serviceClient.GetFeedbackReceiver();

            while (!token.IsCancellationRequested)
                try
                {
                    var feedbackMessages = await feedbackReceiver.ReceiveAsync(token);
                    if (feedbackMessages != null)
                    {
                        Log("New Feedback received:");
                        Log(JsonConvert.SerializeObject(
                            new
                            {
                                feedbackMessages.EnqueuedTime,
                                feedbackMessages.Records
                            }, Formatting.Indented));

                        await feedbackReceiver.CompleteAsync(feedbackMessages, token);
                    }

                    await Task.Delay(TimeSpan.FromSeconds(5));
                }
                catch (Exception e)
                {
                    Log($"Transient Exception occurred; will retry: {e}");
                }
        }

        private async Task SendC2dMessagesAsync(CancellationToken cancellationToken)
        {
            var message = new Message(Encoding.ASCII.GetBytes(tbSentMsg.Text))
            {
                // An acknowledgment is sent on delivery success or failure.
                Ack = DeliveryAcknowledgement.Full
            };
            message.Properties.Add("custom-prop-device-id", tbDeviceId.Text);

            Log($"Sending C2D message with Id {message.MessageId} to {tbDeviceId.Text}.");

            try
            {
                await _serviceClient.SendAsync(tbDeviceId.Text, message, TimeSpan.FromSeconds(30));
                Log($"Sent message with Id {message.MessageId} to {tbDeviceId.Text}.");
                message.Dispose();
            }
            catch (Exception e)
            {
                Log($"Transient Exception occurred, will retry: {e}");
            }
        }

        internal class Parameters
        {
            public string DeviceId = "iothubx509device1";

            public string EventHubConnectionString = ConfigurationSettings.AppSettings["EventHubConnectionString"];
            public string IoTHubConnectionString = ConfigurationSettings.AppSettings["IoTHubConnectionString"];
            public string BlobStorageConnectionString = ConfigurationSettings.AppSettings["BlobStorageConnectionString"];

            public TransportType TransportType = TransportType.Amqp;
        }

        private async void btnWDesired_Click(object sender, EventArgs e)
        {
            var twin = await registryManager.GetTwinAsync(_parameters.DeviceId);

            var patch =
                $@"{{
                    properties: {{
                        desired: {{
                          myCustomKey: '{tbDTdesired.Text}'
                        }}
                    }}
                }}";

            await registryManager.UpdateTwinAsync(twin.DeviceId, patch, twin.ETag);
        }

        private async void btnRReported_Click(object sender, EventArgs e)
        {
            var twin = await registryManager.GetTwinAsync(_parameters.DeviceId);
            tbDTRead.Text = twin.ToJson(Formatting.Indented);
        }

        private void Log(string text)
        {
            lbStatus.AppendText("\r\n" + text);
        }

        private void BackForm_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            lbStatus.Text = "";
        }
    }
}