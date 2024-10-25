using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ScaleKubernetesClusterRequest : APIRequest
    {
        public ScaleKubernetesClusterRequest() : base("scaleKubernetesCluster") {}

        /// <summary>
        /// the ID of the Kubernetes cluster
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// Whether autoscaling is enabled for the cluster
        /// </summary>
        public bool? Autoscalingenabled {
            get { return GetParameterValue<bool?>(nameof(Autoscalingenabled).ToLower()); }
            set { SetParameterValue(nameof(Autoscalingenabled).ToLower(), value); }
        }

        /// <summary>
        /// Maximum number of worker nodes in the cluster
        /// </summary>
        public long? MaxSize {
            get { return GetParameterValue<long?>(nameof(MaxSize).ToLower()); }
            set { SetParameterValue(nameof(MaxSize).ToLower(), value); }
        }

        /// <summary>
        /// Minimum number of worker nodes in the cluster
        /// </summary>
        public long? MinSize {
            get { return GetParameterValue<long?>(nameof(MinSize).ToLower()); }
            set { SetParameterValue(nameof(MinSize).ToLower(), value); }
        }

        /// <summary>
        /// the IDs of the nodes to be removed
        /// </summary>
        public IList<Guid> NodeIds {
            get { return GetList<Guid>(nameof(NodeIds).ToLower()); }
            set { SetParameterValue(nameof(NodeIds).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the service offering for the virtual machines in the cluster.
        /// </summary>
        public Guid? ServiceOfferingId {
            get { return GetParameterValue<Guid?>(nameof(ServiceOfferingId).ToLower()); }
            set { SetParameterValue(nameof(ServiceOfferingId).ToLower(), value); }
        }

        /// <summary>
        /// number of Kubernetes cluster nodes
        /// </summary>
        public long? Size {
            get { return GetParameterValue<long?>(nameof(Size).ToLower()); }
            set { SetParameterValue(nameof(Size).ToLower(), value); }
        }

    }
    /// <summary>
    /// Scales a created, running or stopped CloudManaged Kubernetes cluster
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse ScaleKubernetesCluster(ScaleKubernetesClusterRequest request);
        Task<AsyncJobResponse> ScaleKubernetesClusterAsync(ScaleKubernetesClusterRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse ScaleKubernetesCluster(ScaleKubernetesClusterRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> ScaleKubernetesClusterAsync(ScaleKubernetesClusterRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
