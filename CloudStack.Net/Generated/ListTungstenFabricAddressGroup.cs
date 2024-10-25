using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListTungstenFabricAddressGroupRequest : APIListRequest
    {
        public ListTungstenFabricAddressGroupRequest() : base("listTungstenFabricAddressGroup") {}

        /// <summary>
        /// the uuid of Tungsten-Fabric address group
        /// </summary>
        public string AddressGroupUuid {
            get { return GetParameterValue<string>(nameof(AddressGroupUuid).ToLower()); }
            set { SetParameterValue(nameof(AddressGroupUuid).ToLower(), value); }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
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
    /// list Tungsten-Fabric address group
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<TungstenFabricAddressGroupResponse> ListTungstenFabricAddressGroup(ListTungstenFabricAddressGroupRequest request);
        Task<ListResponse<TungstenFabricAddressGroupResponse>> ListTungstenFabricAddressGroupAsync(ListTungstenFabricAddressGroupRequest request);
        ListResponse<TungstenFabricAddressGroupResponse> ListTungstenFabricAddressGroupAllPages(ListTungstenFabricAddressGroupRequest request);
        Task<ListResponse<TungstenFabricAddressGroupResponse>> ListTungstenFabricAddressGroupAllPagesAsync(ListTungstenFabricAddressGroupRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<TungstenFabricAddressGroupResponse> ListTungstenFabricAddressGroup(ListTungstenFabricAddressGroupRequest request) => Proxy.Request<ListResponse<TungstenFabricAddressGroupResponse>>(request);
        public Task<ListResponse<TungstenFabricAddressGroupResponse>> ListTungstenFabricAddressGroupAsync(ListTungstenFabricAddressGroupRequest request) => Proxy.RequestAsync<ListResponse<TungstenFabricAddressGroupResponse>>(request);
        public ListResponse<TungstenFabricAddressGroupResponse> ListTungstenFabricAddressGroupAllPages(ListTungstenFabricAddressGroupRequest request) => Proxy.RequestAllPages<TungstenFabricAddressGroupResponse>(request);
        public Task<ListResponse<TungstenFabricAddressGroupResponse>> ListTungstenFabricAddressGroupAllPagesAsync(ListTungstenFabricAddressGroupRequest request) => Proxy.RequestAllPagesAsync<TungstenFabricAddressGroupResponse>(request);
    }
}
