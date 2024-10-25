using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class Ipv6RouteResponse
    {
        /// <summary>
        /// the outbound IPv6 gateway
        /// </summary>
        public string Gateway { get; set; }

        /// <summary>
        /// the guest IPv6 cidr for route
        /// </summary>
        public string Subnet { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
