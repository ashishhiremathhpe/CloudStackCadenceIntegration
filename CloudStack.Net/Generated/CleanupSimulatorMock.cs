using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CleanupSimulatorMockRequest : APIRequest
    {
        public CleanupSimulatorMockRequest() : base("cleanupSimulatorMock") {}

        /// <summary>
        /// id of the configured mock
        /// </summary>
        public long? Id {
            get { return GetParameterValue<long?>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// cleanup simulator mock
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse CleanupSimulatorMock(CleanupSimulatorMockRequest request);
        Task<SuccessResponse> CleanupSimulatorMockAsync(CleanupSimulatorMockRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse CleanupSimulatorMock(CleanupSimulatorMockRequest request) => Proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> CleanupSimulatorMockAsync(CleanupSimulatorMockRequest request) => Proxy.RequestAsync<SuccessResponse>(request);
    }
}
