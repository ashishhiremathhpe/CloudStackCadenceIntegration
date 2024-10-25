using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateKubernetesClusterRequest : APIRequest
    {
        public CreateKubernetesClusterRequest() : base("createKubernetesCluster") {}

        /// <summary>
        /// name for the Kubernetes cluster
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// availability zone in which Kubernetes cluster to be launched
        /// </summary>
        public Guid ZoneId {
            get { return GetParameterValue<Guid>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

        /// <summary>
        /// an optional account for the virtual machine. Must be used with domainId.
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// type of the cluster: CloudManaged, ExternalManaged. The default value is CloudManaged.
        /// </summary>
        public string ClusterType {
            get { return GetParameterValue<string>(nameof(ClusterType).ToLower()); }
            set { SetParameterValue(nameof(ClusterType).ToLower(), value); }
        }

        /// <summary>
        /// number of Kubernetes cluster control nodes, default is 1
        /// </summary>
        public long? ControlNodes {
            get { return GetParameterValue<long?>(nameof(ControlNodes).ToLower()); }
            set { SetParameterValue(nameof(ControlNodes).ToLower(), value); }
        }

        /// <summary>
        /// description for the Kubernetes cluster
        /// </summary>
        public string Description {
            get { return GetParameterValue<string>(nameof(Description).ToLower()); }
            set { SetParameterValue(nameof(Description).ToLower(), value); }
        }

        /// <summary>
        /// password for the docker image private registry
        /// </summary>
        public string DockerRegistryPassword {
            get { return GetParameterValue<string>(nameof(DockerRegistryPassword).ToLower()); }
            set { SetParameterValue(nameof(DockerRegistryPassword).ToLower(), value); }
        }

        /// <summary>
        /// URL for the docker image private registry
        /// </summary>
        public string DockerRegistryUrl {
            get { return GetParameterValue<string>(nameof(DockerRegistryUrl).ToLower()); }
            set { SetParameterValue(nameof(DockerRegistryUrl).ToLower(), value); }
        }

        /// <summary>
        /// user name for the docker image private registry
        /// </summary>
        public string DockerRegistryUserName {
            get { return GetParameterValue<string>(nameof(DockerRegistryUserName).ToLower()); }
            set { SetParameterValue(nameof(DockerRegistryUserName).ToLower(), value); }
        }

        /// <summary>
        /// an optional domainId for the virtual machine. If the account parameter is used, domainId must also be used.
        /// </summary>
        public Guid? DomainId {
            get { return GetParameterValue<Guid?>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// external load balancer IP address while using shared network with Kubernetes HA cluster
        /// </summary>
        public string ExternalLoadBalancerIpAddress {
            get { return GetParameterValue<string>(nameof(ExternalLoadBalancerIpAddress).ToLower()); }
            set { SetParameterValue(nameof(ExternalLoadBalancerIpAddress).ToLower(), value); }
        }

        /// <summary>
        /// name of the ssh key pair used to login to the virtual machines
        /// </summary>
        public string Keypair {
            get { return GetParameterValue<string>(nameof(Keypair).ToLower()); }
            set { SetParameterValue(nameof(Keypair).ToLower(), value); }
        }

        /// <summary>
        /// Kubernetes version with which cluster to be launched
        /// </summary>
        public Guid? KubernetesVersionId {
            get { return GetParameterValue<Guid?>(nameof(KubernetesVersionId).ToLower()); }
            set { SetParameterValue(nameof(KubernetesVersionId).ToLower(), value); }
        }

        /// <summary>
        /// number of Kubernetes cluster master nodes, default is 1. This option is deprecated, please use 'controlnodes' parameter.
        /// </summary>
        public long? MasterNodes {
            get { return GetParameterValue<long?>(nameof(MasterNodes).ToLower()); }
            set { SetParameterValue(nameof(MasterNodes).ToLower(), value); }
        }

        /// <summary>
        /// Network in which Kubernetes cluster is to be launched
        /// </summary>
        public Guid? NetworkId {
            get { return GetParameterValue<Guid?>(nameof(NetworkId).ToLower()); }
            set { SetParameterValue(nameof(NetworkId).ToLower(), value); }
        }

        /// <summary>
        /// root disk size in GB for each node
        /// </summary>
        public long? NodeRootDiskSize {
            get { return GetParameterValue<long?>(nameof(NodeRootDiskSize).ToLower()); }
            set { SetParameterValue(nameof(NodeRootDiskSize).ToLower(), value); }
        }

        /// <summary>
        /// Deploy cluster for the project
        /// </summary>
        public Guid? ProjectId {
            get { return GetParameterValue<Guid?>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the service offering for the virtual machines in the cluster.
        /// </summary>
        public Guid? ServiceOfferingId {
            get { return GetParameterValue<Guid?>(nameof(ServiceOfferingId).ToLower()); }
            set { SetParameterValue(nameof(ServiceOfferingId).ToLower(), value); }
        }

        /// <summary>
        /// number of Kubernetes cluster worker nodes
        /// </summary>
        public long? Size {
            get { return GetParameterValue<long?>(nameof(Size).ToLower()); }
            set { SetParameterValue(nameof(Size).ToLower(), value); }
        }

    }
    /// <summary>
    /// Creates a Kubernetes cluster
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse CreateKubernetesCluster(CreateKubernetesClusterRequest request);
        Task<AsyncJobResponse> CreateKubernetesClusterAsync(CreateKubernetesClusterRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse CreateKubernetesCluster(CreateKubernetesClusterRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> CreateKubernetesClusterAsync(CreateKubernetesClusterRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
