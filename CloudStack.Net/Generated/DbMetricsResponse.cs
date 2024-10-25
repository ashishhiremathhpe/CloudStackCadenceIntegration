using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DbMetricsResponse
    {
        /// <summary>
        /// the time these statistics were collected
        /// </summary>
        public DateTime CollectionTime { get; set; }

        /// <summary>
        /// the number of connections to the DB
        /// </summary>
        public int Connections { get; set; }

        /// <summary>
        /// the name of the active usage server
        /// </summary>
        public string Hostname { get; set; }

        /// <summary>
        /// the number of queries performed on the DB
        /// </summary>
        public long Queries { get; set; }

        /// <summary>
        /// the tls versions currently in use (accepted) by the DB
        /// </summary>
        public string TlsVersions { get; set; }

        /// <summary>
        /// the uptime of the DB in seconds
        /// </summary>
        public long Uptime { get; set; }

        /// <summary>
        /// the version of the currently running DB
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// the version of the currently running DB
        /// </summary>
        public string VersionComment { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
