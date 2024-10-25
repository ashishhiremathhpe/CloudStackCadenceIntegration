using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ConfigurationGroupResponse
    {
        /// <summary>
        /// the description of the configuration group
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// the name of the configuration group
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// the precedence of the configuration group
        /// </summary>
        public long Precedence { get; set; }

        /// <summary>
        /// the subgroups of the configuration group
        /// </summary>
        public IList<ConfigurationSubGroupResponse> Subgroup { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
