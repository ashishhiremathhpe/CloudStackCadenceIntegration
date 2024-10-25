using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ReadyForShutdownResponse
    {
        /// <summary>
        /// The id of the management server
        /// </summary>
        public long Managementserverid { get; set; }

        /// <summary>
        /// The number of jobs in progress
        /// </summary>
        public long PendingJobsCount { get; set; }

        /// <summary>
        /// Indicates whether CloudStack is ready to shutdown
        /// </summary>
        public bool ReadyForShutdown { get; set; }

        /// <summary>
        /// Indicates whether a shutdown has been triggered
        /// </summary>
        public bool ShutdownTriggered { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
