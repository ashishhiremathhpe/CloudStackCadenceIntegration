using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class TungstenFabricPolicyResponse
    {
        /// <summary>
        /// Tungsten-Fabric policy name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// list Tungsten-Fabric policy network name
        /// </summary>
        public IList<TungstenFabricNetworkResponse> Network { get; set; }

        /// <summary>
        /// Tungsten-Fabric tag type uuid
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
