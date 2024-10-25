using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CloudianEnabledResponse
    {
        /// <summary>
        /// the Cloudian connector enabled state
        /// </summary>
        public bool Enabled { get; set; }

        /// <summary>
        /// the Cloudian Management Console base URL
        /// </summary>
        public string Url { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
