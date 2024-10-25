using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ManagementServerResponse
    {
        /// <summary>
        /// the ID of the management server
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the java distribution name running the management server process
        /// </summary>
        public string JavaDistribution { get; set; }

        /// <summary>
        /// the version of the java distribution running the management server process
        /// </summary>
        public string JavaVersion { get; set; }

        /// <summary>
        /// the running OS kernel version for this Management Server
        /// </summary>
        public string KernelVersion { get; set; }

        /// <summary>
        /// the last time the host on which this Management Server runs was booted
        /// </summary>
        public DateTime Lastboottime { get; set; }

        /// <summary>
        /// the last time this Management Server was started
        /// </summary>
        public DateTime LastServerStart { get; set; }

        /// <summary>
        /// the last time this Management Server was stopped
        /// </summary>
        public DateTime LastServerStop { get; set; }

        /// <summary>
        /// the name of the management server
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// the name of the OS distribution running on the management server
        /// </summary>
        public string OsDistribution { get; set; }

        /// <summary>
        /// the IP Address for this Management Server
        /// </summary>
        public string ServiceIp { get; set; }

        /// <summary>
        /// the state of the management server
        /// </summary>
        public State State { get; set; }

        /// <summary>
        /// the version of the management server
        /// </summary>
        public string Version { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
