using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListTungstenFabricTagRequest : APIListRequest
    {
        public ListTungstenFabricTagRequest() : base("listTungstenFabricTag") {}

        /// <summary>
        /// the uuid of Tungsten-Fabric application policy set
        /// </summary>
        public string ApplicationPolicySetUuid {
            get { return GetParameterValue<string>(nameof(ApplicationPolicySetUuid).ToLower()); }
            set { SetParameterValue(nameof(ApplicationPolicySetUuid).ToLower(), value); }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// the uuid of Tungsten-Fabric network
        /// </summary>
        public string NetworkUuid {
            get { return GetParameterValue<string>(nameof(NetworkUuid).ToLower()); }
            set { SetParameterValue(nameof(NetworkUuid).ToLower(), value); }
        }

        /// <summary>
        /// the uuid of Tungsten-Fabric nic
        /// </summary>
        public string NicUuid {
            get { return GetParameterValue<string>(nameof(NicUuid).ToLower()); }
            set { SetParameterValue(nameof(NicUuid).ToLower(), value); }
        }

        /// <summary>
        /// the uuid of Tungsten-Fabric policy
        /// </summary>
        public string PolicyUuid {
            get { return GetParameterValue<string>(nameof(PolicyUuid).ToLower()); }
            set { SetParameterValue(nameof(PolicyUuid).ToLower(), value); }
        }

        /// <summary>
        /// the uuid of Tungsten-Fabric tag
        /// </summary>
        public string TagUuid {
            get { return GetParameterValue<string>(nameof(TagUuid).ToLower()); }
            set { SetParameterValue(nameof(TagUuid).ToLower(), value); }
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
    /// Lists Tungsten-Fabric tags
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<TungstenFabricTagResponse> ListTungstenFabricTag(ListTungstenFabricTagRequest request);
        Task<ListResponse<TungstenFabricTagResponse>> ListTungstenFabricTagAsync(ListTungstenFabricTagRequest request);
        ListResponse<TungstenFabricTagResponse> ListTungstenFabricTagAllPages(ListTungstenFabricTagRequest request);
        Task<ListResponse<TungstenFabricTagResponse>> ListTungstenFabricTagAllPagesAsync(ListTungstenFabricTagRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<TungstenFabricTagResponse> ListTungstenFabricTag(ListTungstenFabricTagRequest request) => Proxy.Request<ListResponse<TungstenFabricTagResponse>>(request);
        public Task<ListResponse<TungstenFabricTagResponse>> ListTungstenFabricTagAsync(ListTungstenFabricTagRequest request) => Proxy.RequestAsync<ListResponse<TungstenFabricTagResponse>>(request);
        public ListResponse<TungstenFabricTagResponse> ListTungstenFabricTagAllPages(ListTungstenFabricTagRequest request) => Proxy.RequestAllPages<TungstenFabricTagResponse>(request);
        public Task<ListResponse<TungstenFabricTagResponse>> ListTungstenFabricTagAllPagesAsync(ListTungstenFabricTagRequest request) => Proxy.RequestAllPagesAsync<TungstenFabricTagResponse>(request);
    }
}
