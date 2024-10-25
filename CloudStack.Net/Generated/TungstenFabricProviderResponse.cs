using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class TungstenFabricProviderResponse
    {
        /// <summary>
        /// Tungsten-Fabric provider name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// true if security groups support is enabled, false otherwise
        /// </summary>
        public bool SecurityGroupsEnabled { get; set; }

        /// <summary>
        /// Tungsten-Fabric provider gateway
        /// </summary>
        public string Tungstengateway { get; set; }

        /// <summary>
        /// Tungsten-Fabric provider hostname
        /// </summary>
        public string Tungstenproviderhostname { get; set; }

        /// <summary>
        /// Tungsten-Fabric provider introspect port
        /// </summary>
        public string Tungstenproviderintrospectport { get; set; }

        /// <summary>
        /// Tungsten-Fabric provider port
        /// </summary>
        public string Tungstenproviderport { get; set; }

        /// <summary>
        /// Tungsten-Fabric provider uuid
        /// </summary>
        public string Tungstenprovideruuid { get; set; }

        /// <summary>
        /// Tungsten-Fabric provider vrouter port
        /// </summary>
        public string Tungstenprovidervrouterport { get; set; }

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
