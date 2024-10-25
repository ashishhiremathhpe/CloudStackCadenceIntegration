using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ZoneMetricsResponse
    {
        /// <summary>
        /// healthy / total clusters in the zone
        /// </summary>
        public string Clusters { get; set; }

        /// <summary>
        /// the total cpu allocated in Ghz
        /// </summary>
        public string CpuAllocated { get; set; }

        /// <summary>
        /// cpu allocated disable threshold exceeded
        /// </summary>
        public bool Cpuallocateddisablethreshold { get; set; }

        /// <summary>
        /// cpu allocated notification threshold exceeded
        /// </summary>
        public bool Cpuallocatedthreshold { get; set; }

        /// <summary>
        /// cpu usage disable threshold exceeded
        /// </summary>
        public bool Cpudisablethreshold { get; set; }

        /// <summary>
        /// the maximum cpu deviation
        /// </summary>
        public string CpuMaxDeviation { get; set; }

        /// <summary>
        /// cpu usage notification threshold exceeded
        /// </summary>
        public bool Cputhreshold { get; set; }

        /// <summary>
        /// the total cpu capacity in Ghz
        /// </summary>
        public string CpuTotal { get; set; }

        /// <summary>
        /// the total cpu used in Ghz
        /// </summary>
        public string CpuUsed { get; set; }

        /// <summary>
        /// the total cpu allocated in GiB
        /// </summary>
        public string Memoryallocated { get; set; }

        /// <summary>
        /// memory allocated disable threshold exceeded
        /// </summary>
        public bool Memoryallocateddisablethreshold { get; set; }

        /// <summary>
        /// memory allocated notification threshold exceeded
        /// </summary>
        public bool Memoryallocatedthreshold { get; set; }

        /// <summary>
        /// memory usage disable threshold exceeded
        /// </summary>
        public bool Memorydisablethreshold { get; set; }

        /// <summary>
        /// the maximum memory deviation
        /// </summary>
        public string Memorymaxdeviation { get; set; }

        /// <summary>
        /// memory usage notification threshold exceeded
        /// </summary>
        public bool Memorythreshold { get; set; }

        /// <summary>
        /// the total cpu capacity in GiB
        /// </summary>
        public string Memorytotal { get; set; }

        /// <summary>
        /// the total cpu used in GiB
        /// </summary>
        public string Memoryused { get; set; }

        /// <summary>
        /// state of the cluster
        /// </summary>
        public string State { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
