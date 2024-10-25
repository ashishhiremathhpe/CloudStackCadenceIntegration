using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class LdapConfigurationResponse
    {
        /// <summary>
        /// linked domain
        /// </summary>
        public string DomainId { get; set; }

        /// <summary>
        /// name of the host running the ldap server
        /// </summary>
        public string Hostname { get; set; }

        /// <summary>
        /// port the ldap server is running on
        /// </summary>
        public int Port { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
