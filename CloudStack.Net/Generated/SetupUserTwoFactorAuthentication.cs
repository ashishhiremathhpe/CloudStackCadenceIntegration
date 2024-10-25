using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class SetupUserTwoFactorAuthenticationRequest : APIRequest
    {
        public SetupUserTwoFactorAuthenticationRequest() : base("setupUserTwoFactorAuthentication") {}

        /// <summary>
        /// Enabled by default, provide false to disable 2FA
        /// </summary>
        public bool? Enable {
            get { return GetParameterValue<bool?>(nameof(Enable).ToLower()); }
            set { SetParameterValue(nameof(Enable).ToLower(), value); }
        }

        /// <summary>
        /// two factor authentication code
        /// </summary>
        public string Provider {
            get { return GetParameterValue<string>(nameof(Provider).ToLower()); }
            set { SetParameterValue(nameof(Provider).ToLower(), value); }
        }

        /// <summary>
        /// optional: the id of the user for which 2FA has to be disabled
        /// </summary>
        public Guid? UserId {
            get { return GetParameterValue<Guid?>(nameof(UserId).ToLower()); }
            set { SetParameterValue(nameof(UserId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Setup the 2FA for the user.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        UserTwoFactorAuthenticationSetupResponse SetupUserTwoFactorAuthentication(SetupUserTwoFactorAuthenticationRequest request);
        Task<UserTwoFactorAuthenticationSetupResponse> SetupUserTwoFactorAuthenticationAsync(SetupUserTwoFactorAuthenticationRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public UserTwoFactorAuthenticationSetupResponse SetupUserTwoFactorAuthentication(SetupUserTwoFactorAuthenticationRequest request) => Proxy.Request<UserTwoFactorAuthenticationSetupResponse>(request);
        public Task<UserTwoFactorAuthenticationSetupResponse> SetupUserTwoFactorAuthenticationAsync(SetupUserTwoFactorAuthenticationRequest request) => Proxy.RequestAsync<UserTwoFactorAuthenticationSetupResponse>(request);
    }
}
