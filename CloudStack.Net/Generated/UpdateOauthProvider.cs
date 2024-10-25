using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateOauthProviderRequest : APIRequest
    {
        public UpdateOauthProviderRequest() : base("updateOauthProvider") {}

        /// <summary>
        /// id of the OAuth provider to be updated
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

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
        /// OAuth provider will be enabled or disabled based on this value
        /// </summary>
        public bool? Enabled {
            get { return GetParameterValue<bool?>(nameof(Enabled).ToLower()); }
            set { SetParameterValue(nameof(Enabled).ToLower(), value); }
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

    }
    /// <summary>
    /// Updates the registered OAuth provider details
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        OauthProviderResponse UpdateOauthProvider(UpdateOauthProviderRequest request);
        Task<OauthProviderResponse> UpdateOauthProviderAsync(UpdateOauthProviderRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public OauthProviderResponse UpdateOauthProvider(UpdateOauthProviderRequest request) => Proxy.Request<OauthProviderResponse>(request);
        public Task<OauthProviderResponse> UpdateOauthProviderAsync(UpdateOauthProviderRequest request) => Proxy.RequestAsync<OauthProviderResponse>(request);
    }
}
