using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DisableOutOfBandManagementForClusterRequest : APIRequest
    {
        public DisableOutOfBandManagementForClusterRequest() : base("disableOutOfBandManagementForCluster") {}

        /// <summary>
        /// the ID of the cluster
        /// </summary>
        public Guid ClusterId {
            get { return GetParameterValue<Guid>(nameof(ClusterId).ToLower()); }
            set { SetParameterValue(nameof(ClusterId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Disables out-of-band management for a cluster
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DisableOutOfBandManagementForCluster(DisableOutOfBandManagementForClusterRequest request);
        Task<AsyncJobResponse> DisableOutOfBandManagementForClusterAsync(DisableOutOfBandManagementForClusterRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DisableOutOfBandManagementForCluster(DisableOutOfBandManagementForClusterRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DisableOutOfBandManagementForClusterAsync(DisableOutOfBandManagementForClusterRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
