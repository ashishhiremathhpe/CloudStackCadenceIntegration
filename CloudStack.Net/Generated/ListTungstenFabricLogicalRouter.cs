using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListTungstenFabricLogicalRouterRequest : APIListRequest
    {
        public ListTungstenFabricLogicalRouterRequest() : base("listTungstenFabricLogicalRouter") {}

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// the uuid of Tungsten-Fabric logical router
        /// </summary>
        public string LogicalRouterUuid {
            get { return GetParameterValue<string>(nameof(LogicalRouterUuid).ToLower()); }
            set { SetParameterValue(nameof(LogicalRouterUuid).ToLower(), value); }
        }

        /// <summary>
        /// the uuid of Tungsten-Fabric network
        /// </summary>
        public string NetworkUuid {
            get { return GetParameterValue<string>(nameof(NetworkUuid).ToLower()); }
            set { SetParameterValue(nameof(NetworkUuid).ToLower(), value); }
        }

        /// <summary>
        /// the ID of zone
        /// </summary>
        public Guid? ZoneId {
            get { return GetParameterValue<Guid?>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

    }
    /// <summary>
    /// list Tungsten-Fabric logical router
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<TungstenFabricLogicalRouterResponse> ListTungstenFabricLogicalRouter(ListTungstenFabricLogicalRouterRequest request);
        Task<ListResponse<TungstenFabricLogicalRouterResponse>> ListTungstenFabricLogicalRouterAsync(ListTungstenFabricLogicalRouterRequest request);
        ListResponse<TungstenFabricLogicalRouterResponse> ListTungstenFabricLogicalRouterAllPages(ListTungstenFabricLogicalRouterRequest request);
        Task<ListResponse<TungstenFabricLogicalRouterResponse>> ListTungstenFabricLogicalRouterAllPagesAsync(ListTungstenFabricLogicalRouterRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<TungstenFabricLogicalRouterResponse> ListTungstenFabricLogicalRouter(ListTungstenFabricLogicalRouterRequest request) => Proxy.Request<ListResponse<TungstenFabricLogicalRouterResponse>>(request);
        public Task<ListResponse<TungstenFabricLogicalRouterResponse>> ListTungstenFabricLogicalRouterAsync(ListTungstenFabricLogicalRouterRequest request) => Proxy.RequestAsync<ListResponse<TungstenFabricLogicalRouterResponse>>(request);
        public ListResponse<TungstenFabricLogicalRouterResponse> ListTungstenFabricLogicalRouterAllPages(ListTungstenFabricLogicalRouterRequest request) => Proxy.RequestAllPages<TungstenFabricLogicalRouterResponse>(request);
        public Task<ListResponse<TungstenFabricLogicalRouterResponse>> ListTungstenFabricLogicalRouterAllPagesAsync(ListTungstenFabricLogicalRouterRequest request) => Proxy.RequestAllPagesAsync<TungstenFabricLogicalRouterResponse>(request);
    }
}
