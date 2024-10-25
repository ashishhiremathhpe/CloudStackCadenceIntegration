using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class TungstenFabricAddressGroupResponse
    {
        /// <summary>
        /// Tungsten-Fabric address group ip prefix
        /// </summary>
        public string IpPrefix { get; set; }

        /// <summary>
        /// Tungsten-Fabric address group ip prefix length
        /// </summary>
        public int IpPrefixLen { get; set; }

        /// <summary>
        /// Tungsten-Fabric address group name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Tungsten-Fabric address group uuid
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
