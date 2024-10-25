using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateIpv6FirewallRuleRequest : APIRequest
    {
        public UpdateIpv6FirewallRuleRequest() : base("updateIpv6FirewallRule") {}

        /// <summary>
        /// the ID of the ipv6 firewall rule
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// the cidr list to allow traffic from/to. Multiple entries must be separated by a single comma character (,).
        /// </summary>
        public IList<string> Cidrlist {
            get { return GetList<string>(nameof(Cidrlist).ToLower()); }
            set { SetParameterValue(nameof(Cidrlist).ToLower(), value); }
        }

        /// <summary>
        /// an optional field, in case you want to set a custom id to the resource. Allowed to Root Admins only
        /// </summary>
        public string CustomId {
            get { return GetParameterValue<string>(nameof(CustomId).ToLower()); }
            set { SetParameterValue(nameof(CustomId).ToLower(), value); }
        }

        /// <summary>
        /// the ending port of Ipv6 firewall rule
        /// </summary>
        public int? Endport {
            get { return GetParameterValue<int?>(nameof(Endport).ToLower()); }
            set { SetParameterValue(nameof(Endport).ToLower(), value); }
        }

        /// <summary>
        /// an optional field, whether to the display the Ipv6 firewall rule to the end user or not
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
        /// the protocol for the Ipv6 firewall rule. Valid values are TCP/UDP/ICMP/ALL or valid protocol number
        /// </summary>
        public string Protocol {
            get { return GetParameterValue<string>(nameof(Protocol).ToLower()); }
            set { SetParameterValue(nameof(Protocol).ToLower(), value); }
        }

        /// <summary>
        /// the starting port of Ipv6 firewall rule
        /// </summary>
        public int? Startport {
            get { return GetParameterValue<int?>(nameof(Startport).ToLower()); }
            set { SetParameterValue(nameof(Startport).ToLower(), value); }
        }

        /// <summary>
        /// the traffic type for the Ipv6 firewall rule, can be Ingress or Egress, defaulted to Ingress if not specified
        /// </summary>
        public string TrafficType {
            get { return GetParameterValue<string>(nameof(TrafficType).ToLower()); }
            set { SetParameterValue(nameof(TrafficType).ToLower(), value); }
        }

    }
    /// <summary>
    /// Updates Ipv6 firewall rule with specified ID
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse UpdateIpv6FirewallRule(UpdateIpv6FirewallRuleRequest request);
        Task<AsyncJobResponse> UpdateIpv6FirewallRuleAsync(UpdateIpv6FirewallRuleRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse UpdateIpv6FirewallRule(UpdateIpv6FirewallRuleRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> UpdateIpv6FirewallRuleAsync(UpdateIpv6FirewallRuleRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
