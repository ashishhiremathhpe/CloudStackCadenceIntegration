using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpgradeKubernetesClusterRequest : APIRequest
    {
        public UpgradeKubernetesClusterRequest() : base("upgradeKubernetesCluster") {}

        /// <summary>
        /// the ID of the Kubernetes cluster
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the Kubernetes version for upgrade
        /// </summary>
        public Guid KubernetesVersionId {
            get { return GetParameterValue<Guid>(nameof(KubernetesVersionId).ToLower()); }
            set { SetParameterValue(nameof(KubernetesVersionId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Upgrades a running CloudManaged Kubernetes cluster
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse UpgradeKubernetesCluster(UpgradeKubernetesClusterRequest request);
        Task<AsyncJobResponse> UpgradeKubernetesClusterAsync(UpgradeKubernetesClusterRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse UpgradeKubernetesCluster(UpgradeKubernetesClusterRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> UpgradeKubernetesClusterAsync(UpgradeKubernetesClusterRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
