using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UserResponse
    {
        /// <summary>
        /// the user ID
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the account name of the user
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// the account ID of the user
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// the account type of the user
        /// </summary>
        public int? AccountType { get; set; }

        /// <summary>
        /// the api key of the user
        /// </summary>
        public string ApiKey { get; set; }

        /// <summary>
        /// the date and time the user account was created
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// the domain name of the user
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// the domain ID of the user
        /// </summary>
        public string DomainId { get; set; }

        /// <summary>
        /// the user email address
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// the user firstname
        /// </summary>
        public string Firstname { get; set; }

        /// <summary>
        /// Base64 string representation of the resource icon
        /// </summary>
        public ResourceIconResponse Icon { get; set; }

        /// <summary>
        /// true if user has two factor authentication enabled
        /// </summary>
        public bool Is2FAenabled { get; set; }

        /// <summary>
        /// true if user has two factor authentication is mandated
        /// </summary>
        public bool Is2FAmandated { get; set; }

        /// <summary>
        /// the boolean value representing if the updating target is in caller's child domain
        /// </summary>
        public bool IsCallerChildDomain { get; set; }

        /// <summary>
        /// true if user is default, false otherwise
        /// </summary>
        public bool IsDefault { get; set; }

        /// <summary>
        /// the user lastname
        /// </summary>
        public string Lastname { get; set; }

        /// <summary>
        /// the ID of the role
        /// </summary>
        public string RoleId { get; set; }

        /// <summary>
        /// the name of the role
        /// </summary>
        public string RoleName { get; set; }

        /// <summary>
        /// the type of the role
        /// </summary>
        public string RoleType { get; set; }

        /// <summary>
        /// the secret key of the user
        /// </summary>
        public string SecretKey { get; set; }

        /// <summary>
        /// the user state
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// the timezone user was created in
        /// </summary>
        public string Timezone { get; set; }

        /// <summary>
        /// the user name
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// the source type of the user in lowercase, such as native, ldap, saml2
        /// </summary>
        public string UserSource { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
