using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class VerifyOAuthCodeAndGetUserRequest : APIListRequest
    {
        public VerifyOAuthCodeAndGetUserRequest() : base("verifyOAuthCodeAndGetUser") {}

        /// <summary>
        /// Name of the provider
        /// </summary>
        public string Provider {
            get { return GetParameterValue<string>(nameof(Provider).ToLower()); }
            set { SetParameterValue(nameof(Provider).ToLower(), value); }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// Code that is provided by OAuth provider (Eg. google, github) after successful login
        /// </summary>
        public string SecretCode {
            get { return GetParameterValue<string>(nameof(SecretCode).ToLower()); }
            set { SetParameterValue(nameof(SecretCode).ToLower(), value); }
        }

    }
    /// <summary>
    /// Verify the OAuth Code and fetch the corresponding user from provider
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<OauthProviderResponse> VerifyOAuthCodeAndGetUser(VerifyOAuthCodeAndGetUserRequest request);
        Task<ListResponse<OauthProviderResponse>> VerifyOAuthCodeAndGetUserAsync(VerifyOAuthCodeAndGetUserRequest request);
        ListResponse<OauthProviderResponse> VerifyOAuthCodeAndGetUserAllPages(VerifyOAuthCodeAndGetUserRequest request);
        Task<ListResponse<OauthProviderResponse>> VerifyOAuthCodeAndGetUserAllPagesAsync(VerifyOAuthCodeAndGetUserRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<OauthProviderResponse> VerifyOAuthCodeAndGetUser(VerifyOAuthCodeAndGetUserRequest request) => Proxy.Request<ListResponse<OauthProviderResponse>>(request);
        public Task<ListResponse<OauthProviderResponse>> VerifyOAuthCodeAndGetUserAsync(VerifyOAuthCodeAndGetUserRequest request) => Proxy.RequestAsync<ListResponse<OauthProviderResponse>>(request);
        public ListResponse<OauthProviderResponse> VerifyOAuthCodeAndGetUserAllPages(VerifyOAuthCodeAndGetUserRequest request) => Proxy.RequestAllPages<OauthProviderResponse>(request);
        public Task<ListResponse<OauthProviderResponse>> VerifyOAuthCodeAndGetUserAllPagesAsync(VerifyOAuthCodeAndGetUserRequest request) => Proxy.RequestAllPagesAsync<OauthProviderResponse>(request);
    }
}
