using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListUserTwoFactorAuthenticatorProvidersRequest : APIRequest
    {
        public ListUserTwoFactorAuthenticatorProvidersRequest() : base("listUserTwoFactorAuthenticatorProviders") {}

        /// <summary>
        /// List user two factor authenticator provider by name
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists user two factor authenticator providers
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        UserTwoFactorAuthenticatorProviderResponse ListUserTwoFactorAuthenticatorProviders(ListUserTwoFactorAuthenticatorProvidersRequest request);
        Task<UserTwoFactorAuthenticatorProviderResponse> ListUserTwoFactorAuthenticatorProvidersAsync(ListUserTwoFactorAuthenticatorProvidersRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public UserTwoFactorAuthenticatorProviderResponse ListUserTwoFactorAuthenticatorProviders(ListUserTwoFactorAuthenticatorProvidersRequest request) => Proxy.Request<UserTwoFactorAuthenticatorProviderResponse>(request);
        public Task<UserTwoFactorAuthenticatorProviderResponse> ListUserTwoFactorAuthenticatorProvidersAsync(ListUserTwoFactorAuthenticatorProvidersRequest request) => Proxy.RequestAsync<UserTwoFactorAuthenticatorProviderResponse>(request);
    }
}
