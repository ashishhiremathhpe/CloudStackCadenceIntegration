using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class VmMetricsResponse
    {
        /// <summary>
        /// the total cpu capacity in Ghz
        /// </summary>
        public string CpuTotal { get; set; }

        /// <summary>
        /// the total disk iops
        /// </summary>
        public long DiskIopsTotal { get; set; }

        /// <summary>
        /// disk read in MiB
        /// </summary>
        public string DiskRead { get; set; }

        /// <summary>
        /// disk write in MiB
        /// </summary>
        public string DiskWrite { get; set; }

        /// <summary>
        /// the VM's primary IP address
        /// </summary>
        public string IpAddress { get; set; }

        /// <summary>
        /// the total memory capacity in GiB
        /// </summary>
        public string Memorytotal { get; set; }

        /// <summary>
        /// network read in MiB
        /// </summary>
        public string NetworkRead { get; set; }

        /// <summary>
        /// network write in MiB
        /// </summary>
        public string NetworkWrite { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
