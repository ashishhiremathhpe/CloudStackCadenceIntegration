using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListIpv6FirewallRulesRequest : APIListRequest
    {
        public ListIpv6FirewallRulesRequest() : base("listIpv6FirewallRules") {}

        /// <summary>
        /// list resources by account. Must be used with the domainId parameter.
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// list only resources belonging to the domain specified
        /// </summary>
        public Guid? DomainId {
            get { return GetParameterValue<Guid?>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// list resources by display flag; only ROOT admin is eligible to pass this parameter
        /// </summary>
        public bool? Fordisplay {
            get { return GetParameterValue<bool?>(nameof(Fordisplay).ToLower()); }
            set { SetParameterValue(nameof(Fordisplay).ToLower(), value); }
        }

        /// <summary>
        /// Lists ipv6 firewall rule with the specified ID
        /// </summary>
        public Guid? Id {
            get { return GetParameterValue<Guid?>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// defaults to false, but if true, lists all resources from the parent specified by the domainId till leaves.
        /// </summary>
        public bool? Isrecursive {
            get { return GetParameterValue<bool?>(nameof(Isrecursive).ToLower()); }
            set { SetParameterValue(nameof(Isrecursive).ToLower(), value); }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// If set to false, list only resources belonging to the command's caller; if set to true - list resources that the caller is authorized to see. Default value is false. Resources dedicated to a project are listed only if using the projectid parameter.
        /// </summary>
        public bool? ListAll {
            get { return GetParameterValue<bool?>(nameof(ListAll).ToLower()); }
            set { SetParameterValue(nameof(ListAll).ToLower(), value); }
        }

        /// <summary>
        /// list ipv6 firewall rules by network ID
        /// </summary>
        public Guid? NetworkId {
            get { return GetParameterValue<Guid?>(nameof(NetworkId).ToLower()); }
            set { SetParameterValue(nameof(NetworkId).ToLower(), value); }
        }

        /// <summary>
        /// list objects by project; if projectid=-1 lists All VMs
        /// </summary>
        public Guid? ProjectId {
            get { return GetParameterValue<Guid?>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
        }

        /// <summary>
        /// List resources by tags (key/value pairs)
        /// </summary>
        public IList<IDictionary<string, object>> Tags {
            get { return GetList<IDictionary<string, object>>(nameof(Tags).ToLower()); }
            set { SetParameterValue(nameof(Tags).ToLower(), value); }
        }

        /// <summary>
        /// list ipv6 firewall rules by traffic type - ingress or egress
        /// </summary>
        public string TrafficType {
            get { return GetParameterValue<string>(nameof(TrafficType).ToLower()); }
            set { SetParameterValue(nameof(TrafficType).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists all IPv6 firewall rules
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<FirewallRuleResponse> ListIpv6FirewallRules(ListIpv6FirewallRulesRequest request);
        Task<ListResponse<FirewallRuleResponse>> ListIpv6FirewallRulesAsync(ListIpv6FirewallRulesRequest request);
        ListResponse<FirewallRuleResponse> ListIpv6FirewallRulesAllPages(ListIpv6FirewallRulesRequest request);
        Task<ListResponse<FirewallRuleResponse>> ListIpv6FirewallRulesAllPagesAsync(ListIpv6FirewallRulesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<FirewallRuleResponse> ListIpv6FirewallRules(ListIpv6FirewallRulesRequest request) => Proxy.Request<ListResponse<FirewallRuleResponse>>(request);
        public Task<ListResponse<FirewallRuleResponse>> ListIpv6FirewallRulesAsync(ListIpv6FirewallRulesRequest request) => Proxy.RequestAsync<ListResponse<FirewallRuleResponse>>(request);
        public ListResponse<FirewallRuleResponse> ListIpv6FirewallRulesAllPages(ListIpv6FirewallRulesRequest request) => Proxy.RequestAllPages<FirewallRuleResponse>(request);
        public Task<ListResponse<FirewallRuleResponse>> ListIpv6FirewallRulesAllPagesAsync(ListIpv6FirewallRulesRequest request) => Proxy.RequestAllPagesAsync<FirewallRuleResponse>(request);
    }
}
