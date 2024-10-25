using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListQuarantinedIpsRequest : APIListRequest
    {
        public ListQuarantinedIpsRequest() : base("listQuarantinedIps") {}

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// Show IPs that are no longer in quarantine.
        /// </summary>
        public bool? ShowInactive {
            get { return GetParameterValue<bool?>(nameof(ShowInactive).ToLower()); }
            set { SetParameterValue(nameof(ShowInactive).ToLower(), value); }
        }

        /// <summary>
        /// Show IPs removed from quarantine.
        /// </summary>
        public bool? ShowRemoved {
            get { return GetParameterValue<bool?>(nameof(ShowRemoved).ToLower()); }
            set { SetParameterValue(nameof(ShowRemoved).ToLower(), value); }
        }

    }
    /// <summary>
    /// List public IP addresses in quarantine.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<IpQuarantineResponse> ListQuarantinedIps(ListQuarantinedIpsRequest request);
        Task<ListResponse<IpQuarantineResponse>> ListQuarantinedIpsAsync(ListQuarantinedIpsRequest request);
        ListResponse<IpQuarantineResponse> ListQuarantinedIpsAllPages(ListQuarantinedIpsRequest request);
        Task<ListResponse<IpQuarantineResponse>> ListQuarantinedIpsAllPagesAsync(ListQuarantinedIpsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<IpQuarantineResponse> ListQuarantinedIps(ListQuarantinedIpsRequest request) => Proxy.Request<ListResponse<IpQuarantineResponse>>(request);
        public Task<ListResponse<IpQuarantineResponse>> ListQuarantinedIpsAsync(ListQuarantinedIpsRequest request) => Proxy.RequestAsync<ListResponse<IpQuarantineResponse>>(request);
        public ListResponse<IpQuarantineResponse> ListQuarantinedIpsAllPages(ListQuarantinedIpsRequest request) => Proxy.RequestAllPages<IpQuarantineResponse>(request);
        public Task<ListResponse<IpQuarantineResponse>> ListQuarantinedIpsAllPagesAsync(ListQuarantinedIpsRequest request) => Proxy.RequestAllPagesAsync<IpQuarantineResponse>(request);
    }
}
