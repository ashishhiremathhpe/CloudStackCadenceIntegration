using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListGuestNetworkIpv6PrefixesRequest : APIListRequest
    {
        public ListGuestNetworkIpv6PrefixesRequest() : base("listGuestNetworkIpv6Prefixes") {}

        /// <summary>
        /// UUID of the IPv6 prefix.
        /// </summary>
        public Guid? Id {
            get { return GetParameterValue<Guid?>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// UUID of zone to which the IPv6 prefix belongs to.
        /// </summary>
        public Guid? ZoneId {
            get { return GetParameterValue<Guid?>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists guest network IPv6 prefixes
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<DataCenterGuestIpv6PrefixResponse> ListGuestNetworkIpv6Prefixes(ListGuestNetworkIpv6PrefixesRequest request);
        Task<ListResponse<DataCenterGuestIpv6PrefixResponse>> ListGuestNetworkIpv6PrefixesAsync(ListGuestNetworkIpv6PrefixesRequest request);
        ListResponse<DataCenterGuestIpv6PrefixResponse> ListGuestNetworkIpv6PrefixesAllPages(ListGuestNetworkIpv6PrefixesRequest request);
        Task<ListResponse<DataCenterGuestIpv6PrefixResponse>> ListGuestNetworkIpv6PrefixesAllPagesAsync(ListGuestNetworkIpv6PrefixesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<DataCenterGuestIpv6PrefixResponse> ListGuestNetworkIpv6Prefixes(ListGuestNetworkIpv6PrefixesRequest request) => Proxy.Request<ListResponse<DataCenterGuestIpv6PrefixResponse>>(request);
        public Task<ListResponse<DataCenterGuestIpv6PrefixResponse>> ListGuestNetworkIpv6PrefixesAsync(ListGuestNetworkIpv6PrefixesRequest request) => Proxy.RequestAsync<ListResponse<DataCenterGuestIpv6PrefixResponse>>(request);
        public ListResponse<DataCenterGuestIpv6PrefixResponse> ListGuestNetworkIpv6PrefixesAllPages(ListGuestNetworkIpv6PrefixesRequest request) => Proxy.RequestAllPages<DataCenterGuestIpv6PrefixResponse>(request);
        public Task<ListResponse<DataCenterGuestIpv6PrefixResponse>> ListGuestNetworkIpv6PrefixesAllPagesAsync(ListGuestNetworkIpv6PrefixesRequest request) => Proxy.RequestAllPagesAsync<DataCenterGuestIpv6PrefixResponse>(request);
    }
}
