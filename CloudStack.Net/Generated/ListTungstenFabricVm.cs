using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListTungstenFabricVmRequest : APIListRequest
    {
        public ListTungstenFabricVmRequest() : base("listTungstenFabricVm") {}

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// the uuid of Tungsten-Fabric vm
        /// </summary>
        public string VmUuid {
            get { return GetParameterValue<string>(nameof(VmUuid).ToLower()); }
            set { SetParameterValue(nameof(VmUuid).ToLower(), value); }
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
    /// list Tungsten-Fabric vm
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<TungstenFabricVmResponse> ListTungstenFabricVm(ListTungstenFabricVmRequest request);
        Task<ListResponse<TungstenFabricVmResponse>> ListTungstenFabricVmAsync(ListTungstenFabricVmRequest request);
        ListResponse<TungstenFabricVmResponse> ListTungstenFabricVmAllPages(ListTungstenFabricVmRequest request);
        Task<ListResponse<TungstenFabricVmResponse>> ListTungstenFabricVmAllPagesAsync(ListTungstenFabricVmRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<TungstenFabricVmResponse> ListTungstenFabricVm(ListTungstenFabricVmRequest request) => Proxy.Request<ListResponse<TungstenFabricVmResponse>>(request);
        public Task<ListResponse<TungstenFabricVmResponse>> ListTungstenFabricVmAsync(ListTungstenFabricVmRequest request) => Proxy.RequestAsync<ListResponse<TungstenFabricVmResponse>>(request);
        public ListResponse<TungstenFabricVmResponse> ListTungstenFabricVmAllPages(ListTungstenFabricVmRequest request) => Proxy.RequestAllPages<TungstenFabricVmResponse>(request);
        public Task<ListResponse<TungstenFabricVmResponse>> ListTungstenFabricVmAllPagesAsync(ListTungstenFabricVmRequest request) => Proxy.RequestAllPagesAsync<TungstenFabricVmResponse>(request);
    }
}
