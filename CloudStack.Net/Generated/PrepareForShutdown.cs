using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class PrepareForShutdownRequest : APIRequest
    {
        public PrepareForShutdownRequest() : base("prepareForShutdown") {}

        /// <summary>
        /// the uuid of the management server
        /// </summary>
        public Guid ManagementServerId {
            get { return GetParameterValue<Guid>(nameof(ManagementServerId).ToLower()); }
            set { SetParameterValue(nameof(ManagementServerId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Prepares CloudStack for a safe manual shutdown by preventing new jobs from being accepted
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ReadyForShutdownResponse PrepareForShutdown(PrepareForShutdownRequest request);
        Task<ReadyForShutdownResponse> PrepareForShutdownAsync(PrepareForShutdownRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ReadyForShutdownResponse PrepareForShutdown(PrepareForShutdownRequest request) => Proxy.Request<ReadyForShutdownResponse>(request);
        public Task<ReadyForShutdownResponse> PrepareForShutdownAsync(PrepareForShutdownRequest request) => Proxy.RequestAsync<ReadyForShutdownResponse>(request);
    }
}
