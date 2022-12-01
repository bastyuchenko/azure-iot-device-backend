﻿using Microsoft.Azure.Devices.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoT.Device
{
    internal class DeviceParameters
    {
        /// <summary>
        ///     The CER certificate to load for device provisioning authentication.
        /// </summary>
        public string CertificateCerName = "certificate.cer";

        /// <summary>
        ///     "The password of the PFX certificate file. If not specified, the program will prompt at run time."
        /// </summary>
        public string CertificatePassword = ConfigurationSettings.AppSettings["CertificatePassword"];

        /// <summary>
        ///     "The PFX certificate to load for device provisioning authentication."
        /// </summary>
        public string CertificatePfxName = "certificate.pfx";

        /// <summary>
        ///     The global endpoint for devices to connect to.
        /// </summary>
        public string GlobalDeviceEndpoint = "global.azure-devices-provisioning.net";

        /// <summary>
        ///     The Id Scope of the DPS instance
        /// </summary>
        public string IdScope = ConfigurationSettings.AppSettings["IdScope"];

        /// <summary>
        ///     The transport to use to communicate with the device provisioning instance. Possible values include Mqtt,
        ///     Mqtt_WebSocket_Only, Mqtt_Tcp_Only, Amqp, Amqp_WebSocket_Only, Amqp_Tcp_only, and Http1.
        /// </summary>
        public TransportType TransportType = TransportType.Amqp;

        public string ModuleConnectionString = ConfigurationSettings.AppSettings["ModuleConnectionString"];
    }
}
