using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class TungstenFabricServiceGroupResponse
    {
        /// <summary>
        /// Tungsten-Fabric service group end port
        /// </summary>
        public int EndPort { get; set; }

        /// <summary>
        /// Tungsten-Fabric service group name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Tungsten-Fabric service group protocol
        /// </summary>
        public string Protocol { get; set; }

        /// <summary>
        /// Tungsten-Fabric service group start port
        /// </summary>
        public int StartPort { get; set; }

        /// <summary>
        /// Tungsten-Fabric service group uuid
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
