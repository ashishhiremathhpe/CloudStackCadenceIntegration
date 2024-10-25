using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListTungstenFabricTagTypeRequest : APIListRequest
    {
        public ListTungstenFabricTagTypeRequest() : base("listTungstenFabricTagType") {}

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// the uuid of Tungsten-Fabric tag type
        /// </summary>
        public string TagTypeUuid {
            get { return GetParameterValue<string>(nameof(TagTypeUuid).ToLower()); }
            set { SetParameterValue(nameof(TagTypeUuid).ToLower(), value); }
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
    /// Lists Tungsten-Fabric tags
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<TungstenFabricTagTypeResponse> ListTungstenFabricTagType(ListTungstenFabricTagTypeRequest request);
        Task<ListResponse<TungstenFabricTagTypeResponse>> ListTungstenFabricTagTypeAsync(ListTungstenFabricTagTypeRequest request);
        ListResponse<TungstenFabricTagTypeResponse> ListTungstenFabricTagTypeAllPages(ListTungstenFabricTagTypeRequest request);
        Task<ListResponse<TungstenFabricTagTypeResponse>> ListTungstenFabricTagTypeAllPagesAsync(ListTungstenFabricTagTypeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<TungstenFabricTagTypeResponse> ListTungstenFabricTagType(ListTungstenFabricTagTypeRequest request) => Proxy.Request<ListResponse<TungstenFabricTagTypeResponse>>(request);
        public Task<ListResponse<TungstenFabricTagTypeResponse>> ListTungstenFabricTagTypeAsync(ListTungstenFabricTagTypeRequest request) => Proxy.RequestAsync<ListResponse<TungstenFabricTagTypeResponse>>(request);
        public ListResponse<TungstenFabricTagTypeResponse> ListTungstenFabricTagTypeAllPages(ListTungstenFabricTagTypeRequest request) => Proxy.RequestAllPages<TungstenFabricTagTypeResponse>(request);
        public Task<ListResponse<TungstenFabricTagTypeResponse>> ListTungstenFabricTagTypeAllPagesAsync(ListTungstenFabricTagTypeRequest request) => Proxy.RequestAllPagesAsync<TungstenFabricTagTypeResponse>(request);
    }
}
