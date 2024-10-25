using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class TungstenFabricTagResponse
    {
        /// <summary>
        /// Tungsten-Fabric tag name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// list Tungsten-Fabric network
        /// </summary>
        public IList<TungstenFabricNetworkResponse> Network { get; set; }

        /// <summary>
        /// list Tungsten-Fabric nic
        /// </summary>
        public IList<TungstenFabricNicResponse> Nic { get; set; }

        /// <summary>
        /// list Tungsten-Fabric policy
        /// </summary>
        public IList<TungstenFabricPolicyResponse> Policy { get; set; }

        /// <summary>
        /// Tungsten-Fabric tag type uuid
        /// </summary>
        public string Uuid { get; set; }

        /// <summary>
        /// list Tungsten-Fabric vm
        /// </summary>
        public IList<TungstenFabricVmResponse> Vm { get; set; }

        /// <summary>
        /// Tungsten-Fabric provider zone id
        /// </summary>
        public long ZoneId { get; set; }

        /// <summary>
        /// Tungsten-Fabric provider zone name
        /// </summary>
        public string ZoneName { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
