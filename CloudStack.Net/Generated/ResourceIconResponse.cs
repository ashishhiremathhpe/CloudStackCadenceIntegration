using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ResourceIconResponse
    {
        /// <summary>
        /// base64 representation of resource icon
        /// </summary>
        public string Base64image { get; set; }

        /// <summary>
        /// id of the resource
        /// </summary>
        public string ResourceId { get; set; }

        /// <summary>
        /// resource type
        /// </summary>
        public ResourceObjectType ResourceType { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
