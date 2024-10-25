using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class VolumeMetricsStatsResponse
    {
        /// <summary>
        /// the ID of the volume
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the name of the volume
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// the list of VM stats
        /// </summary>
        public IList<StatsResponse> Stats { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
