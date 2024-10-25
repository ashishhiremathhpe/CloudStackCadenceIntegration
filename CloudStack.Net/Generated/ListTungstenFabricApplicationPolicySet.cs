using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListTungstenFabricApplicationPolicySetRequest : APIListRequest
    {
        public ListTungstenFabricApplicationPolicySetRequest() : base("listTungstenFabricApplicationPolicySet") {}

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
        /// the ID of zone
        /// </summary>
        public Guid? ZoneId {
            get { return GetParameterValue<Guid?>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

    }
    /// <summary>
    /// list Tungsten-Fabric application policy set
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<TungstenFabricApplicationPolicySetResponse> ListTungstenFabricApplicationPolicySet(ListTungstenFabricApplicationPolicySetRequest request);
        Task<ListResponse<TungstenFabricApplicationPolicySetResponse>> ListTungstenFabricApplicationPolicySetAsync(ListTungstenFabricApplicationPolicySetRequest request);
        ListResponse<TungstenFabricApplicationPolicySetResponse> ListTungstenFabricApplicationPolicySetAllPages(ListTungstenFabricApplicationPolicySetRequest request);
        Task<ListResponse<TungstenFabricApplicationPolicySetResponse>> ListTungstenFabricApplicationPolicySetAllPagesAsync(ListTungstenFabricApplicationPolicySetRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<TungstenFabricApplicationPolicySetResponse> ListTungstenFabricApplicationPolicySet(ListTungstenFabricApplicationPolicySetRequest request) => Proxy.Request<ListResponse<TungstenFabricApplicationPolicySetResponse>>(request);
        public Task<ListResponse<TungstenFabricApplicationPolicySetResponse>> ListTungstenFabricApplicationPolicySetAsync(ListTungstenFabricApplicationPolicySetRequest request) => Proxy.RequestAsync<ListResponse<TungstenFabricApplicationPolicySetResponse>>(request);
        public ListResponse<TungstenFabricApplicationPolicySetResponse> ListTungstenFabricApplicationPolicySetAllPages(ListTungstenFabricApplicationPolicySetRequest request) => Proxy.RequestAllPages<TungstenFabricApplicationPolicySetResponse>(request);
        public Task<ListResponse<TungstenFabricApplicationPolicySetResponse>> ListTungstenFabricApplicationPolicySetAllPagesAsync(ListTungstenFabricApplicationPolicySetRequest request) => Proxy.RequestAllPagesAsync<TungstenFabricApplicationPolicySetResponse>(request);
    }
}
