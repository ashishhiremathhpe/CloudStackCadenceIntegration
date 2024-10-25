using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class OauthProviderResponse
    {
        /// <summary>
        /// ID of the provider
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Client ID registered in the OAuth provider
        /// </summary>
        public string ClientId { get; set; }

        /// <summary>
        /// Description of the provider registered
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Whether the OAuth provider is enabled or not
        /// </summary>
        public bool Enabled { get; set; }

        /// <summary>
        /// Name of the provider
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Name of the provider
        /// </summary>
        public string Provider { get; set; }

        /// <summary>
        /// Redirect URI registered in the OAuth provider
        /// </summary>
        public string RedirectUri { get; set; }

        /// <summary>
        /// Secret key registered in the OAuth provider
        /// </summary>
        public string SecretKey { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
