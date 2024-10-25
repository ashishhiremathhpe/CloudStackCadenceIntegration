using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DisableHAForClusterRequest : APIRequest
    {
        public DisableHAForClusterRequest() : base("disableHAForCluster") {}

        /// <summary>
        /// ID of the cluster
        /// </summary>
        public Guid ClusterId {
            get { return GetParameterValue<Guid>(nameof(ClusterId).ToLower()); }
            set { SetParameterValue(nameof(ClusterId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Disables HA cluster-wide
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DisableHAForCluster(DisableHAForClusterRequest request);
        Task<AsyncJobResponse> DisableHAForClusterAsync(DisableHAForClusterRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DisableHAForCluster(DisableHAForClusterRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DisableHAForClusterAsync(DisableHAForClusterRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
