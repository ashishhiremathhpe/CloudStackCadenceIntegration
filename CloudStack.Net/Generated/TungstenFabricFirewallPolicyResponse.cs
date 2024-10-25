using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class TungstenFabricFirewallPolicyResponse
    {
        /// <summary>
        /// list Tungsten-Fabric firewall rule
        /// </summary>
        public IList<TungstenFabricFirewallRuleResponse> Firewallrule { get; set; }

        /// <summary>
        /// Tungsten-Fabric firewall policy name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Tungsten-Fabric firewall policy uuid
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
