using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class RegisterOauthProviderRequest : APIRequest
    {
        public RegisterOauthProviderRequest() : base("registerOauthProvider") {}

        /// <summary>
        /// Client ID pre-registered in the specific OAuth provider
        /// </summary>
        public string ClientId {
            get { return GetParameterValue<string>(nameof(ClientId).ToLower()); }
            set { SetParameterValue(nameof(ClientId).ToLower(), value); }
        }

        /// <summary>
        /// Description of the OAuth Provider
        /// </summary>
        public string Description {
            get { return GetParameterValue<string>(nameof(Description).ToLower()); }
            set { SetParameterValue(nameof(Description).ToLower(), value); }
        }

        /// <summary>
        /// Name of the provider from the list of OAuth providers supported in CloudStack
        /// </summary>
        public string Provider {
            get { return GetParameterValue<string>(nameof(Provider).ToLower()); }
            set { SetParameterValue(nameof(Provider).ToLower(), value); }
        }

        /// <summary>
        /// Redirect URI pre-registered in the specific OAuth provider
        /// </summary>
        public string RedirectUri {
            get { return GetParameterValue<string>(nameof(RedirectUri).ToLower()); }
            set { SetParameterValue(nameof(RedirectUri).ToLower(), value); }
        }

        /// <summary>
        /// Secret Key pre-registered in the specific OAuth provider
        /// </summary>
        public string SecretKey {
            get { return GetParameterValue<string>(nameof(SecretKey).ToLower()); }
            set { SetParameterValue(nameof(SecretKey).ToLower(), value); }
        }

        /// <summary>
        /// Any OAuth provider details in key/value pairs using format details[i].keyname=keyvalue. Example: details[0].clientsecret=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
        /// </summary>
        public IList<IDictionary<string, object>> Details {
            get { return GetList<IDictionary<string, object>>(nameof(Details).ToLower()); }
            set { SetParameterValue(nameof(Details).ToLower(), value); }
        }

    }
    /// <summary>
    /// Register the OAuth2 provider in CloudStack
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse RegisterOauthProvider(RegisterOauthProviderRequest request);
        Task<SuccessResponse> RegisterOauthProviderAsync(RegisterOauthProviderRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse RegisterOauthProvider(RegisterOauthProviderRequest request) => Proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> RegisterOauthProviderAsync(RegisterOauthProviderRequest request) => Proxy.RequestAsync<SuccessResponse>(request);
    }
}
