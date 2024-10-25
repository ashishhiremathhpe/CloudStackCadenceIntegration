using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class KubernetesClusterConfigResponse
    {
        /// <summary>
        /// the id of the container cluster
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the config data of the cluster
        /// </summary>
        public string ConfigData { get; set; }

        /// <summary>
        /// Name of the container cluster
        /// </summary>
        public string Name { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
