using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class LdapRemoveRequest : APIRequest
    {
        public LdapRemoveRequest() : base("ldapRemove") {}

    }
    /// <summary>
    /// (Deprecated , use deleteLdapConfiguration) Remove the LDAP context for this site.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        LDAPConfigResponse LdapRemove(LdapRemoveRequest request);
        Task<LDAPConfigResponse> LdapRemoveAsync(LdapRemoveRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public LDAPConfigResponse LdapRemove(LdapRemoveRequest request) => Proxy.Request<LDAPConfigResponse>(request);
        public Task<LDAPConfigResponse> LdapRemoveAsync(LdapRemoveRequest request) => Proxy.RequestAsync<LDAPConfigResponse>(request);
    }
}
