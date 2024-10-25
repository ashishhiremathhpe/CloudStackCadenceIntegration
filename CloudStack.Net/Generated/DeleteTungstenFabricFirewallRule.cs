using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteTungstenFabricFirewallRuleRequest : APIRequest
    {
        public DeleteTungstenFabricFirewallRuleRequest() : base("deleteTungstenFabricFirewallRule") {}

        /// <summary>
        /// the uuid of Tungsten-Fabric firewall rule
        /// </summary>
        public string FirewallRuleUuid {
            get { return GetParameterValue<string>(nameof(FirewallRuleUuid).ToLower()); }
            set { SetParameterValue(nameof(FirewallRuleUuid).ToLower(), value); }
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
    /// delete Tungsten-Fabric firewall rule
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeleteTungstenFabricFirewallRule(DeleteTungstenFabricFirewallRuleRequest request);
        Task<AsyncJobResponse> DeleteTungstenFabricFirewallRuleAsync(DeleteTungstenFabricFirewallRuleRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteTungstenFabricFirewallRule(DeleteTungstenFabricFirewallRuleRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DeleteTungstenFabricFirewallRuleAsync(DeleteTungstenFabricFirewallRuleRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
