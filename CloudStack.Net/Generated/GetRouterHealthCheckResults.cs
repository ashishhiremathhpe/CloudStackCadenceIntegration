using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class GetRouterHealthCheckResultsRequest : APIRequest
    {
        public GetRouterHealthCheckResultsRequest() : base("getRouterHealthCheckResults") {}

        /// <summary>
        /// the ID of the router
        /// </summary>
        public Guid RouterId {
            get { return GetParameterValue<Guid>(nameof(RouterId).ToLower()); }
            set { SetParameterValue(nameof(RouterId).ToLower(), value); }
        }

        /// <summary>
        /// if true is passed for this parameter, health checks are performed on the fly. Else last performed checks data is fetched
        /// </summary>
        public bool? PerformFreshChecks {
            get { return GetParameterValue<bool?>(nameof(PerformFreshChecks).ToLower()); }
            set { SetParameterValue(nameof(PerformFreshChecks).ToLower(), value); }
        }

    }
    /// <summary>
    /// Starts a router.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        RouterHealthCheckResultsListResponse GetRouterHealthCheckResults(GetRouterHealthCheckResultsRequest request);
        Task<RouterHealthCheckResultsListResponse> GetRouterHealthCheckResultsAsync(GetRouterHealthCheckResultsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public RouterHealthCheckResultsListResponse GetRouterHealthCheckResults(GetRouterHealthCheckResultsRequest request) => Proxy.Request<RouterHealthCheckResultsListResponse>(request);
        public Task<RouterHealthCheckResultsListResponse> GetRouterHealthCheckResultsAsync(GetRouterHealthCheckResultsRequest request) => Proxy.RequestAsync<RouterHealthCheckResultsListResponse>(request);
    }
}
