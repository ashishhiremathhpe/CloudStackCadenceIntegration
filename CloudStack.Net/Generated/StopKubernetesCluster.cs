using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class StopKubernetesClusterRequest : APIRequest
    {
        public StopKubernetesClusterRequest() : base("stopKubernetesCluster") {}

        /// <summary>
        /// the ID of the Kubernetes cluster
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Stops a running CloudManaged Kubernetes cluster
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse StopKubernetesCluster(StopKubernetesClusterRequest request);
        Task<AsyncJobResponse> StopKubernetesClusterAsync(StopKubernetesClusterRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse StopKubernetesCluster(StopKubernetesClusterRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> StopKubernetesClusterAsync(StopKubernetesClusterRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
