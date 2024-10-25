using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ClusterDrsPlanMigrationResponse
    {
        /// <summary>
        /// Destination host for VM migration
        /// </summary>
        public string Destinationhostid { get; set; }

        /// <summary>
        /// Destination host for VM migration
        /// </summary>
        public string Destinationhostname { get; set; }

        /// <summary>
        /// id of VM migration async job
        /// </summary>
        public long JobId { get; set; }

        /// <summary>
        /// Job status of VM migration async job
        /// </summary>
        public Status JobStatus { get; set; }

        /// <summary>
        /// Original host for VM migration
        /// </summary>
        public string Sourcehostid { get; set; }

        /// <summary>
        /// Original host for VM migration
        /// </summary>
        public string Sourcehostname { get; set; }

        /// <summary>
        /// VM to migrate
        /// </summary>
        public string Virtualmachineid { get; set; }

        /// <summary>
        /// VM to migrate
        /// </summary>
        public string Virtualmachinename { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
