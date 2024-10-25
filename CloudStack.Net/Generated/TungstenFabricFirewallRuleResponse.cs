using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class TungstenFabricFirewallRuleResponse
    {
        /// <summary>
        /// Tungsten-Fabric firewall rule action
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// Tungsten-Fabric firewall rule destination address group
        /// </summary>
        public string DestAddressGroup { get; set; }

        /// <summary>
        /// Tungsten-Fabric firewall rule destination network
        /// </summary>
        public string DestNetwork { get; set; }

        /// <summary>
        /// Tungsten-Fabric firewall rule destination tag
        /// </summary>
        public string DestTag { get; set; }

        /// <summary>
        /// Tungsten-Fabric firewall rule direction
        /// </summary>
        public string Direction { get; set; }

        /// <summary>
        /// Tungsten-Fabric firewall rule name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Tungsten-Fabric firewall rule service group
        /// </summary>
        public string ServiceGroup { get; set; }

        /// <summary>
        /// Tungsten-Fabric firewall rule source address group
        /// </summary>
        public string SrcAddressGroup { get; set; }

        /// <summary>
        /// Tungsten-Fabric firewall rule source network
        /// </summary>
        public string SrcNetwork { get; set; }

        /// <summary>
        /// Tungsten-Fabric firewall rule source tag
        /// </summary>
        public string SrcTag { get; set; }

        /// <summary>
        /// Tungsten-Fabric firewall rule tag type
        /// </summary>
        public string TagType { get; set; }

        /// <summary>
        /// Tungsten-Fabric firewall rule uuid
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
