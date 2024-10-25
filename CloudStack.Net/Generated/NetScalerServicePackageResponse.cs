using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class NetScalerServicePackageResponse
    {
        /// <summary>
        /// Service Package UUID
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Description of Service Package
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Service Package Name
        /// </summary>
        public string Name { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
