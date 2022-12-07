using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoT.Device
{
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
