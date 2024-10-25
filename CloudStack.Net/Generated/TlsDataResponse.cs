using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class TlsDataResponse
    {
        /// <summary>
        /// chain
        /// </summary>
        public string Chain { get; set; }

        /// <summary>
        /// crt
        /// </summary>
        public string Crt { get; set; }

        /// <summary>
        /// key
        /// </summary>
        public string Key { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
