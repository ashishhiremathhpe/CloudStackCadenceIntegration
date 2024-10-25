using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteOauthProviderRequest : APIRequest
    {
        public DeleteOauthProviderRequest() : base("deleteOauthProvider") {}

        /// <summary>
        /// id of the OAuth provider to be deleted
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Deletes the registered OAuth provider
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteOauthProvider(DeleteOauthProviderRequest request);
        Task<SuccessResponse> DeleteOauthProviderAsync(DeleteOauthProviderRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteOauthProvider(DeleteOauthProviderRequest request) => Proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> DeleteOauthProviderAsync(DeleteOauthProviderRequest request) => Proxy.RequestAsync<SuccessResponse>(request);
    }
}
