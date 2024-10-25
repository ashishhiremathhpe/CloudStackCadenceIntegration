using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class QuerySimulatorMockRequest : APIRequest
    {
        public QuerySimulatorMockRequest() : base("querySimulatorMock") {}

        /// <summary>
        /// id of the configured mock
        /// </summary>
        public long? Id {
            get { return GetParameterValue<long?>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// query simulator mock
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        MockResponse QuerySimulatorMock(QuerySimulatorMockRequest request);
        Task<MockResponse> QuerySimulatorMockAsync(QuerySimulatorMockRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public MockResponse QuerySimulatorMock(QuerySimulatorMockRequest request) => Proxy.Request<MockResponse>(request);
        public Task<MockResponse> QuerySimulatorMockAsync(QuerySimulatorMockRequest request) => Proxy.RequestAsync<MockResponse>(request);
    }
}
