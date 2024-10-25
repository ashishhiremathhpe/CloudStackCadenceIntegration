using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListTungstenFabricServiceGroupRequest : APIListRequest
    {
        public ListTungstenFabricServiceGroupRequest() : base("listTungstenFabricServiceGroup") {}

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// the uuid of Tungsten-Fabric service group
        /// </summary>
        public string ServiceGroupUuid {
            get { return GetParameterValue<string>(nameof(ServiceGroupUuid).ToLower()); }
            set { SetParameterValue(nameof(ServiceGroupUuid).ToLower(), value); }
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
    /// list Tungsten-Fabric service group
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<TungstenFabricServiceGroupResponse> ListTungstenFabricServiceGroup(ListTungstenFabricServiceGroupRequest request);
        Task<ListResponse<TungstenFabricServiceGroupResponse>> ListTungstenFabricServiceGroupAsync(ListTungstenFabricServiceGroupRequest request);
        ListResponse<TungstenFabricServiceGroupResponse> ListTungstenFabricServiceGroupAllPages(ListTungstenFabricServiceGroupRequest request);
        Task<ListResponse<TungstenFabricServiceGroupResponse>> ListTungstenFabricServiceGroupAllPagesAsync(ListTungstenFabricServiceGroupRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<TungstenFabricServiceGroupResponse> ListTungstenFabricServiceGroup(ListTungstenFabricServiceGroupRequest request) => Proxy.Request<ListResponse<TungstenFabricServiceGroupResponse>>(request);
        public Task<ListResponse<TungstenFabricServiceGroupResponse>> ListTungstenFabricServiceGroupAsync(ListTungstenFabricServiceGroupRequest request) => Proxy.RequestAsync<ListResponse<TungstenFabricServiceGroupResponse>>(request);
        public ListResponse<TungstenFabricServiceGroupResponse> ListTungstenFabricServiceGroupAllPages(ListTungstenFabricServiceGroupRequest request) => Proxy.RequestAllPages<TungstenFabricServiceGroupResponse>(request);
        public Task<ListResponse<TungstenFabricServiceGroupResponse>> ListTungstenFabricServiceGroupAllPagesAsync(ListTungstenFabricServiceGroupRequest request) => Proxy.RequestAllPagesAsync<TungstenFabricServiceGroupResponse>(request);
    }
}
