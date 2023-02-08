using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;

namespace IoT.Device
{
    // https://learn.microsoft.com/en-us/azure/iot-dps/concepts-deploy-at-scale#reprovisioning-sample
    public class ProvisioningDetailsFileStorage
    {
        private string dataDirectory = null;

        public ProvisioningDetailsFileStorage()
        {
            var pathChanks = System.IO.Directory.GetCurrentDirectory().Split('\\');
            dataDirectory = string.Join('\\', pathChanks.Take(pathChanks.Length - 3));
        }

        public ProvisioningResponse GetProvisioningDetailResponseFromCache(string registrationId)
        {
            try
            {
                var provisioningResponseFile = File.ReadAllText(Path.Combine(dataDirectory, registrationId));

                ProvisioningResponse response = JsonConvert.DeserializeObject<ProvisioningResponse>(provisioningResponseFile);

                return response;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public void SetProvisioningDetailResponse(string registrationId, ProvisioningResponse provisioningDetails)
        {
            var provisioningDetailsJson = JsonConvert.SerializeObject(provisioningDetails);

            File.WriteAllText(Path.Combine(dataDirectory, registrationId), provisioningDetailsJson);
        }
    }

    public class ProvisioningResponse
    {
        public string IotHubHostName { get; set; }
        public string DeviceId { get; set; }
    }
}