using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UserTwoFactorAuthenticationSetupResponse
    {
        /// <summary>
        /// the user ID
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the account ID of the user
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// secret code that needs to be registered with authenticator
        /// </summary>
        public string SecretCode { get; set; }

        /// <summary>
        /// the user name
        /// </summary>
        public string Username { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
