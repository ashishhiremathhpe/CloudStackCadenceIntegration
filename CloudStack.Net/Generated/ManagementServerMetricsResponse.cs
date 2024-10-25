using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ManagementServerMetricsResponse
    {
        /// <summary>
        /// the number of agents this Management Server is responsible for
        /// </summary>
        public int? AgentCount { get; set; }

        /// <summary>
        /// the number of processors available to the JVM
        /// </summary>
        public int? AvailableProcessors { get; set; }

        /// <summary>
        /// the time these statistics were collected
        /// </summary>
        public DateTime CollectionTime { get; set; }

        /// <summary>
        /// the current cpu load
        /// </summary>
        public string CpuLoad { get; set; }

        /// <summary>
        /// the system is running against a local database
        /// </summary>
        public bool Dbislocal { get; set; }

        /// <summary>
        /// the amount of memory allocated to this Management Server
        /// </summary>
        public long HeapMemoryTotal { get; set; }

        /// <summary>
        /// the amount of memory used by this Management Server
        /// </summary>
        public long HeapMemoryUsed { get; set; }

        /// <summary>
        /// the log files and their usage on disk
        /// </summary>
        public string LogInfo { get; set; }

        /// <summary>
        /// the number of client sessions active on this Management Server
        /// </summary>
        public long Sessions { get; set; }

        /// <summary>
        /// Free system memory
        /// </summary>
        public string SystemMemoryFree { get; set; }

        /// <summary>
        /// Total system memory
        /// </summary>
        public string SystemMemoryTotal { get; set; }

        /// <summary>
        /// Amount of memory used
        /// </summary>
        public string SystemMemoryUsed { get; set; }

        /// <summary>
        /// Virtual size of the fully loaded process
        /// </summary>
        public string SystemMemoryVirtualSize { get; set; }

        /// <summary>
        /// the total system cpu capacity
        /// </summary>
        public double SystemTotalCpuCycles { get; set; }

        /// <summary>
        /// The number of blocked threads
        /// </summary>
        public int? ThreadsBlockedCount { get; set; }

        /// <summary>
        /// The number of daemon threads
        /// </summary>
        public int? ThreadsDaemonCount { get; set; }

        /// <summary>
        /// The number of runnable threads
        /// </summary>
        public int? ThreadsRunnableCount { get; set; }

        /// <summary>
        /// The number of terminated threads
        /// </summary>
        public int? Threadsteminatedcount { get; set; }

        /// <summary>
        /// The number of threads
        /// </summary>
        public int? ThreadsTotalCount { get; set; }

        /// <summary>
        /// The number of waiting threads
        /// </summary>
        public int? ThreadsWaitingCount { get; set; }

        /// <summary>
        /// the system has a usage server running locally
        /// </summary>
        public bool Usageislocal { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
