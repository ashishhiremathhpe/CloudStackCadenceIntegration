using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ReadyForShutdownRequest : APIRequest
    {
        public ReadyForShutdownRequest() : base("readyForShutdown") {}

        /// <summary>
        /// the uuid of the management server
        /// </summary>
        public Guid? ManagementServerId {
            get { return GetParameterValue<Guid?>(nameof(ManagementServerId).ToLower()); }
            set { SetParameterValue(nameof(ManagementServerId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Returns the status of CloudStack, whether a shutdown has been triggered and if ready to shutdown
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ReadyForShutdownResponse ReadyForShutdown(ReadyForShutdownRequest request);
        Task<ReadyForShutdownResponse> ReadyForShutdownAsync(ReadyForShutdownRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ReadyForShutdownResponse ReadyForShutdown(ReadyForShutdownRequest request) => Proxy.Request<ReadyForShutdownResponse>(request);
        public Task<ReadyForShutdownResponse> ReadyForShutdownAsync(ReadyForShutdownRequest request) => Proxy.RequestAsync<ReadyForShutdownResponse>(request);
    }
}
