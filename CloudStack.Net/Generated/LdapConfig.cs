using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class LdapConfigRequest : APIRequest
    {
        public LdapConfigRequest() : base("ldapConfig") {}

        /// <summary>
        /// Specify the distinguished name of a user with the search permission on the directory.
        /// </summary>
        public string BindDN {
            get { return GetParameterValue<string>(nameof(BindDN).ToLower()); }
            set { SetParameterValue(nameof(BindDN).ToLower(), value); }
        }

        /// <summary>
        /// Enter the password.
        /// </summary>
        public string Bindpass {
            get { return GetParameterValue<string>(nameof(Bindpass).ToLower()); }
            set { SetParameterValue(nameof(Bindpass).ToLower(), value); }
        }

        /// <summary>
        /// Hostname or ip address of the ldap server eg: my.ldap.com
        /// </summary>
        public string Hostname {
            get { return GetParameterValue<string>(nameof(Hostname).ToLower()); }
            set { SetParameterValue(nameof(Hostname).ToLower(), value); }
        }

        /// <summary>
        /// If true return current LDAP configuration
        /// </summary>
        public bool? ListAll {
            get { return GetParameterValue<bool?>(nameof(ListAll).ToLower()); }
            set { SetParameterValue(nameof(ListAll).ToLower(), value); }
        }

        /// <summary>
        /// Specify the LDAP port if required, default is 389.
        /// </summary>
        public int? Port {
            get { return GetParameterValue<int?>(nameof(Port).ToLower()); }
            set { SetParameterValue(nameof(Port).ToLower(), value); }
        }

        /// <summary>
        /// You specify a query filter here, which narrows down the users, who can be part of this domain.
        /// </summary>
        public string QueryFilter {
            get { return GetParameterValue<string>(nameof(QueryFilter).ToLower()); }
            set { SetParameterValue(nameof(QueryFilter).ToLower(), value); }
        }

        /// <summary>
        /// The search base defines the starting point for the search in the directory tree Example:  dc=cloud,dc=com.
        /// </summary>
        public string SearchBase {
            get { return GetParameterValue<string>(nameof(SearchBase).ToLower()); }
            set { SetParameterValue(nameof(SearchBase).ToLower(), value); }
        }

        /// <summary>
        /// Check Use SSL if the external LDAP server is configured for LDAP over SSL.
        /// </summary>
        public bool? Ssl {
            get { return GetParameterValue<bool?>(nameof(Ssl).ToLower()); }
            set { SetParameterValue(nameof(Ssl).ToLower(), value); }
        }

        /// <summary>
        /// Enter the path to trust certificates store.
        /// </summary>
        public string TrustStore {
            get { return GetParameterValue<string>(nameof(TrustStore).ToLower()); }
            set { SetParameterValue(nameof(TrustStore).ToLower(), value); }
        }

        /// <summary>
        /// Enter the password for trust store.
        /// </summary>
        public string Truststorepass {
            get { return GetParameterValue<string>(nameof(Truststorepass).ToLower()); }
            set { SetParameterValue(nameof(Truststorepass).ToLower(), value); }
        }

    }
    /// <summary>
    /// (Deprecated, use addLdapConfiguration) Configure the LDAP context for this site.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        LDAPConfigResponse LdapConfig(LdapConfigRequest request);
        Task<LDAPConfigResponse> LdapConfigAsync(LdapConfigRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public LDAPConfigResponse LdapConfig(LdapConfigRequest request) => Proxy.Request<LDAPConfigResponse>(request);
        public Task<LDAPConfigResponse> LdapConfigAsync(LdapConfigRequest request) => Proxy.RequestAsync<LDAPConfigResponse>(request);
    }
}
