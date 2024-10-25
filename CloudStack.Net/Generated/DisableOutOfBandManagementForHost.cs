using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DisableOutOfBandManagementForHostRequest : APIRequest
    {
        public DisableOutOfBandManagementForHostRequest() : base("disableOutOfBandManagementForHost") {}

        /// <summary>
        /// the ID of the host
        /// </summary>
        public Guid HostId {
            get { return GetParameterValue<Guid>(nameof(HostId).ToLower()); }
            set { SetParameterValue(nameof(HostId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Disables out-of-band management for a host
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DisableOutOfBandManagementForHost(DisableOutOfBandManagementForHostRequest request);
        Task<AsyncJobResponse> DisableOutOfBandManagementForHostAsync(DisableOutOfBandManagementForHostRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DisableOutOfBandManagementForHost(DisableOutOfBandManagementForHostRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DisableOutOfBandManagementForHostAsync(DisableOutOfBandManagementForHostRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
