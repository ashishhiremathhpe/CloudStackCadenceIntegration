using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class StatsResponse
    {
        /// <summary>
        /// the amount (percentage) of the VM's CPU currently used
        /// </summary>
        public string CpuUsed { get; set; }

        /// <summary>
        /// the total disk iops since the last stats retrieval
        /// </summary>
        public long DiskIopsTotal { get; set; }

        /// <summary>
        /// the VM's disk number of read requests (IO) made in the last collection cycle as defined by vm.stats.interval configuration
        /// </summary>
        public long DiskIORead { get; set; }

        /// <summary>
        /// the VM's disk number of write requests (IO) made in the last collection cycle as defined by vm.stats.interval configuration
        /// </summary>
        public long DiskIOWrite { get; set; }

        /// <summary>
        /// the VM's disk read in KiB
        /// </summary>
        public long DiskKbsRead { get; set; }

        /// <summary>
        /// the VM's disk write in KiB
        /// </summary>
        public long DiskKbsWrite { get; set; }

        /// <summary>
        /// the VM's free memory in KB or -1 if it cannot be gathered
        /// </summary>
        public long MemoryIntFreeKBs { get; set; }

        /// <summary>
        /// the memory used by the VM in KB
        /// </summary>
        public long MemoryKBs { get; set; }

        /// <summary>
        /// the target memory in VM (KB)
        /// </summary>
        public long MemoryTargetKBs { get; set; }

        /// <summary>
        /// the incoming network traffic on the VM in KiB
        /// </summary>
        public long NetworkKbsRead { get; set; }

        /// <summary>
        /// the outgoing network traffic on the host in KiB
        /// </summary>
        public long NetworkKbsWrite { get; set; }

        /// <summary>
        /// the amount of downloaded data by the VM in MiB
        /// </summary>
        public string NetworkRead { get; set; }

        /// <summary>
        /// the amount of uploaded data by the VM in MiB
        /// </summary>
        public string NetworkWrite { get; set; }

        /// <summary>
        /// the time when the VM stats were collected. The format is "yyyy-MM-dd hh:mm:ss"
        /// </summary>
        public DateTime Timestamp { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
