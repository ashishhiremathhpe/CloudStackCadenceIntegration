using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class RoleResponse
    {
        /// <summary>
        /// true if role is default, false otherwise
        /// </summary>
        public bool IsDefault { get; set; }

        /// <summary>
        /// the type of the role
        /// </summary>
        public string Type { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
