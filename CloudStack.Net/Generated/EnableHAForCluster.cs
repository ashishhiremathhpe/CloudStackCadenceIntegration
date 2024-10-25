using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class EnableHAForClusterRequest : APIRequest
    {
        public EnableHAForClusterRequest() : base("enableHAForCluster") {}

        /// <summary>
        /// ID of the cluster
        /// </summary>
        public Guid ClusterId {
            get { return GetParameterValue<Guid>(nameof(ClusterId).ToLower()); }
            set { SetParameterValue(nameof(ClusterId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Enables HA cluster-wide
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse EnableHAForCluster(EnableHAForClusterRequest request);
        Task<AsyncJobResponse> EnableHAForClusterAsync(EnableHAForClusterRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse EnableHAForCluster(EnableHAForClusterRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> EnableHAForClusterAsync(EnableHAForClusterRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
