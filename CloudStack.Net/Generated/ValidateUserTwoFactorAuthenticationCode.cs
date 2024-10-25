using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ValidateUserTwoFactorAuthenticationCodeRequest : APIRequest
    {
        public ValidateUserTwoFactorAuthenticationCodeRequest() : base("validateUserTwoFactorAuthenticationCode") {}

        /// <summary>
        /// two factor authentication code
        /// </summary>
        public string CodeFor2fa {
            get { return GetParameterValue<string>(nameof(CodeFor2fa).ToLower()); }
            set { SetParameterValue(nameof(CodeFor2fa).ToLower(), value); }
        }

    }
    /// <summary>
    /// Checks the 2FA code for the user.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse ValidateUserTwoFactorAuthenticationCode(ValidateUserTwoFactorAuthenticationCodeRequest request);
        Task<SuccessResponse> ValidateUserTwoFactorAuthenticationCodeAsync(ValidateUserTwoFactorAuthenticationCodeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse ValidateUserTwoFactorAuthenticationCode(ValidateUserTwoFactorAuthenticationCodeRequest request) => Proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> ValidateUserTwoFactorAuthenticationCodeAsync(ValidateUserTwoFactorAuthenticationCodeRequest request) => Proxy.RequestAsync<SuccessResponse>(request);
    }
}
