using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ClusterDrsPlanResponse
    {
        /// <summary>
        /// unique ID of the drs plan for cluster
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Id of the cluster
        /// </summary>
        public string ClusterId { get; set; }

        /// <summary>
        /// Start event Id of the DRS Plan
        /// </summary>
        public string EventId { get; set; }

        /// <summary>
        /// List of migrations
        /// </summary>
        public IList<ClusterDrsPlanMigrationResponse> Migrations { get; set; }

        /// <summary>
        /// Status of DRS Plan
        /// </summary>
        public Status Status { get; set; }

        /// <summary>
        /// Type of DRS Plan (Automated or Manual))
        /// </summary>
        public ClusterDrsPlanType Type { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
