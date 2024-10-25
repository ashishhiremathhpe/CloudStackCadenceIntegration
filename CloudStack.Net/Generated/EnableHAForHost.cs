using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class EnableHAForHostRequest : APIRequest
    {
        public EnableHAForHostRequest() : base("enableHAForHost") {}

        /// <summary>
        /// ID of the host
        /// </summary>
        public Guid HostId {
            get { return GetParameterValue<Guid>(nameof(HostId).ToLower()); }
            set { SetParameterValue(nameof(HostId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Enables HA for a host
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse EnableHAForHost(EnableHAForHostRequest request);
        Task<AsyncJobResponse> EnableHAForHostAsync(EnableHAForHostRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse EnableHAForHost(EnableHAForHostRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> EnableHAForHostAsync(EnableHAForHostRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
