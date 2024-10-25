using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class LDAPConfigResponse
    {
        /// <summary>
        /// Specify the distinguished name of a user with the search permission on the directory
        /// </summary>
        public string BindDN { get; set; }

        /// <summary>
        /// DN password
        /// </summary>
        public string Bindpass { get; set; }

        /// <summary>
        /// Hostname or ip address of the ldap server eg: my.ldap.com
        /// </summary>
        public string Hostname { get; set; }

        /// <summary>
        /// Specify the LDAP port if required, default is 389
        /// </summary>
        public string Port { get; set; }

        /// <summary>
        /// You specify a query filter here, which narrows down the users, who can be part of this domain
        /// </summary>
        public string QueryFilter { get; set; }

        /// <summary>
        /// The search base defines the starting point for the search in the directory tree Example:  dc=cloud,dc=com
        /// </summary>
        public string SearchBase { get; set; }

        /// <summary>
        /// Check Use SSL if the external LDAP server is configured for LDAP over SSL
        /// </summary>
        public string Ssl { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
