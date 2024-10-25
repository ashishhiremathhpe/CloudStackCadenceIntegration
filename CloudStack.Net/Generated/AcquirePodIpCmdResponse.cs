using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AcquirePodIpCmdResponse
    {
        /// <summary>
        /// the ID of the pod the  IP address
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// CIDR of the Pod
        /// </summary>
        public string Cidr { get; set; }

        /// <summary>
        /// Gateway for Pod 
        /// </summary>
        public string Gateway { get; set; }

        /// <summary>
        /// MAC address of the pod the  IP
        /// </summary>
        public long Hostmac { get; set; }

        /// <summary>
        /// Allocated IP address
        /// </summary>
        public string IpAddress { get; set; }

        /// <summary>
        /// the ID of the nic
        /// </summary>
        public long Nicid { get; set; }

        /// <summary>
        /// the ID of the pod the  IP address belongs to
        /// </summary>
        public long PodId { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
