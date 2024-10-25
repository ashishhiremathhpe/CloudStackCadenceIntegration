using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class VnfNicResponse
    {
        /// <summary>
        /// Description of the NIC
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Device id of the NIC
        /// </summary>
        public long DeviceId { get; set; }

        /// <summary>
        /// True if the NIC is a management interface. False otherwise
        /// </summary>
        public bool Management { get; set; }

        /// <summary>
        /// Name of the NIC
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Network id of the NIC
        /// </summary>
        public string NetworkId { get; set; }

        /// <summary>
        /// Network name of the NIC
        /// </summary>
        public string NetworkName { get; set; }

        /// <summary>
        /// True if the NIC is required. False if optional
        /// </summary>
        public bool Required { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
