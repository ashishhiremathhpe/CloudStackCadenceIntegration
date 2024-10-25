using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class GetDiagnosticsDataResponse
    {
        /// <summary>
        /// Storage URL to download retrieve diagnostics data files
        /// </summary>
        public string Url { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
