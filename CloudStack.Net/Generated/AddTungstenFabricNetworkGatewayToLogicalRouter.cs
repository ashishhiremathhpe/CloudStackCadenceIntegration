using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AddTungstenFabricNetworkGatewayToLogicalRouterRequest : APIRequest
    {
        public AddTungstenFabricNetworkGatewayToLogicalRouterRequest() : base("addTungstenFabricNetworkGatewayToLogicalRouter") {}

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
    /// add Tungsten-Fabric network gateway to logical router
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse AddTungstenFabricNetworkGatewayToLogicalRouter(AddTungstenFabricNetworkGatewayToLogicalRouterRequest request);
        Task<AsyncJobResponse> AddTungstenFabricNetworkGatewayToLogicalRouterAsync(AddTungstenFabricNetworkGatewayToLogicalRouterRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse AddTungstenFabricNetworkGatewayToLogicalRouter(AddTungstenFabricNetworkGatewayToLogicalRouterRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> AddTungstenFabricNetworkGatewayToLogicalRouterAsync(AddTungstenFabricNetworkGatewayToLogicalRouterRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
