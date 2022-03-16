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

namespace IoT.Backend
{
    public partial class BackForm : Form
    {
        private static ServiceClient _serviceClient;

        private Parameters _parameters;

        private RegistryManager registryManager;

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

            lbStatus.Text += "\r\nIoT Hub Quickstarts - Read device to cloud messages. Ctrl-C to exit.\r\n";

            // Run the sample
            await ReceiveMessagesFromDeviceAsync(CancellationToken.None);

            lbStatus.Text += "\r\nCloud message reader finished.";
        }

        // Asynchronously create a PartitionReceiver for a partition and then start
        // reading any messages sent from the simulated client.
        private async Task ReceiveMessagesFromDeviceAsync(CancellationToken ct)
        {
            // Create the consumer using the default consumer group using a direct connection to the service.
            // Information on using the client with a proxy can be found in the README for this quick start, here:
            // https://github.com/Azure-Samples/azure-iot-samples-csharp/tree/main/iot-hub/Quickstarts/ReadD2cMessages/README.md#websocket-and-proxy-support
            var consumer = new EventHubConsumerClient(
                EventHubConsumerClient.DefaultConsumerGroupName,
                _parameters.EventHubConnectionString);

            lbStatus.Text += "\r\nListening for messages on all partitions.";

            try
            {
                // Begin reading events for all partitions, starting with the first event in each partition and waiting indefinitely for
                // events to become available. Reading can be canceled by breaking out of the loop when an event is processed or by
                // signaling the cancellation token.
                //
                // The "ReadEventsAsync" method on the consumer is a good starting point for consuming events for prototypes
                // and samples. For real-world production scenarios, it is strongly recommended that you consider using the
                // "EventProcessorClient" from the "Azure.Messaging.EventHubs.Processor" package.
                //
                // More information on the "EventProcessorClient" and its benefits can be found here:
                //   https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/eventhub/Azure.Messaging.EventHubs.Processor/README.md
                await foreach (var partitionEvent in consumer.ReadEventsAsync(ct))
                {
                    lbStatus.Text +=
                        $"\r\nMessage received on partition {partitionEvent.Partition.PartitionId}:";

                    var data = Encoding.UTF8.GetString(partitionEvent.Data.Body.ToArray());
                    lbStatus.Text += $"\r\n\tMessage body: {data}";

                    lbStatus.Text += "\r\n\tApplication properties (set by device):";
                    foreach (KeyValuePair<string, object> prop in partitionEvent.Data.Properties) PrintProperties(prop);

                    lbStatus.Text += "\r\n\tSystem properties (set by IoT Hub):";
                    foreach (KeyValuePair<string, object> prop in partitionEvent.Data.SystemProperties)
                        PrintProperties(prop);

                    lbStatus.Text += "\r\n=====================================";
                    lbStatus.Text += "\r\n=====================================";
                    lbStatus.Text += "\r\n=====================================";
                }
            }
            catch (TaskCanceledException)
            {
                // This is expected when the token is signaled; it should not be considered an
                // error in this scenario.
            }
        }

        private void PrintProperties(KeyValuePair<string, object> prop)
        {
            var propValue = prop.Value is DateTime
                ? ((DateTime)prop.Value).ToString("O") // using a built-in date format here that includes milliseconds
                : prop.Value.ToString();

            lbStatus.Text += $"\r\n\t\t{prop.Key}: {propValue}";
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
            lbStatus.Text += "\r\nStarting to listen to feedback messages";

            var feedbackReceiver = _serviceClient.GetFeedbackReceiver();

            while (!token.IsCancellationRequested)
                try
                {
                    var feedbackMessages = await feedbackReceiver.ReceiveAsync();
                    if (feedbackMessages != null)
                    {
                        lbStatus.Text += "\r\nNew Feedback received:";
                        lbStatus.Text += $"\r\n\tEnqueue Time: {feedbackMessages.EnqueuedTime}";
                        lbStatus.Text +=
                            $"\r\n\tNumber of messages in the batch: {feedbackMessages.Records.Count()}";
                        foreach (var feedbackRecord in feedbackMessages.Records)
                            lbStatus.Text +=
                                $"\r\n\tDevice {feedbackRecord.DeviceId} acted on message: {feedbackRecord.OriginalMessageId} with status: {feedbackRecord.StatusCode}";

                        await feedbackReceiver.CompleteAsync(feedbackMessages);
                    }

                    await Task.Delay(TimeSpan.FromSeconds(5));
                }
                catch (Exception e)
                {
                    lbStatus.Text += $"\r\nTransient Exception occurred; will retry: {e}";
                }
        }

        private async Task SendC2dMessagesAsync(CancellationToken cancellationToken)
        {
            var message = new Message(Encoding.ASCII.GetBytes(tbMsg.Text))
            {
                // An acknowledgment is sent on delivery success or failure.
                Ack = DeliveryAcknowledgement.Full
            };

            lbStatus.Text += $"\r\nSending C2D message with Id {message.MessageId} to {tbDeviceId.Text}.";

            try
            {
                await _serviceClient.SendAsync(tbDeviceId.Text, message, TimeSpan.FromSeconds(30));
                lbStatus.Text += $"\r\nSent message with Id {message.MessageId} to {tbDeviceId.Text}.";
                message.Dispose();
            }
            catch (Exception e)
            {
                lbStatus.Text += $"\r\nTransient Exception occurred, will retry: {e}";
            }
        }

        internal class Parameters
        {
            public string DeviceId = "iothubx509device1";

            public string EventHubConnectionString = ConfigurationSettings.AppSettings["EventHubConnectionString"];
            public string IoTHubConnectionString = ConfigurationSettings.AppSettings["IoTHubConnectionString"];

            public TransportType TransportType = TransportType.Amqp;
        }

        private async void btnWDesired_Click(object sender, EventArgs e)
        {
            var twin = await registryManager.GetTwinAsync(_parameters.DeviceId);

            var patch =
                @"{
                    properties: {
                        desired: {
                          customKey: 'customValue'
                        }
                    }
                }";

            await registryManager.UpdateTwinAsync(twin.DeviceId, patch, twin.ETag);
        }

        private async void btnRReported_Click(object sender, EventArgs e)
        {
            var twin = await registryManager.GetTwinAsync(_parameters.DeviceId);
            MessageBox.Show(twin.ToJson());
        }
    }
}