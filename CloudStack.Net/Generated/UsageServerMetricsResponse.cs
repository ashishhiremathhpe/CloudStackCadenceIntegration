using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UsageServerMetricsResponse
    {
        /// <summary>
        /// the time these statistics were collected
        /// </summary>
        public DateTime CollectionTime { get; set; }

        /// <summary>
        /// the name of the active usage server
        /// </summary>
        public string Hostname { get; set; }

        /// <summary>
        /// the last time this Usage Server checked for jobs
        /// </summary>
        public DateTime LastHeartbeat { get; set; }

        /// <summary>
        /// the last time a usage job successfully completed
        /// </summary>
        public DateTime LastSuccessfulJob { get; set; }

        /// <summary>
        /// the state of the usage server
        /// </summary>
        public State State { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
