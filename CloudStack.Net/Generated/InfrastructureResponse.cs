using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class InfrastructureResponse
    {
        /// <summary>
        /// Number of Alerts
        /// </summary>
        public int? Alerts { get; set; }

        /// <summary>
        /// Number of clusters
        /// </summary>
        public int? Clusters { get; set; }

        /// <summary>
        /// Number of cpu sockets
        /// </summary>
        public int? CpuSockets { get; set; }

        /// <summary>
        /// Number of hypervisor hosts
        /// </summary>
        public int? Hosts { get; set; }

        /// <summary>
        /// Number of internal LBs
        /// </summary>
        public int? Ilbvms { get; set; }

        /// <summary>
        /// Number of images stores
        /// </summary>
        public int? ImageStores { get; set; }

        /// <summary>
        /// Number of management servers
        /// </summary>
        public int? ManagementServers { get; set; }

        /// <summary>
        /// Number of object stores
        /// </summary>
        public int? ObjectStores { get; set; }

        /// <summary>
        /// Number of pods
        /// </summary>
        public int? Pods { get; set; }

        /// <summary>
        /// Number of routers
        /// </summary>
        public int? Routers { get; set; }

        /// <summary>
        /// Number of storage pools
        /// </summary>
        public int? StoragePools { get; set; }

        /// <summary>
        /// Number of systemvms
        /// </summary>
        public int? Systemvms { get; set; }

        /// <summary>
        /// Number of zones
        /// </summary>
        public int? Zones { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
