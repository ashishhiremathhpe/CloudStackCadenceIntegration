using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class KubernetesSupportedVersionResponse
    {
        /// <summary>
        /// the id of the Kubernetes supported version
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the date when this Kubernetes supported version was created
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// KVM Only: true if the ISO for the Kubernetes supported version is directly downloaded to Primary Storage bypassing Secondary Storage
        /// </summary>
        public bool DirectDownload { get; set; }

        /// <summary>
        /// the id of the binaries ISO for Kubernetes supported version
        /// </summary>
        public string IsoId { get; set; }

        /// <summary>
        /// the name of the binaries ISO for Kubernetes supported version
        /// </summary>
        public string IsoName { get; set; }

        /// <summary>
        /// the state of the binaries ISO for Kubernetes supported version
        /// </summary>
        public string IsoState { get; set; }

        /// <summary>
        /// the minimum number of CPUs needed for the Kubernetes supported version
        /// </summary>
        public int? Mincpunumber { get; set; }

        /// <summary>
        /// the minimum RAM size in MB needed for the Kubernetes supported version
        /// </summary>
        public int? Minmemory { get; set; }

        /// <summary>
        /// Name of the Kubernetes supported version
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Kubernetes semantic version
        /// </summary>
        public string SemanticVersion { get; set; }

        /// <summary>
        /// the enabled or disabled state of the Kubernetes supported version
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// whether Kubernetes supported version supports Autoscaling
        /// </summary>
        public bool SupportsAutoscaling { get; set; }

        /// <summary>
        /// whether Kubernetes supported version supports HA, multi-control nodes
        /// </summary>
        public bool SupportsHA { get; set; }

        /// <summary>
        /// the id of the zone in which Kubernetes supported version is available
        /// </summary>
        public string ZoneId { get; set; }

        /// <summary>
        /// the name of the zone in which Kubernetes supported version is available
        /// </summary>
        public string ZoneName { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
