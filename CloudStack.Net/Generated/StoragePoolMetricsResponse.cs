using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class StoragePoolMetricsResponse
    {
        /// <summary>
        /// disk size allocated in GiB
        /// </summary>
        public string DiskSizeAllocatedGB { get; set; }

        /// <summary>
        /// disk size in GiB
        /// </summary>
        public string DiskSizeTotalGB { get; set; }

        /// <summary>
        /// disk size unallocated in GiB
        /// </summary>
        public string DiskSizeUnallocatedGB { get; set; }

        /// <summary>
        /// disk size used in GiB
        /// </summary>
        public string DiskSizeUsedGB { get; set; }

        /// <summary>
        /// storage allocated disable threshold exceeded
        /// </summary>
        public bool StorageAllocatedDisableThreshold { get; set; }

        /// <summary>
        /// storage allocated notification threshold exceeded
        /// </summary>
        public bool StorageAllocatedThreshold { get; set; }

        /// <summary>
        /// storage usage disable threshold exceeded
        /// </summary>
        public bool Storageusagedisablethreshold { get; set; }

        /// <summary>
        /// storage usage notification threshold exceeded
        /// </summary>
        public bool Storageusagethreshold { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
