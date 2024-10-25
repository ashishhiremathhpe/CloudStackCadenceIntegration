using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class GetUserKeysRequest : APIRequest
    {
        public GetUserKeysRequest() : base("getUserKeys") {}

        /// <summary>
        /// ID of the user whose keys are required
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// This command allows the user to query the seceret and API keys for the account
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        RegisterResponse GetUserKeys(GetUserKeysRequest request);
        Task<RegisterResponse> GetUserKeysAsync(GetUserKeysRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public RegisterResponse GetUserKeys(GetUserKeysRequest request) => Proxy.Request<RegisterResponse>(request);
        public Task<RegisterResponse> GetUserKeysAsync(GetUserKeysRequest request) => Proxy.RequestAsync<RegisterResponse>(request);
    }
}
