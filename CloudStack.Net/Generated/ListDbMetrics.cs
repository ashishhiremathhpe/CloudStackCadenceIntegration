using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListDbMetricsRequest : APIRequest
    {
        public ListDbMetricsRequest() : base("listDbMetrics") {}

    }
    /// <summary>
    /// list the db hosts and statistics
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        DbMetricsResponse ListDbMetrics(ListDbMetricsRequest request);
        Task<DbMetricsResponse> ListDbMetricsAsync(ListDbMetricsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public DbMetricsResponse ListDbMetrics(ListDbMetricsRequest request) => Proxy.Request<DbMetricsResponse>(request);
        public Task<DbMetricsResponse> ListDbMetricsAsync(ListDbMetricsRequest request) => Proxy.RequestAsync<DbMetricsResponse>(request);
    }
}
