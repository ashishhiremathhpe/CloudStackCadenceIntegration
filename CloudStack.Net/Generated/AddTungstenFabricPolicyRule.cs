using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AddTungstenFabricPolicyRuleRequest : APIRequest
    {
        public AddTungstenFabricPolicyRuleRequest() : base("addTungstenFabricPolicyRule") {}

        /// <summary>
        /// Tungsten-Fabric policy rule action
        /// </summary>
        public string Action {
            get { return GetParameterValue<string>(nameof(Action).ToLower()); }
            set { SetParameterValue(nameof(Action).ToLower(), value); }
        }

        /// <summary>
        /// Tungsten-Fabric policy rule destination end port
        /// </summary>
        public int? DestEndPort {
            get { return GetParameterValue<int?>(nameof(DestEndPort).ToLower()); }
            set { SetParameterValue(nameof(DestEndPort).ToLower(), value); }
        }

        /// <summary>
        /// Tungsten-Fabric policy rule destination ip prefix
        /// </summary>
        public string DestIpPrefix {
            get { return GetParameterValue<string>(nameof(DestIpPrefix).ToLower()); }
            set { SetParameterValue(nameof(DestIpPrefix).ToLower(), value); }
        }

        /// <summary>
        /// Tungsten-Fabric policy rule destination ip prefix length
        /// </summary>
        public int? DestIpPrefixLen {
            get { return GetParameterValue<int?>(nameof(DestIpPrefixLen).ToLower()); }
            set { SetParameterValue(nameof(DestIpPrefixLen).ToLower(), value); }
        }

        /// <summary>
        /// Tungsten-Fabric policy rule destination network
        /// </summary>
        public string DestNetwork {
            get { return GetParameterValue<string>(nameof(DestNetwork).ToLower()); }
            set { SetParameterValue(nameof(DestNetwork).ToLower(), value); }
        }

        /// <summary>
        /// Tungsten-Fabric policy rule destination start port
        /// </summary>
        public int? DestStartPort {
            get { return GetParameterValue<int?>(nameof(DestStartPort).ToLower()); }
            set { SetParameterValue(nameof(DestStartPort).ToLower(), value); }
        }

        /// <summary>
        /// Tungsten-Fabric policy rule direction
        /// </summary>
        public string Direction {
            get { return GetParameterValue<string>(nameof(Direction).ToLower()); }
            set { SetParameterValue(nameof(Direction).ToLower(), value); }
        }

        /// <summary>
        /// the uuid of Tungsten-Fabric policy
        /// </summary>
        public string PolicyUuid {
            get { return GetParameterValue<string>(nameof(PolicyUuid).ToLower()); }
            set { SetParameterValue(nameof(PolicyUuid).ToLower(), value); }
        }

        /// <summary>
        /// Tungsten-Fabric policy rule protocol
        /// </summary>
        public string Protocol {
            get { return GetParameterValue<string>(nameof(Protocol).ToLower()); }
            set { SetParameterValue(nameof(Protocol).ToLower(), value); }
        }

        /// <summary>
        /// Tungsten-Fabric policy rule source end port
        /// </summary>
        public int? SrcEndPort {
            get { return GetParameterValue<int?>(nameof(SrcEndPort).ToLower()); }
            set { SetParameterValue(nameof(SrcEndPort).ToLower(), value); }
        }

        /// <summary>
        /// Tungsten-Fabric policy rule source ip prefix
        /// </summary>
        public string SrcIpPrefix {
            get { return GetParameterValue<string>(nameof(SrcIpPrefix).ToLower()); }
            set { SetParameterValue(nameof(SrcIpPrefix).ToLower(), value); }
        }

        /// <summary>
        /// Tungsten-Fabric policy rule source ip prefix length
        /// </summary>
        public int? SrcIpPrefixLen {
            get { return GetParameterValue<int?>(nameof(SrcIpPrefixLen).ToLower()); }
            set { SetParameterValue(nameof(SrcIpPrefixLen).ToLower(), value); }
        }

        /// <summary>
        /// Tungsten-Fabric policy rule source network
        /// </summary>
        public string SrcNetwork {
            get { return GetParameterValue<string>(nameof(SrcNetwork).ToLower()); }
            set { SetParameterValue(nameof(SrcNetwork).ToLower(), value); }
        }

        /// <summary>
        /// Tungsten-Fabric policy rule source start port
        /// </summary>
        public int? SrcStartPort {
            get { return GetParameterValue<int?>(nameof(SrcStartPort).ToLower()); }
            set { SetParameterValue(nameof(SrcStartPort).ToLower(), value); }
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
    /// add Tungsten-Fabric policy rule
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse AddTungstenFabricPolicyRule(AddTungstenFabricPolicyRuleRequest request);
        Task<AsyncJobResponse> AddTungstenFabricPolicyRuleAsync(AddTungstenFabricPolicyRuleRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse AddTungstenFabricPolicyRule(AddTungstenFabricPolicyRuleRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> AddTungstenFabricPolicyRuleAsync(AddTungstenFabricPolicyRuleRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
