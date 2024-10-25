using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class VolumeMetricsResponse
    {
        /// <summary>
        /// the total disk iops
        /// </summary>
        public long DiskIopsTotal { get; set; }

        /// <summary>
        /// disk size in GiB
        /// </summary>
        public string Sizegb { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
