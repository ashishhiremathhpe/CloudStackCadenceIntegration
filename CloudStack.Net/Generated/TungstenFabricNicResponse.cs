using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class TungstenFabricNicResponse
    {
        /// <summary>
        /// Tungsten-Fabric nic name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Tungsten-Fabric nic uuid
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
