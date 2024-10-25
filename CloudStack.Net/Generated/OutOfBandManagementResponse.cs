using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class OutOfBandManagementResponse
    {
        /// <summary>
        /// the out-of-band management action (if issued)
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// the out-of-band management interface address
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// the operation result description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// the out-of-band management driver for the host
        /// </summary>
        public string Driver { get; set; }

        /// <summary>
        /// true if out-of-band management is enabled for the host
        /// </summary>
        public bool Enabled { get; set; }

        /// <summary>
        /// the ID of the host
        /// </summary>
        public string Hostid { get; set; }

        /// <summary>
        /// the out-of-band management interface password
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// the out-of-band management interface port
        /// </summary>
        public string Port { get; set; }

        /// <summary>
        /// the out-of-band management interface powerState of the host
        /// </summary>
        public OutOfBandManagementPowerState PowerState { get; set; }

        /// <summary>
        /// the operation result
        /// </summary>
        public bool Status { get; set; }

        /// <summary>
        /// the out-of-band management interface username
        /// </summary>
        public string Username { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
