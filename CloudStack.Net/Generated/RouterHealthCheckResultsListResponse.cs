using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class RouterHealthCheckResultsListResponse
    {
        /// <summary>
        /// the id of the router
        /// </summary>
        public IList<RouterHealthCheckResultResponse> HealthChecks { get; set; }

        /// <summary>
        /// the id of the router
        /// </summary>
        public string RouterId { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
