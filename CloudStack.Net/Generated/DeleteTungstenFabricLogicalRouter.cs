using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteTungstenFabricLogicalRouterRequest : APIRequest
    {
        public DeleteTungstenFabricLogicalRouterRequest() : base("deleteTungstenFabricLogicalRouter") {}

        /// <summary>
        /// the uuid of Tungsten-Fabric logical router
        /// </summary>
        public string LogicalRouterUuid {
            get { return GetParameterValue<string>(nameof(LogicalRouterUuid).ToLower()); }
            set { SetParameterValue(nameof(LogicalRouterUuid).ToLower(), value); }
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
    /// delete Tungsten-Fabric logical router
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeleteTungstenFabricLogicalRouter(DeleteTungstenFabricLogicalRouterRequest request);
        Task<AsyncJobResponse> DeleteTungstenFabricLogicalRouterAsync(DeleteTungstenFabricLogicalRouterRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteTungstenFabricLogicalRouter(DeleteTungstenFabricLogicalRouterRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DeleteTungstenFabricLogicalRouterAsync(DeleteTungstenFabricLogicalRouterRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
