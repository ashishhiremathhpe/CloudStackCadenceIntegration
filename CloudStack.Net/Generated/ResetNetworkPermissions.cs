using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ResetNetworkPermissionsRequest : APIRequest
    {
        public ResetNetworkPermissionsRequest() : base("resetNetworkPermissions") {}

        /// <summary>
        /// the network ID
        /// </summary>
        public Guid NetworkId {
            get { return GetParameterValue<Guid>(nameof(NetworkId).ToLower()); }
            set { SetParameterValue(nameof(NetworkId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Resets network permissions.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse ResetNetworkPermissions(ResetNetworkPermissionsRequest request);
        Task<SuccessResponse> ResetNetworkPermissionsAsync(ResetNetworkPermissionsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse ResetNetworkPermissions(ResetNetworkPermissionsRequest request) => Proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> ResetNetworkPermissionsAsync(ResetNetworkPermissionsRequest request) => Proxy.RequestAsync<SuccessResponse>(request);
    }
}
