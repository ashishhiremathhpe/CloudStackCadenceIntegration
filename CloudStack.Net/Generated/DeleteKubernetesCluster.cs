using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteKubernetesClusterRequest : APIRequest
    {
        public DeleteKubernetesClusterRequest() : base("deleteKubernetesCluster") {}

        /// <summary>
        /// the ID of the Kubernetes cluster
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// Destroy attached instances of the ExternalManaged Cluster. Default: false
        /// </summary>
        public bool? Cleanup {
            get { return GetParameterValue<bool?>(nameof(Cleanup).ToLower()); }
            set { SetParameterValue(nameof(Cleanup).ToLower(), value); }
        }

        /// <summary>
        /// Expunge attached instances of the ExternalManaged Cluster. If true, value of cleanup is ignored. Default: false
        /// </summary>
        public bool? Expunge {
            get { return GetParameterValue<bool?>(nameof(Expunge).ToLower()); }
            set { SetParameterValue(nameof(Expunge).ToLower(), value); }
        }

    }
    /// <summary>
    /// Deletes a Kubernetes cluster
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeleteKubernetesCluster(DeleteKubernetesClusterRequest request);
        Task<AsyncJobResponse> DeleteKubernetesClusterAsync(DeleteKubernetesClusterRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteKubernetesCluster(DeleteKubernetesClusterRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DeleteKubernetesClusterAsync(DeleteKubernetesClusterRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
