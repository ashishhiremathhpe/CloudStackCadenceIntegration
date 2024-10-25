using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CAProviderResponse
    {
        /// <summary>
        /// the description of the CA service provider
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// the CA service provider name
        /// </summary>
        public string Name { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
