using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class KubernetesClusterResponse
    {
        /// <summary>
        /// the id of the Kubernetes cluster
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the account associated with the Kubernetes cluster
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// the name of the network of the Kubernetes cluster
        /// </summary>
        public string AssociatedNetworkName { get; set; }

        /// <summary>
        /// Whether autoscaling is enabled for the cluster
        /// </summary>
        public bool Autoscalingenabled { get; set; }

        /// <summary>
        /// the type of the cluster
        /// </summary>
        public KubernetesClusterClusterType ClusterType { get; set; }

        /// <summary>
        /// URL end point for the Kubernetes cluster dashboard UI
        /// </summary>
        public string ConsoleEndpoint { get; set; }

        /// <summary>
        /// the control nodes count for the Kubernetes cluster
        /// </summary>
        public long ControlNodes { get; set; }

        /// <summary>
        /// the cpu cores of the Kubernetes cluster
        /// </summary>
        public string Cpunumber { get; set; }

        /// <summary>
        /// the date when this Kubernetes cluster was created
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// the description of the Kubernetes cluster
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// the name of the domain in which the Kubernetes cluster exists
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// the ID of the domain in which the Kubernetes cluster exists
        /// </summary>
        public string DomainId { get; set; }

        /// <summary>
        /// URL end point for the Kubernetes cluster
        /// </summary>
        public string Endpoint { get; set; }

        /// <summary>
        /// Public IP Address of the cluster
        /// </summary>
        public string IpAddress { get; set; }

        /// <summary>
        /// Public IP Address ID of the cluster
        /// </summary>
        public string IpAddressId { get; set; }

        /// <summary>
        /// keypair details
        /// </summary>
        public string Keypair { get; set; }

        /// <summary>
        /// the ID of the Kubernetes version for the Kubernetes cluster
        /// </summary>
        public string KubernetesVersionId { get; set; }

        /// <summary>
        /// the name of the Kubernetes version for the Kubernetes cluster
        /// </summary>
        public string KubernetesVersionName { get; set; }

        /// <summary>
        /// the master nodes count for the Kubernetes cluster. This parameter is deprecated, please use 'controlnodes' parameter.
        /// </summary>
        public long MasterNodes { get; set; }

        /// <summary>
        /// Maximum size of the cluster
        /// </summary>
        public long MaxSize { get; set; }

        /// <summary>
        /// the memory the Kubernetes cluster
        /// </summary>
        public string Memory { get; set; }

        /// <summary>
        /// Minimum size of the cluster
        /// </summary>
        public long MinSize { get; set; }

        /// <summary>
        /// the name of the Kubernetes cluster
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// the ID of the network of the Kubernetes cluster
        /// </summary>
        public string NetworkId { get; set; }

        /// <summary>
        /// the project name of the Kubernetes cluster
        /// </summary>
        public string Project { get; set; }

        /// <summary>
        /// the project id of the Kubernetes cluster
        /// </summary>
        public string ProjectId { get; set; }

        /// <summary>
        /// the ID of the service offering of the Kubernetes cluster
        /// </summary>
        public string ServiceOfferingId { get; set; }

        /// <summary>
        /// the name of the service offering of the Kubernetes cluster
        /// </summary>
        public string ServiceOfferingName { get; set; }

        /// <summary>
        /// the size (worker nodes count) of the Kubernetes cluster
        /// </summary>
        public long Size { get; set; }

        /// <summary>
        /// the state of the Kubernetes cluster
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// the ID of the template of the Kubernetes cluster
        /// </summary>
        public string TemplateId { get; set; }

        /// <summary>
        /// the list of virtualmachine associated with this Kubernetes cluster
        /// </summary>
        public IList<UserVmResponse> VirtualMachines { get; set; }

        /// <summary>
        /// the name of the zone of the Kubernetes cluster
        /// </summary>
        public string ZoneId { get; set; }

        /// <summary>
        /// the name of the zone of the Kubernetes cluster
        /// </summary>
        public string ZoneName { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
