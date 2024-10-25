using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListTungstenFabricPolicyRequest : APIListRequest
    {
        public ListTungstenFabricPolicyRequest() : base("listTungstenFabricPolicy") {}

        /// <summary>
        /// the ID of ip address
        /// </summary>
        public Guid? Ipaddressid {
            get { return GetParameterValue<Guid?>(nameof(Ipaddressid).ToLower()); }
            set { SetParameterValue(nameof(Ipaddressid).ToLower(), value); }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// the ID of network
        /// </summary>
        public Guid? NetworkId {
            get { return GetParameterValue<Guid?>(nameof(NetworkId).ToLower()); }
            set { SetParameterValue(nameof(NetworkId).ToLower(), value); }
        }

        /// <summary>
        /// the uuid of Tungsten-Fabric policy
        /// </summary>
        public string PolicyUuid {
            get { return GetParameterValue<string>(nameof(PolicyUuid).ToLower()); }
            set { SetParameterValue(nameof(PolicyUuid).ToLower(), value); }
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
    /// list Tungsten-Fabric policy
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<TungstenFabricPolicyResponse> ListTungstenFabricPolicy(ListTungstenFabricPolicyRequest request);
        Task<ListResponse<TungstenFabricPolicyResponse>> ListTungstenFabricPolicyAsync(ListTungstenFabricPolicyRequest request);
        ListResponse<TungstenFabricPolicyResponse> ListTungstenFabricPolicyAllPages(ListTungstenFabricPolicyRequest request);
        Task<ListResponse<TungstenFabricPolicyResponse>> ListTungstenFabricPolicyAllPagesAsync(ListTungstenFabricPolicyRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<TungstenFabricPolicyResponse> ListTungstenFabricPolicy(ListTungstenFabricPolicyRequest request) => Proxy.Request<ListResponse<TungstenFabricPolicyResponse>>(request);
        public Task<ListResponse<TungstenFabricPolicyResponse>> ListTungstenFabricPolicyAsync(ListTungstenFabricPolicyRequest request) => Proxy.RequestAsync<ListResponse<TungstenFabricPolicyResponse>>(request);
        public ListResponse<TungstenFabricPolicyResponse> ListTungstenFabricPolicyAllPages(ListTungstenFabricPolicyRequest request) => Proxy.RequestAllPages<TungstenFabricPolicyResponse>(request);
        public Task<ListResponse<TungstenFabricPolicyResponse>> ListTungstenFabricPolicyAllPagesAsync(ListTungstenFabricPolicyRequest request) => Proxy.RequestAllPagesAsync<TungstenFabricPolicyResponse>(request);
    }
}
