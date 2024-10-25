using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListNetworkPermissionsRequest : APIRequest
    {
        public ListNetworkPermissionsRequest() : base("listNetworkPermissions") {}

        /// <summary>
        /// Lists network permission by network ID
        /// </summary>
        public Guid NetworkId {
            get { return GetParameterValue<Guid>(nameof(NetworkId).ToLower()); }
            set { SetParameterValue(nameof(NetworkId).ToLower(), value); }
        }

    }
    /// <summary>
    /// List network visibility and all accounts that have permissions to view this network.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        NetworkPermissionsResponse ListNetworkPermissions(ListNetworkPermissionsRequest request);
        Task<NetworkPermissionsResponse> ListNetworkPermissionsAsync(ListNetworkPermissionsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public NetworkPermissionsResponse ListNetworkPermissions(ListNetworkPermissionsRequest request) => Proxy.Request<NetworkPermissionsResponse>(request);
        public Task<NetworkPermissionsResponse> ListNetworkPermissionsAsync(ListNetworkPermissionsRequest request) => Proxy.RequestAsync<NetworkPermissionsResponse>(request);
    }
}
