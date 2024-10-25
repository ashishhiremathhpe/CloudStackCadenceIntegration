using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class RemoveVirtualMachinesFromKubernetesClusterResponse
    {
        /// <summary>
        /// the id of the Kubernetes cluster
        /// </summary>
        public string Id { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
