using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListRegisteredServicePackagesRequest : APIListRequest
    {
        public ListRegisteredServicePackagesRequest() : base("listRegisteredServicePackages") {}

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

    }
    /// <summary>
    /// lists registered service packages
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<NetScalerServicePackageResponse> ListRegisteredServicePackages(ListRegisteredServicePackagesRequest request);
        Task<ListResponse<NetScalerServicePackageResponse>> ListRegisteredServicePackagesAsync(ListRegisteredServicePackagesRequest request);
        ListResponse<NetScalerServicePackageResponse> ListRegisteredServicePackagesAllPages(ListRegisteredServicePackagesRequest request);
        Task<ListResponse<NetScalerServicePackageResponse>> ListRegisteredServicePackagesAllPagesAsync(ListRegisteredServicePackagesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<NetScalerServicePackageResponse> ListRegisteredServicePackages(ListRegisteredServicePackagesRequest request) => Proxy.Request<ListResponse<NetScalerServicePackageResponse>>(request);
        public Task<ListResponse<NetScalerServicePackageResponse>> ListRegisteredServicePackagesAsync(ListRegisteredServicePackagesRequest request) => Proxy.RequestAsync<ListResponse<NetScalerServicePackageResponse>>(request);
        public ListResponse<NetScalerServicePackageResponse> ListRegisteredServicePackagesAllPages(ListRegisteredServicePackagesRequest request) => Proxy.RequestAllPages<NetScalerServicePackageResponse>(request);
        public Task<ListResponse<NetScalerServicePackageResponse>> ListRegisteredServicePackagesAllPagesAsync(ListRegisteredServicePackagesRequest request) => Proxy.RequestAllPagesAsync<NetScalerServicePackageResponse>(request);
    }
}
