using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListLdapConfigurationsRequest : APIListRequest
    {
        public ListLdapConfigurationsRequest() : base("listLdapConfigurations") {}

        /// <summary>
        /// linked domain
        /// </summary>
        public Guid? DomainId {
            get { return GetParameterValue<Guid?>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// Hostname
        /// </summary>
        public string Hostname {
            get { return GetParameterValue<string>(nameof(Hostname).ToLower()); }
            set { SetParameterValue(nameof(Hostname).ToLower(), value); }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// If set to true,  and no domainid specified, list all LDAP configurations irrespective of the linked domain
        /// </summary>
        public bool? ListAll {
            get { return GetParameterValue<bool?>(nameof(ListAll).ToLower()); }
            set { SetParameterValue(nameof(ListAll).ToLower(), value); }
        }

        /// <summary>
        /// Port
        /// </summary>
        public int? Port {
            get { return GetParameterValue<int?>(nameof(Port).ToLower()); }
            set { SetParameterValue(nameof(Port).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists all LDAP configurations
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<LdapConfigurationResponse> ListLdapConfigurations(ListLdapConfigurationsRequest request);
        Task<ListResponse<LdapConfigurationResponse>> ListLdapConfigurationsAsync(ListLdapConfigurationsRequest request);
        ListResponse<LdapConfigurationResponse> ListLdapConfigurationsAllPages(ListLdapConfigurationsRequest request);
        Task<ListResponse<LdapConfigurationResponse>> ListLdapConfigurationsAllPagesAsync(ListLdapConfigurationsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<LdapConfigurationResponse> ListLdapConfigurations(ListLdapConfigurationsRequest request) => Proxy.Request<ListResponse<LdapConfigurationResponse>>(request);
        public Task<ListResponse<LdapConfigurationResponse>> ListLdapConfigurationsAsync(ListLdapConfigurationsRequest request) => Proxy.RequestAsync<ListResponse<LdapConfigurationResponse>>(request);
        public ListResponse<LdapConfigurationResponse> ListLdapConfigurationsAllPages(ListLdapConfigurationsRequest request) => Proxy.RequestAllPages<LdapConfigurationResponse>(request);
        public Task<ListResponse<LdapConfigurationResponse>> ListLdapConfigurationsAllPagesAsync(ListLdapConfigurationsRequest request) => Proxy.RequestAllPagesAsync<LdapConfigurationResponse>(request);
    }
}
