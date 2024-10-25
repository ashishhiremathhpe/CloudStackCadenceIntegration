using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class TriggerShutdownRequest : APIRequest
    {
        public TriggerShutdownRequest() : base("triggerShutdown") {}

        /// <summary>
        /// the uuid of the management server
        /// </summary>
        public Guid ManagementServerId {
            get { return GetParameterValue<Guid>(nameof(ManagementServerId).ToLower()); }
            set { SetParameterValue(nameof(ManagementServerId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Triggers an automatic safe shutdown of CloudStack by not accepting new jobs and shutting down when all pending jobbs have been completed. Triggers an immediate shutdown if forced
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ReadyForShutdownResponse TriggerShutdown(TriggerShutdownRequest request);
        Task<ReadyForShutdownResponse> TriggerShutdownAsync(TriggerShutdownRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ReadyForShutdownResponse TriggerShutdown(TriggerShutdownRequest request) => Proxy.Request<ReadyForShutdownResponse>(request);
        public Task<ReadyForShutdownResponse> TriggerShutdownAsync(TriggerShutdownRequest request) => Proxy.RequestAsync<ReadyForShutdownResponse>(request);
    }
}
