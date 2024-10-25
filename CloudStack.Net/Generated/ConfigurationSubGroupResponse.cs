using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ConfigurationSubGroupResponse
    {
        /// <summary>
        /// the name of the configuration subgroup
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// the precedence of the configuration subgroup
        /// </summary>
        public long Precedence { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
