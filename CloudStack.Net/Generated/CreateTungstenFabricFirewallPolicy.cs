using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateTungstenFabricFirewallPolicyRequest : APIRequest
    {
        public CreateTungstenFabricFirewallPolicyRequest() : base("createTungstenFabricFirewallPolicy") {}

        /// <summary>
        /// Tungsten-Fabric firewall policy name
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// the sequence of Tungsten-Fabric firewall policy
        /// </summary>
        public int? Sequence {
            get { return GetParameterValue<int?>(nameof(Sequence).ToLower()); }
            set { SetParameterValue(nameof(Sequence).ToLower(), value); }
        }

        /// <summary>
        /// the ID of zone
        /// </summary>
        public Guid ZoneId {
            get { return GetParameterValue<Guid>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

        /// <summary>
        /// the uuid of Tungsten-Fabric application policy set
        /// </summary>
        public string ApplicationPolicySetUuid {
            get { return GetParameterValue<string>(nameof(ApplicationPolicySetUuid).ToLower()); }
            set { SetParameterValue(nameof(ApplicationPolicySetUuid).ToLower(), value); }
        }

    }
    /// <summary>
    /// create Tungsten-Fabric firewall policy
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse CreateTungstenFabricFirewallPolicy(CreateTungstenFabricFirewallPolicyRequest request);
        Task<AsyncJobResponse> CreateTungstenFabricFirewallPolicyAsync(CreateTungstenFabricFirewallPolicyRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse CreateTungstenFabricFirewallPolicy(CreateTungstenFabricFirewallPolicyRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> CreateTungstenFabricFirewallPolicyAsync(CreateTungstenFabricFirewallPolicyRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
