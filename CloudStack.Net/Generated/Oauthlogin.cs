using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class OauthloginRequest : APIRequest
    {
        public OauthloginRequest() : base("oauthlogin") {}

        /// <summary>
        /// Email id with which user tried to login using OAuth provider
        /// </summary>
        public string Email {
            get { return GetParameterValue<string>(nameof(Email).ToLower()); }
            set { SetParameterValue(nameof(Email).ToLower(), value); }
        }

        /// <summary>
        /// Name of the provider
        /// </summary>
        public string Provider {
            get { return GetParameterValue<string>(nameof(Provider).ToLower()); }
            set { SetParameterValue(nameof(Provider).ToLower(), value); }
        }

        /// <summary>
        /// Path of the domain that the user belongs to. Example: domain=/com/cloud/internal. If no domain is passed in, the ROOT (/) domain is assumed.
        /// </summary>
        public string Domain {
            get { return GetParameterValue<string>(nameof(Domain).ToLower()); }
            set { SetParameterValue(nameof(Domain).ToLower(), value); }
        }

        /// <summary>
        /// The id of the domain that the user belongs to. If both domain and domainId are passed in, "domainId" parameter takes precedence.
        /// </summary>
        public long? DomainId {
            get { return GetParameterValue<long?>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// Code that is provided by OAuth provider (Eg. google, github) after successful login
        /// </summary>
        public string SecretCode {
            get { return GetParameterValue<string>(nameof(SecretCode).ToLower()); }
            set { SetParameterValue(nameof(SecretCode).ToLower(), value); }
        }

    }
    /// <summary>
    /// Logs a user into the CloudStack after successful verification of OAuth secret code from the particular provider.A successful login attempt will generate a JSESSIONID cookie value that can be passed in subsequent Query command calls until the "logout" command has been issued or the session has expired.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        LoginCmdResponse Oauthlogin(OauthloginRequest request);
        Task<LoginCmdResponse> OauthloginAsync(OauthloginRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public LoginCmdResponse Oauthlogin(OauthloginRequest request) => Proxy.Request<LoginCmdResponse>(request);
        public Task<LoginCmdResponse> OauthloginAsync(OauthloginRequest request) => Proxy.RequestAsync<LoginCmdResponse>(request);
    }
}
