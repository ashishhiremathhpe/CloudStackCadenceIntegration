using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListNetscalerControlCenterRequest : APIListRequest
    {
        public ListNetscalerControlCenterRequest() : base("listNetscalerControlCenter") {}

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

    }
    /// <summary>
    /// list control center
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<NetscalerControlCenterResponse> ListNetscalerControlCenter(ListNetscalerControlCenterRequest request);
        Task<ListResponse<NetscalerControlCenterResponse>> ListNetscalerControlCenterAsync(ListNetscalerControlCenterRequest request);
        ListResponse<NetscalerControlCenterResponse> ListNetscalerControlCenterAllPages(ListNetscalerControlCenterRequest request);
        Task<ListResponse<NetscalerControlCenterResponse>> ListNetscalerControlCenterAllPagesAsync(ListNetscalerControlCenterRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<NetscalerControlCenterResponse> ListNetscalerControlCenter(ListNetscalerControlCenterRequest request) => Proxy.Request<ListResponse<NetscalerControlCenterResponse>>(request);
        public Task<ListResponse<NetscalerControlCenterResponse>> ListNetscalerControlCenterAsync(ListNetscalerControlCenterRequest request) => Proxy.RequestAsync<ListResponse<NetscalerControlCenterResponse>>(request);
        public ListResponse<NetscalerControlCenterResponse> ListNetscalerControlCenterAllPages(ListNetscalerControlCenterRequest request) => Proxy.RequestAllPages<NetscalerControlCenterResponse>(request);
        public Task<ListResponse<NetscalerControlCenterResponse>> ListNetscalerControlCenterAllPagesAsync(ListNetscalerControlCenterRequest request) => Proxy.RequestAllPagesAsync<NetscalerControlCenterResponse>(request);
    }
}
