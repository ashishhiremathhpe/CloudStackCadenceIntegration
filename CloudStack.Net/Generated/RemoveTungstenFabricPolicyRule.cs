using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class RemoveTungstenFabricPolicyRuleRequest : APIRequest
    {
        public RemoveTungstenFabricPolicyRuleRequest() : base("removeTungstenFabricPolicyRule") {}

        /// <summary>
        /// the Uuid of Tungsten-Fabric policy
        /// </summary>
        public string PolicyUuid {
            get { return GetParameterValue<string>(nameof(PolicyUuid).ToLower()); }
            set { SetParameterValue(nameof(PolicyUuid).ToLower(), value); }
        }

        /// <summary>
        /// the Uuid of Tungsten-Fabric policy rule
        /// </summary>
        public string RuleUuid {
            get { return GetParameterValue<string>(nameof(RuleUuid).ToLower()); }
            set { SetParameterValue(nameof(RuleUuid).ToLower(), value); }
        }

        /// <summary>
        /// the ID of zone
        /// </summary>
        public Guid ZoneId {
            get { return GetParameterValue<Guid>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

    }
    /// <summary>
    /// remove Tungsten-Fabric policy
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse RemoveTungstenFabricPolicyRule(RemoveTungstenFabricPolicyRuleRequest request);
        Task<AsyncJobResponse> RemoveTungstenFabricPolicyRuleAsync(RemoveTungstenFabricPolicyRuleRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse RemoveTungstenFabricPolicyRule(RemoveTungstenFabricPolicyRuleRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> RemoveTungstenFabricPolicyRuleAsync(RemoveTungstenFabricPolicyRuleRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
