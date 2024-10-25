using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListTungstenFabricFirewallPolicyRequest : APIListRequest
    {
        public ListTungstenFabricFirewallPolicyRequest() : base("listTungstenFabricFirewallPolicy") {}

        /// <summary>
        /// the uuid of Tungsten-Fabric application policy set
        /// </summary>
        public string ApplicationPolicySetUuid {
            get { return GetParameterValue<string>(nameof(ApplicationPolicySetUuid).ToLower()); }
            set { SetParameterValue(nameof(ApplicationPolicySetUuid).ToLower(), value); }
        }

        /// <summary>
        /// the uuid of Tungsten-Fabric firewall policy
        /// </summary>
        public string FirewallPolicyUuid {
            get { return GetParameterValue<string>(nameof(FirewallPolicyUuid).ToLower()); }
            set { SetParameterValue(nameof(FirewallPolicyUuid).ToLower(), value); }
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
    /// list Tungsten-Fabric firewall policy
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<TungstenFabricFirewallPolicyResponse> ListTungstenFabricFirewallPolicy(ListTungstenFabricFirewallPolicyRequest request);
        Task<ListResponse<TungstenFabricFirewallPolicyResponse>> ListTungstenFabricFirewallPolicyAsync(ListTungstenFabricFirewallPolicyRequest request);
        ListResponse<TungstenFabricFirewallPolicyResponse> ListTungstenFabricFirewallPolicyAllPages(ListTungstenFabricFirewallPolicyRequest request);
        Task<ListResponse<TungstenFabricFirewallPolicyResponse>> ListTungstenFabricFirewallPolicyAllPagesAsync(ListTungstenFabricFirewallPolicyRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<TungstenFabricFirewallPolicyResponse> ListTungstenFabricFirewallPolicy(ListTungstenFabricFirewallPolicyRequest request) => Proxy.Request<ListResponse<TungstenFabricFirewallPolicyResponse>>(request);
        public Task<ListResponse<TungstenFabricFirewallPolicyResponse>> ListTungstenFabricFirewallPolicyAsync(ListTungstenFabricFirewallPolicyRequest request) => Proxy.RequestAsync<ListResponse<TungstenFabricFirewallPolicyResponse>>(request);
        public ListResponse<TungstenFabricFirewallPolicyResponse> ListTungstenFabricFirewallPolicyAllPages(ListTungstenFabricFirewallPolicyRequest request) => Proxy.RequestAllPages<TungstenFabricFirewallPolicyResponse>(request);
        public Task<ListResponse<TungstenFabricFirewallPolicyResponse>> ListTungstenFabricFirewallPolicyAllPagesAsync(ListTungstenFabricFirewallPolicyRequest request) => Proxy.RequestAllPagesAsync<TungstenFabricFirewallPolicyResponse>(request);
    }
}
