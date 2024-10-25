using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListTungstenFabricNicRequest : APIListRequest
    {
        public ListTungstenFabricNicRequest() : base("listTungstenFabricNic") {}

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// the uuid of Tungsten-Fabric nic
        /// </summary>
        public string NicUuid {
            get { return GetParameterValue<string>(nameof(NicUuid).ToLower()); }
            set { SetParameterValue(nameof(NicUuid).ToLower(), value); }
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
    /// list Tungsten-Fabric nic
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<TungstenFabricNicResponse> ListTungstenFabricNic(ListTungstenFabricNicRequest request);
        Task<ListResponse<TungstenFabricNicResponse>> ListTungstenFabricNicAsync(ListTungstenFabricNicRequest request);
        ListResponse<TungstenFabricNicResponse> ListTungstenFabricNicAllPages(ListTungstenFabricNicRequest request);
        Task<ListResponse<TungstenFabricNicResponse>> ListTungstenFabricNicAllPagesAsync(ListTungstenFabricNicRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<TungstenFabricNicResponse> ListTungstenFabricNic(ListTungstenFabricNicRequest request) => Proxy.Request<ListResponse<TungstenFabricNicResponse>>(request);
        public Task<ListResponse<TungstenFabricNicResponse>> ListTungstenFabricNicAsync(ListTungstenFabricNicRequest request) => Proxy.RequestAsync<ListResponse<TungstenFabricNicResponse>>(request);
        public ListResponse<TungstenFabricNicResponse> ListTungstenFabricNicAllPages(ListTungstenFabricNicRequest request) => Proxy.RequestAllPages<TungstenFabricNicResponse>(request);
        public Task<ListResponse<TungstenFabricNicResponse>> ListTungstenFabricNicAllPagesAsync(ListTungstenFabricNicRequest request) => Proxy.RequestAllPagesAsync<TungstenFabricNicResponse>(request);
    }
}
