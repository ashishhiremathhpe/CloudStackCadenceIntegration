using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateTungstenFabricFirewallRuleRequest : APIRequest
    {
        public CreateTungstenFabricFirewallRuleRequest() : base("createTungstenFabricFirewallRule") {}

        /// <summary>
        /// Tungsten-Fabric firewall rule action
        /// </summary>
        public string Action {
            get { return GetParameterValue<string>(nameof(Action).ToLower()); }
            set { SetParameterValue(nameof(Action).ToLower(), value); }
        }

        /// <summary>
        /// Tungsten-Fabric firewall rule direction
        /// </summary>
        public string Direction {
            get { return GetParameterValue<string>(nameof(Direction).ToLower()); }
            set { SetParameterValue(nameof(Direction).ToLower(), value); }
        }

        /// <summary>
        /// the uuid of Tungsten-Fabric firewall policy
        /// </summary>
        public string FirewallPolicyUuid {
            get { return GetParameterValue<string>(nameof(FirewallPolicyUuid).ToLower()); }
            set { SetParameterValue(nameof(FirewallPolicyUuid).ToLower(), value); }
        }

        /// <summary>
        /// Tungsten-Fabric firewall rule name
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// the sequence of Tungsten-Fabric firewall rule
        /// </summary>
        public int? Sequence {
            get { return GetParameterValue<int?>(nameof(Sequence).ToLower()); }
            set { SetParameterValue(nameof(Sequence).ToLower(), value); }
        }

        /// <summary>
        /// Tungsten-Fabric firewall rule service group uuid
        /// </summary>
        public string ServiceGroupUuid {
            get { return GetParameterValue<string>(nameof(ServiceGroupUuid).ToLower()); }
            set { SetParameterValue(nameof(ServiceGroupUuid).ToLower(), value); }
        }

        /// <summary>
        /// the ID of zone
        /// </summary>
        public Guid ZoneId {
            get { return GetParameterValue<Guid>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

        /// <summary>
        /// Tungsten-Fabric firewall rule destination address group uuid
        /// </summary>
        public string DestAddressGroupUuid {
            get { return GetParameterValue<string>(nameof(DestAddressGroupUuid).ToLower()); }
            set { SetParameterValue(nameof(DestAddressGroupUuid).ToLower(), value); }
        }

        /// <summary>
        /// the uuid of Tungsten-Fabric destination network
        /// </summary>
        public string DestNetworkUuid {
            get { return GetParameterValue<string>(nameof(DestNetworkUuid).ToLower()); }
            set { SetParameterValue(nameof(DestNetworkUuid).ToLower(), value); }
        }

        /// <summary>
        /// Tungsten-Fabric firewall rule destination tag uuid
        /// </summary>
        public string DestTagUuid {
            get { return GetParameterValue<string>(nameof(DestTagUuid).ToLower()); }
            set { SetParameterValue(nameof(DestTagUuid).ToLower(), value); }
        }

        /// <summary>
        /// Tungsten-Fabric firewall rule source address group uuid
        /// </summary>
        public string SrcAddressGroupUuid {
            get { return GetParameterValue<string>(nameof(SrcAddressGroupUuid).ToLower()); }
            set { SetParameterValue(nameof(SrcAddressGroupUuid).ToLower(), value); }
        }

        /// <summary>
        /// the uuid of Tungsten-Fabric source network
        /// </summary>
        public string SrcNetworkUuid {
            get { return GetParameterValue<string>(nameof(SrcNetworkUuid).ToLower()); }
            set { SetParameterValue(nameof(SrcNetworkUuid).ToLower(), value); }
        }

        /// <summary>
        /// Tungsten-Fabric firewall rule source tag uuid
        /// </summary>
        public string SrcTagUuid {
            get { return GetParameterValue<string>(nameof(SrcTagUuid).ToLower()); }
            set { SetParameterValue(nameof(SrcTagUuid).ToLower(), value); }
        }

        /// <summary>
        /// Tungsten-Fabric firewall rule tag type uuid
        /// </summary>
        public string TagTypeUuid {
            get { return GetParameterValue<string>(nameof(TagTypeUuid).ToLower()); }
            set { SetParameterValue(nameof(TagTypeUuid).ToLower(), value); }
        }

    }
    /// <summary>
    /// create Tungsten-Fabric firewall
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse CreateTungstenFabricFirewallRule(CreateTungstenFabricFirewallRuleRequest request);
        Task<AsyncJobResponse> CreateTungstenFabricFirewallRuleAsync(CreateTungstenFabricFirewallRuleRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse CreateTungstenFabricFirewallRule(CreateTungstenFabricFirewallRuleRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> CreateTungstenFabricFirewallRuleAsync(CreateTungstenFabricFirewallRuleRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
