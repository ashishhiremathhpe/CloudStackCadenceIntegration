using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteIpv6FirewallRuleRequest : APIRequest
    {
        public DeleteIpv6FirewallRuleRequest() : base("deleteIpv6FirewallRule") {}

        /// <summary>
        /// the ID of the IPv6 firewall rule
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Deletes a IPv6 firewall rule
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeleteIpv6FirewallRule(DeleteIpv6FirewallRuleRequest request);
        Task<AsyncJobResponse> DeleteIpv6FirewallRuleAsync(DeleteIpv6FirewallRuleRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteIpv6FirewallRule(DeleteIpv6FirewallRuleRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DeleteIpv6FirewallRuleAsync(DeleteIpv6FirewallRuleRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
