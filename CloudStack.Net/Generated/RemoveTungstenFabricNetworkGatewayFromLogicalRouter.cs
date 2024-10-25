using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class RemoveTungstenFabricNetworkGatewayFromLogicalRouterRequest : APIRequest
    {
        public RemoveTungstenFabricNetworkGatewayFromLogicalRouterRequest() : base("removeTungstenFabricNetworkGatewayFromLogicalRouter") {}

        /// <summary>
        /// Tungsten-Fabric logical router uuid
        /// </summary>
        public string LogicalRouterUuid {
            get { return GetParameterValue<string>(nameof(LogicalRouterUuid).ToLower()); }
            set { SetParameterValue(nameof(LogicalRouterUuid).ToLower(), value); }
        }

        /// <summary>
        /// Tungsten-Fabric network uuid
        /// </summary>
        public string NetworkUuid {
            get { return GetParameterValue<string>(nameof(NetworkUuid).ToLower()); }
            set { SetParameterValue(nameof(NetworkUuid).ToLower(), value); }
        }

        /// <summary>
        /// the ID of zone
        /// </summary>
        public Guid ZoneId {
            get { return GetParameterValue<Guid>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

    }
    /// <summary>
    /// remove Tungsten-Fabric network gateway from logical router
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse RemoveTungstenFabricNetworkGatewayFromLogicalRouter(RemoveTungstenFabricNetworkGatewayFromLogicalRouterRequest request);
        Task<AsyncJobResponse> RemoveTungstenFabricNetworkGatewayFromLogicalRouterAsync(RemoveTungstenFabricNetworkGatewayFromLogicalRouterRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse RemoveTungstenFabricNetworkGatewayFromLogicalRouter(RemoveTungstenFabricNetworkGatewayFromLogicalRouterRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> RemoveTungstenFabricNetworkGatewayFromLogicalRouterAsync(RemoveTungstenFabricNetworkGatewayFromLogicalRouterRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
