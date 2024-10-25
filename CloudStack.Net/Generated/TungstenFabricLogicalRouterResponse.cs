using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class TungstenFabricLogicalRouterResponse
    {
        /// <summary>
        /// Tungsten-Fabric logical router name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// list Tungsten-Fabric policy network name
        /// </summary>
        public IList<TungstenFabricNetworkResponse> Network { get; set; }

        /// <summary>
        /// Tungsten-Fabric logical router uuid
        /// </summary>
        public string Uuid { get; set; }

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
