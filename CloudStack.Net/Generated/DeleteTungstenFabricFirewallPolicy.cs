using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteTungstenFabricFirewallPolicyRequest : APIRequest
    {
        public DeleteTungstenFabricFirewallPolicyRequest() : base("deleteTungstenFabricFirewallPolicy") {}

        /// <summary>
        /// the uuid of Tungsten-Fabric firewall policy
        /// </summary>
        public string FirewallPolicyUuid {
            get { return GetParameterValue<string>(nameof(FirewallPolicyUuid).ToLower()); }
            set { SetParameterValue(nameof(FirewallPolicyUuid).ToLower(), value); }
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
    /// delete Tungsten-Fabric firewall policy
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeleteTungstenFabricFirewallPolicy(DeleteTungstenFabricFirewallPolicyRequest request);
        Task<AsyncJobResponse> DeleteTungstenFabricFirewallPolicyAsync(DeleteTungstenFabricFirewallPolicyRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteTungstenFabricFirewallPolicy(DeleteTungstenFabricFirewallPolicyRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DeleteTungstenFabricFirewallPolicyAsync(DeleteTungstenFabricFirewallPolicyRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
