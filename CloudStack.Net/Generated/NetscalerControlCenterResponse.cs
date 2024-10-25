using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class NetscalerControlCenterResponse
    {
        /// <summary>
        /// id
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// ncc_ip
        /// </summary>
        public string Ipaddress { get; set; }

        /// <summary>
        /// num_retries
        /// </summary>
        public string Numretries { get; set; }

        /// <summary>
        /// username
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// uuid
        /// </summary>
        public string Uuid { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
