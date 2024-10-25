using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListOauthProviderRequest : APIListRequest
    {
        public ListOauthProviderRequest() : base("listOauthProvider") {}

        /// <summary>
        /// the ID of the OAuth provider
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
        /// Name of the provider
        /// </summary>
        public string Provider {
            get { return GetParameterValue<string>(nameof(Provider).ToLower()); }
            set { SetParameterValue(nameof(Provider).ToLower(), value); }
        }

    }
    /// <summary>
    /// List OAuth providers registered
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<OauthProviderResponse> ListOauthProvider(ListOauthProviderRequest request);
        Task<ListResponse<OauthProviderResponse>> ListOauthProviderAsync(ListOauthProviderRequest request);
        ListResponse<OauthProviderResponse> ListOauthProviderAllPages(ListOauthProviderRequest request);
        Task<ListResponse<OauthProviderResponse>> ListOauthProviderAllPagesAsync(ListOauthProviderRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<OauthProviderResponse> ListOauthProvider(ListOauthProviderRequest request) => Proxy.Request<ListResponse<OauthProviderResponse>>(request);
        public Task<ListResponse<OauthProviderResponse>> ListOauthProviderAsync(ListOauthProviderRequest request) => Proxy.RequestAsync<ListResponse<OauthProviderResponse>>(request);
        public ListResponse<OauthProviderResponse> ListOauthProviderAllPages(ListOauthProviderRequest request) => Proxy.RequestAllPages<OauthProviderResponse>(request);
        public Task<ListResponse<OauthProviderResponse>> ListOauthProviderAllPagesAsync(ListOauthProviderRequest request) => Proxy.RequestAllPagesAsync<OauthProviderResponse>(request);
    }
}
