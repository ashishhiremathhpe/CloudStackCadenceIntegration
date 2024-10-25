using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class EnableOutOfBandManagementForClusterRequest : APIRequest
    {
        public EnableOutOfBandManagementForClusterRequest() : base("enableOutOfBandManagementForCluster") {}

        /// <summary>
        /// the ID of the cluster
        /// </summary>
        public Guid ClusterId {
            get { return GetParameterValue<Guid>(nameof(ClusterId).ToLower()); }
            set { SetParameterValue(nameof(ClusterId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Enables out-of-band management for a cluster
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse EnableOutOfBandManagementForCluster(EnableOutOfBandManagementForClusterRequest request);
        Task<AsyncJobResponse> EnableOutOfBandManagementForClusterAsync(EnableOutOfBandManagementForClusterRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse EnableOutOfBandManagementForCluster(EnableOutOfBandManagementForClusterRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> EnableOutOfBandManagementForClusterAsync(EnableOutOfBandManagementForClusterRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
