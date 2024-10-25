using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ConfigurationResponse
    {
        /// <summary>
        /// the value of the configuration
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// the category of the configuration
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// the component of the configuration
        /// </summary>
        public string Component { get; set; }

        /// <summary>
        /// the default value of the configuration
        /// </summary>
        public string DefaultValue { get; set; }

        /// <summary>
        /// the description of the configuration
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// the display text of the configuration
        /// </summary>
        public string DisplayText { get; set; }

        /// <summary>
        /// the group of the configuration
        /// </summary>
        public string Group { get; set; }

        /// <summary>
        /// true if the configuration is dynamic
        /// </summary>
        public bool IsDynamic { get; set; }

        /// <summary>
        /// the name of the configuration
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// the possible options of the configuration value
        /// </summary>
        public string Options { get; set; }

        /// <summary>
        /// the name of the parent configuration
        /// </summary>
        public string Parent { get; set; }

        /// <summary>
        /// scope(zone/cluster/pool/account) of the parameter that needs to be updated
        /// </summary>
        public string Scope { get; set; }

        /// <summary>
        /// the subgroup of the configuration
        /// </summary>
        public string SubGroup { get; set; }

        /// <summary>
        /// the type of the configuration value
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// the value of the configuration
        /// </summary>
        public string Value { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
