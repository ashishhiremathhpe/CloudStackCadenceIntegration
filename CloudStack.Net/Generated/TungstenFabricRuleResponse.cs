using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class TungstenFabricRuleResponse
    {
        /// <summary>
        /// Tungsten-Fabric policy action
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// Tungsten-Fabric policy destination end port
        /// </summary>
        public int DestEndPort { get; set; }

        /// <summary>
        /// Tungsten-Fabric policy destination ip prefix
        /// </summary>
        public string DestIpPrefix { get; set; }

        /// <summary>
        /// Tungsten-Fabric policy destination ip prefix length
        /// </summary>
        public int DestIpPrefixLen { get; set; }

        /// <summary>
        /// Tungsten-Fabric policy destination network
        /// </summary>
        public string DestNetwork { get; set; }

        /// <summary>
        /// Tungsten-Fabric policy destination start port
        /// </summary>
        public int DestStartPort { get; set; }

        /// <summary>
        /// Tungsten-Fabric policy name
        /// </summary>
        public string Direction { get; set; }

        /// <summary>
        /// Tungsten-Fabric policy uuid
        /// </summary>
        public string PolicyUuid { get; set; }

        /// <summary>
        /// Tungsten-Fabric policy protocol
        /// </summary>
        public string Protocol { get; set; }

        /// <summary>
        /// Tungsten-Fabric policy source end port
        /// </summary>
        public int SrcEndPort { get; set; }

        /// <summary>
        /// Tungsten-Fabric policy source ip prefix
        /// </summary>
        public string SrcIpPrefix { get; set; }

        /// <summary>
        /// Tungsten-Fabric policy source ip prefix length
        /// </summary>
        public int SrcIpPrefixLen { get; set; }

        /// <summary>
        /// Tungsten-Fabric policy source network
        /// </summary>
        public string SrcNetwork { get; set; }

        /// <summary>
        /// Tungsten-Fabric policy source start port
        /// </summary>
        public int SrcStartPort { get; set; }

        /// <summary>
        /// Tungsten-Fabric rule uuid
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
