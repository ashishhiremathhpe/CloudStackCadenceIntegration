using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class RouterHealthCheckResultResponse
    {
        /// <summary>
        /// the name of the health check on the router
        /// </summary>
        public string CheckName { get; set; }

        /// <summary>
        /// the type of the health check - basic or advanced
        /// </summary>
        public string CheckType { get; set; }

        /// <summary>
        /// detailed response generated on running health check
        /// </summary>
        public string Details { get; set; }

        /// <summary>
        /// the date this VPC was created
        /// </summary>
        public DateTime LastUpdated { get; set; }

        /// <summary>
        /// result of the health check
        /// </summary>
        public bool Success { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
