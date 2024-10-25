using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListUsageServerMetricsRequest : APIRequest
    {
        public ListUsageServerMetricsRequest() : base("listUsageServerMetrics") {}

    }
    /// <summary>
    /// Lists Usage Server metrics
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        UsageServerMetricsResponse ListUsageServerMetrics(ListUsageServerMetricsRequest request);
        Task<UsageServerMetricsResponse> ListUsageServerMetricsAsync(ListUsageServerMetricsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public UsageServerMetricsResponse ListUsageServerMetrics(ListUsageServerMetricsRequest request) => Proxy.Request<UsageServerMetricsResponse>(request);
        public Task<UsageServerMetricsResponse> ListUsageServerMetricsAsync(ListUsageServerMetricsRequest request) => Proxy.RequestAsync<UsageServerMetricsResponse>(request);
    }
}
