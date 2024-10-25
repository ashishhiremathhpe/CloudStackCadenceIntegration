using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListTungstenFabricPolicyRuleRequest : APIListRequest
    {
        public ListTungstenFabricPolicyRuleRequest() : base("listTungstenFabricPolicyRule") {}

        /// <summary>
        /// the uuid of Tungsten-Fabric policy
        /// </summary>
        public string PolicyUuid {
            get { return GetParameterValue<string>(nameof(PolicyUuid).ToLower()); }
            set { SetParameterValue(nameof(PolicyUuid).ToLower(), value); }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// the uuid of Tungsten-Fabric rule
        /// </summary>
        public string RuleUuid {
            get { return GetParameterValue<string>(nameof(RuleUuid).ToLower()); }
            set { SetParameterValue(nameof(RuleUuid).ToLower(), value); }
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
        ListResponse<TungstenFabricRuleResponse> ListTungstenFabricPolicyRule(ListTungstenFabricPolicyRuleRequest request);
        Task<ListResponse<TungstenFabricRuleResponse>> ListTungstenFabricPolicyRuleAsync(ListTungstenFabricPolicyRuleRequest request);
        ListResponse<TungstenFabricRuleResponse> ListTungstenFabricPolicyRuleAllPages(ListTungstenFabricPolicyRuleRequest request);
        Task<ListResponse<TungstenFabricRuleResponse>> ListTungstenFabricPolicyRuleAllPagesAsync(ListTungstenFabricPolicyRuleRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<TungstenFabricRuleResponse> ListTungstenFabricPolicyRule(ListTungstenFabricPolicyRuleRequest request) => Proxy.Request<ListResponse<TungstenFabricRuleResponse>>(request);
        public Task<ListResponse<TungstenFabricRuleResponse>> ListTungstenFabricPolicyRuleAsync(ListTungstenFabricPolicyRuleRequest request) => Proxy.RequestAsync<ListResponse<TungstenFabricRuleResponse>>(request);
        public ListResponse<TungstenFabricRuleResponse> ListTungstenFabricPolicyRuleAllPages(ListTungstenFabricPolicyRuleRequest request) => Proxy.RequestAllPages<TungstenFabricRuleResponse>(request);
        public Task<ListResponse<TungstenFabricRuleResponse>> ListTungstenFabricPolicyRuleAllPagesAsync(ListTungstenFabricPolicyRuleRequest request) => Proxy.RequestAllPagesAsync<TungstenFabricRuleResponse>(request);
    }
}
