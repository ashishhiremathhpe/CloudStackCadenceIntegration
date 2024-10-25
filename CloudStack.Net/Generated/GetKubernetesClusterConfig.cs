using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class GetKubernetesClusterConfigRequest : APIRequest
    {
        public GetKubernetesClusterConfigRequest() : base("getKubernetesClusterConfig") {}

        /// <summary>
        /// the ID of the Kubernetes cluster
        /// </summary>
        public Guid? Id {
            get { return GetParameterValue<Guid?>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Get Kubernetes cluster config
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        KubernetesClusterConfigResponse GetKubernetesClusterConfig(GetKubernetesClusterConfigRequest request);
        Task<KubernetesClusterConfigResponse> GetKubernetesClusterConfigAsync(GetKubernetesClusterConfigRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public KubernetesClusterConfigResponse GetKubernetesClusterConfig(GetKubernetesClusterConfigRequest request) => Proxy.Request<KubernetesClusterConfigResponse>(request);
        public Task<KubernetesClusterConfigResponse> GetKubernetesClusterConfigAsync(GetKubernetesClusterConfigRequest request) => Proxy.RequestAsync<KubernetesClusterConfigResponse>(request);
    }
}
