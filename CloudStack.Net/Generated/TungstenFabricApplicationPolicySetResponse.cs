using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class TungstenFabricApplicationPolicySetResponse
    {
        /// <summary>
        /// list Tungsten-Fabric firewall policy
        /// </summary>
        public IList<TungstenFabricFirewallPolicyResponse> Firewallpolicy { get; set; }

        /// <summary>
        /// Tungsten-Fabric policy name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// list Tungsten-Fabric tag
        /// </summary>
        public IList<TungstenFabricTagResponse> Tag { get; set; }

        /// <summary>
        /// Tungsten-Fabric application policy uuid
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
