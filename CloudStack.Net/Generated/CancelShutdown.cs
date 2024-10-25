using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CancelShutdownRequest : APIRequest
    {
        public CancelShutdownRequest() : base("cancelShutdown") {}

        /// <summary>
        /// the uuid of the management server
        /// </summary>
        public Guid ManagementServerId {
            get { return GetParameterValue<Guid>(nameof(ManagementServerId).ToLower()); }
            set { SetParameterValue(nameof(ManagementServerId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Cancels a triggered shutdown
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ReadyForShutdownResponse CancelShutdown(CancelShutdownRequest request);
        Task<ReadyForShutdownResponse> CancelShutdownAsync(CancelShutdownRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ReadyForShutdownResponse CancelShutdown(CancelShutdownRequest request) => Proxy.Request<ReadyForShutdownResponse>(request);
        public Task<ReadyForShutdownResponse> CancelShutdownAsync(CancelShutdownRequest request) => Proxy.RequestAsync<ReadyForShutdownResponse>(request);
    }
}
