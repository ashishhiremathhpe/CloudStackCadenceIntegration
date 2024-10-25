using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class HostHAResponse
    {
        /// <summary>
        /// if host HA is enabled for the host
        /// </summary>
        public bool Haenable { get; set; }

        /// <summary>
        /// the host HA provider
        /// </summary>
        public string Haprovider { get; set; }

        /// <summary>
        /// the HA state of the host
        /// </summary>
        public HAConfigHAState HaState { get; set; }

        /// <summary>
        /// the ID of the host
        /// </summary>
        public string Hostid { get; set; }

        /// <summary>
        /// operation status
        /// </summary>
        public bool Status { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
