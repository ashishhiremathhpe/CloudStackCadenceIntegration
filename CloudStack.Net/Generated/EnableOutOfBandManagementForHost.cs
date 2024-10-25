using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class EnableOutOfBandManagementForHostRequest : APIRequest
    {
        public EnableOutOfBandManagementForHostRequest() : base("enableOutOfBandManagementForHost") {}

        /// <summary>
        /// the ID of the host
        /// </summary>
        public Guid HostId {
            get { return GetParameterValue<Guid>(nameof(HostId).ToLower()); }
            set { SetParameterValue(nameof(HostId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Enables out-of-band management for a host
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse EnableOutOfBandManagementForHost(EnableOutOfBandManagementForHostRequest request);
        Task<AsyncJobResponse> EnableOutOfBandManagementForHostAsync(EnableOutOfBandManagementForHostRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse EnableOutOfBandManagementForHost(EnableOutOfBandManagementForHostRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> EnableOutOfBandManagementForHostAsync(EnableOutOfBandManagementForHostRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
