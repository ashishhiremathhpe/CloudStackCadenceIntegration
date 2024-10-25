using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class LinkAccountToLdapRequest : APIRequest
    {
        public LinkAccountToLdapRequest() : base("linkAccountToLdap") {}

        /// <summary>
        /// name of the account, it will be created if it does not exist
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// Type of the account to auto import. Specify 0 for user and 2 for domain admin
        /// </summary>
        public int? AccountType {
            get { return GetParameterValue<int?>(nameof(AccountType).ToLower()); }
            set { SetParameterValue(nameof(AccountType).ToLower(), value); }
        }

        /// <summary>
        /// The id of the domain that is to contain the linked account.
        /// </summary>
        public Guid DomainId {
            get { return GetParameterValue<Guid>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// name of the group or OU in LDAP
        /// </summary>
        public string LdapDomain {
            get { return GetParameterValue<string>(nameof(LdapDomain).ToLower()); }
            set { SetParameterValue(nameof(LdapDomain).ToLower(), value); }
        }

        /// <summary>
        /// domain admin username in LDAP 
        /// </summary>
        public string Admin {
            get { return GetParameterValue<string>(nameof(Admin).ToLower()); }
            set { SetParameterValue(nameof(Admin).ToLower(), value); }
        }

        /// <summary>
        /// type of the ldap name. GROUP or OU, defaults to GROUP
        /// </summary>
        public string Type {
            get { return GetParameterValue<string>(nameof(Type).ToLower()); }
            set { SetParameterValue(nameof(Type).ToLower(), value); }
        }

    }
    /// <summary>
    /// link a cloudstack account to a group or OU in ldap
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        LinkDomainToLdapResponse LinkAccountToLdap(LinkAccountToLdapRequest request);
        Task<LinkDomainToLdapResponse> LinkAccountToLdapAsync(LinkAccountToLdapRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public LinkDomainToLdapResponse LinkAccountToLdap(LinkAccountToLdapRequest request) => Proxy.Request<LinkDomainToLdapResponse>(request);
        public Task<LinkDomainToLdapResponse> LinkAccountToLdapAsync(LinkAccountToLdapRequest request) => Proxy.RequestAsync<LinkDomainToLdapResponse>(request);
    }
}
