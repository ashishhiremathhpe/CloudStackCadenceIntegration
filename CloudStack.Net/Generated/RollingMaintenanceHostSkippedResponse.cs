using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class RollingMaintenanceHostSkippedResponse
    {
        /// <summary>
        /// the ID of the skipped host
        /// </summary>
        public string HostId { get; set; }

        /// <summary>
        /// the name of the skipped host
        /// </summary>
        public string HostName { get; set; }

        /// <summary>
        /// the reason to skip the host
        /// </summary>
        public string Reason { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
