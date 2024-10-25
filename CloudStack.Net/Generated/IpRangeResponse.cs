using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class IpRangeResponse
    {
        /// <summary>
        /// the CIDR for the range
        /// </summary>
        public string Cidr { get; set; }

        /// <summary>
        /// the ending IP for the range
        /// </summary>
        public string EndIp { get; set; }

        /// <summary>
        /// indicates if range is dedicated for CPVM and SSVM
        /// </summary>
        public string ForSystemVms { get; set; }

        /// <summary>
        /// the gateway for the range
        /// </summary>
        public string Gateway { get; set; }

        /// <summary>
        /// the starting IP for the range
        /// </summary>
        public string StartIp { get; set; }

        /// <summary>
        /// indicates Vlan ID for the range
        /// </summary>
        public string VlanId { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
