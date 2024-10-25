using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class VmMetricsStatsResponse
    {
        /// <summary>
        /// the ID of the virtual machine
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// user generated name. The name of the virtual machine is returned if no displayname exists.
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// the name of the virtual machine
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// the list of VM stats
        /// </summary>
        public IList<StatsResponse> Stats { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
