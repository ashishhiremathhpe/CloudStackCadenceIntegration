using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DetailOptionsResponse
    {
        /// <summary>
        /// Map of all possible details and their possible list of values
        /// </summary>
        public IDictionary<string, IList<string>> Details { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
