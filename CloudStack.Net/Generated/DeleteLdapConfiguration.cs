using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteLdapConfigurationRequest : APIRequest
    {
        public DeleteLdapConfigurationRequest() : base("deleteLdapConfiguration") {}

        /// <summary>
        /// Hostname
        /// </summary>
        public string Hostname {
            get { return GetParameterValue<string>(nameof(Hostname).ToLower()); }
            set { SetParameterValue(nameof(Hostname).ToLower(), value); }
        }

        /// <summary>
        /// linked domain
        /// </summary>
        public Guid? DomainId {
            get { return GetParameterValue<Guid?>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// port
        /// </summary>
        public int? Port {
            get { return GetParameterValue<int?>(nameof(Port).ToLower()); }
            set { SetParameterValue(nameof(Port).ToLower(), value); }
        }

    }
    /// <summary>
    /// Remove an Ldap Configuration
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        LdapConfigurationResponse DeleteLdapConfiguration(DeleteLdapConfigurationRequest request);
        Task<LdapConfigurationResponse> DeleteLdapConfigurationAsync(DeleteLdapConfigurationRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public LdapConfigurationResponse DeleteLdapConfiguration(DeleteLdapConfigurationRequest request) => Proxy.Request<LdapConfigurationResponse>(request);
        public Task<LdapConfigurationResponse> DeleteLdapConfigurationAsync(DeleteLdapConfigurationRequest request) => Proxy.RequestAsync<LdapConfigurationResponse>(request);
    }
}
