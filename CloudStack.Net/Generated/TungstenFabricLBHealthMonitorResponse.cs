using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class TungstenFabricLBHealthMonitorResponse
    {
        /// <summary>
        /// the health monitor ID
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// the health monitor expected code
        /// </summary>
        public string ExpectedCode { get; set; }

        /// <summary>
        /// the health monitor http method
        /// </summary>
        public string HttpMethod { get; set; }

        /// <summary>
        /// the health monitor interval
        /// </summary>
        public int Interval { get; set; }

        /// <summary>
        /// the LB rule ID
        /// </summary>
        public string LbRuleId { get; set; }

        /// <summary>
        /// the health monitor retry
        /// </summary>
        public int Retry { get; set; }

        /// <summary>
        /// the health monitor timeout
        /// </summary>
        public int Timeout { get; set; }

        /// <summary>
        /// the health monitor type
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// the health monitor url path
        /// </summary>
        public string UrlPath { get; set; }

        /// <summary>
        /// the health monitor UUID
        /// </summary>
        public string Uuid { get; set; }

        /// <summary>
        /// Tungsten-Fabric provider zone id
        /// </summary>
        public long ZoneId { get; set; }

        /// <summary>
        /// Tungsten-Fabric provider zone name
        /// </summary>
        public string ZoneName { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
