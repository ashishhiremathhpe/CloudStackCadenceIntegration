using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListTungstenFabricFirewallRuleRequest : APIListRequest
    {
        public ListTungstenFabricFirewallRuleRequest() : base("listTungstenFabricFirewallRule") {}

        /// <summary>
        /// the uuid of Tungsten-Fabric firewall policy
        /// </summary>
        public string FirewallPolicyUuid {
            get { return GetParameterValue<string>(nameof(FirewallPolicyUuid).ToLower()); }
            set { SetParameterValue(nameof(FirewallPolicyUuid).ToLower(), value); }
        }

        /// <summary>
        /// the uuid of Tungsten-Fabric firewall rule
        /// </summary>
        public string FirewallRuleUuid {
            get { return GetParameterValue<string>(nameof(FirewallRuleUuid).ToLower()); }
            set { SetParameterValue(nameof(FirewallRuleUuid).ToLower(), value); }
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
    /// list Tungsten-Fabric firewall rule
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<TungstenFabricFirewallRuleResponse> ListTungstenFabricFirewallRule(ListTungstenFabricFirewallRuleRequest request);
        Task<ListResponse<TungstenFabricFirewallRuleResponse>> ListTungstenFabricFirewallRuleAsync(ListTungstenFabricFirewallRuleRequest request);
        ListResponse<TungstenFabricFirewallRuleResponse> ListTungstenFabricFirewallRuleAllPages(ListTungstenFabricFirewallRuleRequest request);
        Task<ListResponse<TungstenFabricFirewallRuleResponse>> ListTungstenFabricFirewallRuleAllPagesAsync(ListTungstenFabricFirewallRuleRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<TungstenFabricFirewallRuleResponse> ListTungstenFabricFirewallRule(ListTungstenFabricFirewallRuleRequest request) => Proxy.Request<ListResponse<TungstenFabricFirewallRuleResponse>>(request);
        public Task<ListResponse<TungstenFabricFirewallRuleResponse>> ListTungstenFabricFirewallRuleAsync(ListTungstenFabricFirewallRuleRequest request) => Proxy.RequestAsync<ListResponse<TungstenFabricFirewallRuleResponse>>(request);
        public ListResponse<TungstenFabricFirewallRuleResponse> ListTungstenFabricFirewallRuleAllPages(ListTungstenFabricFirewallRuleRequest request) => Proxy.RequestAllPages<TungstenFabricFirewallRuleResponse>(request);
        public Task<ListResponse<TungstenFabricFirewallRuleResponse>> ListTungstenFabricFirewallRuleAllPagesAsync(ListTungstenFabricFirewallRuleRequest request) => Proxy.RequestAllPagesAsync<TungstenFabricFirewallRuleResponse>(request);
    }
}
