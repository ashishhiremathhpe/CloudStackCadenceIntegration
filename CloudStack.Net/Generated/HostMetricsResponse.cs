using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class HostMetricsResponse
    {
        /// <summary>
        /// cpu allocated disable threshold exceeded
        /// </summary>
        public bool Cpuallocateddisablethreshold { get; set; }

        /// <summary>
        /// the total cpu allocated in Ghz
        /// </summary>
        public string Cpuallocatedghz { get; set; }

        /// <summary>
        /// cpu allocated notification threshold exceeded
        /// </summary>
        public bool Cpuallocatedthreshold { get; set; }

        /// <summary>
        /// cpu usage disable threshold exceeded
        /// </summary>
        public bool Cpudisablethreshold { get; set; }

        /// <summary>
        /// the average cpu load the last minute
        /// </summary>
        public double Cpuloadaverage { get; set; }

        /// <summary>
        /// cpu usage notification threshold exceeded
        /// </summary>
        public bool Cputhreshold { get; set; }

        /// <summary>
        /// the total cpu capacity in Ghz
        /// </summary>
        public string Cputotalghz { get; set; }

        /// <summary>
        /// the total cpu used in Ghz
        /// </summary>
        public string Cpuusedghz { get; set; }

        /// <summary>
        /// instances on the host
        /// </summary>
        public string Instances { get; set; }

        /// <summary>
        /// memory allocated disable threshold exceeded
        /// </summary>
        public bool Memoryallocateddisablethreshold { get; set; }

        /// <summary>
        /// the total memory allocated in GiB
        /// </summary>
        public string Memoryallocatedgb { get; set; }

        /// <summary>
        /// memory allocated notification threshold exceeded
        /// </summary>
        public bool Memoryallocatedthreshold { get; set; }

        /// <summary>
        /// memory usage disable threshold exceeded
        /// </summary>
        public bool Memorydisablethreshold { get; set; }

        /// <summary>
        /// memory usage notification threshold exceeded
        /// </summary>
        public bool Memorythreshold { get; set; }

        /// <summary>
        /// the total memory capacity in GiB
        /// </summary>
        public string Memorytotalgb { get; set; }

        /// <summary>
        /// the total memory used in GiB
        /// </summary>
        public string Memoryusedgb { get; set; }

        /// <summary>
        /// network read in GiB
        /// </summary>
        public string NetworkRead { get; set; }

        /// <summary>
        /// network write in GiB
        /// </summary>
        public string NetworkWrite { get; set; }

        /// <summary>
        /// out-of-band management power state
        /// </summary>
        public PowerState PowerState { get; set; }

        /// <summary>
        /// system vm instances on the host
        /// </summary>
        public string SystemInstances { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
