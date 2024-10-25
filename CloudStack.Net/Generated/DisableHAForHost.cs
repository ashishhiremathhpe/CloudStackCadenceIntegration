using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DisableHAForHostRequest : APIRequest
    {
        public DisableHAForHostRequest() : base("disableHAForHost") {}

        /// <summary>
        /// ID of the host
        /// </summary>
        public Guid HostId {
            get { return GetParameterValue<Guid>(nameof(HostId).ToLower()); }
            set { SetParameterValue(nameof(HostId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Disables HA for a host
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DisableHAForHost(DisableHAForHostRequest request);
        Task<AsyncJobResponse> DisableHAForHostAsync(DisableHAForHostRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DisableHAForHost(DisableHAForHostRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DisableHAForHostAsync(DisableHAForHostRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
