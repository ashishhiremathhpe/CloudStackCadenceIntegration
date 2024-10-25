using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateIpv6FirewallRuleRequest : APIRequest
    {
        public CreateIpv6FirewallRuleRequest() : base("createIpv6FirewallRule") {}

        /// <summary>
        /// The network of the VM the Ipv6 firewall rule will be created for
        /// </summary>
        public Guid NetworkId {
            get { return GetParameterValue<Guid>(nameof(NetworkId).ToLower()); }
            set { SetParameterValue(nameof(NetworkId).ToLower(), value); }
        }

        /// <summary>
        /// the protocol for the Ipv6 firewall rule. Valid values are TCP/UDP/ICMP/ALL or valid protocol number
        /// </summary>
        public string Protocol {
            get { return GetParameterValue<string>(nameof(Protocol).ToLower()); }
            set { SetParameterValue(nameof(Protocol).ToLower(), value); }
        }

        /// <summary>
        /// the source CIDR list to allow traffic from. Multiple entries must be separated by a single comma character (,).
        /// </summary>
        public IList<string> Cidrlist {
            get { return GetList<string>(nameof(Cidrlist).ToLower()); }
            set { SetParameterValue(nameof(Cidrlist).ToLower(), value); }
        }

        /// <summary>
        /// the destination CIDR list to allow traffic to. Multiple entries must be separated by a single comma character (,).
        /// </summary>
        public IList<string> Destcidrlist {
            get { return GetList<string>(nameof(Destcidrlist).ToLower()); }
            set { SetParameterValue(nameof(Destcidrlist).ToLower(), value); }
        }

        /// <summary>
        /// the ending port of Ipv6 firewall rule
        /// </summary>
        public int? Endport {
            get { return GetParameterValue<int?>(nameof(Endport).ToLower()); }
            set { SetParameterValue(nameof(Endport).ToLower(), value); }
        }

        /// <summary>
        /// an optional field, whether to the display the rule to the end user or not
        /// </summary>
        public bool? Fordisplay {
            get { return GetParameterValue<bool?>(nameof(Fordisplay).ToLower()); }
            set { SetParameterValue(nameof(Fordisplay).ToLower(), value); }
        }

        /// <summary>
        /// error code for this ICMP message
        /// </summary>
        public int? IcmpCode {
            get { return GetParameterValue<int?>(nameof(IcmpCode).ToLower()); }
            set { SetParameterValue(nameof(IcmpCode).ToLower(), value); }
        }

        /// <summary>
        /// type of the ICMP message being sent
        /// </summary>
        public int? IcmpType {
            get { return GetParameterValue<int?>(nameof(IcmpType).ToLower()); }
            set { SetParameterValue(nameof(IcmpType).ToLower(), value); }
        }

        /// <summary>
        /// the starting port of Ipv6 firewall rule
        /// </summary>
        public int? Startport {
            get { return GetParameterValue<int?>(nameof(Startport).ToLower()); }
            set { SetParameterValue(nameof(Startport).ToLower(), value); }
        }

        /// <summary>
        /// the traffic type for the Ipv6 firewall rule, can be ingress or egress, defaulted to ingress if not specified
        /// </summary>
        public string TrafficType {
            get { return GetParameterValue<string>(nameof(TrafficType).ToLower()); }
            set { SetParameterValue(nameof(TrafficType).ToLower(), value); }
        }

    }
    /// <summary>
    /// Creates an Ipv6 firewall rule in the given network (the network has to belong to VPC)
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse CreateIpv6FirewallRule(CreateIpv6FirewallRuleRequest request);
        Task<AsyncJobResponse> CreateIpv6FirewallRuleAsync(CreateIpv6FirewallRuleRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse CreateIpv6FirewallRule(CreateIpv6FirewallRuleRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> CreateIpv6FirewallRuleAsync(CreateIpv6FirewallRuleRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
