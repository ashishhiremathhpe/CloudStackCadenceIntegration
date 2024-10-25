using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class RegisterUserDataRequest : APIRequest
    {
        public RegisterUserDataRequest() : base("registerUserData") {}

        /// <summary>
        /// Name of the userdata
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// Userdata content
        /// </summary>
        public string UserData {
            get { return GetParameterValue<string>(nameof(UserData).ToLower()); }
            set { SetParameterValue(nameof(UserData).ToLower(), value); }
        }

        /// <summary>
        /// an optional account for the userdata. Must be used with domainId.
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// an optional domainId for the userdata. If the account parameter is used, domainId must also be used.
        /// </summary>
        public Guid? DomainId {
            get { return GetParameterValue<Guid?>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// comma separated list of variables declared in userdata content
        /// </summary>
        public string Params {
            get { return GetParameterValue<string>(nameof(Params).ToLower()); }
            set { SetParameterValue(nameof(Params).ToLower(), value); }
        }

        /// <summary>
        /// an optional project for the userdata
        /// </summary>
        public Guid? ProjectId {
            get { return GetParameterValue<Guid?>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Register a new userdata.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse RegisterUserData(RegisterUserDataRequest request);
        Task<SuccessResponse> RegisterUserDataAsync(RegisterUserDataRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse RegisterUserData(RegisterUserDataRequest request) => Proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> RegisterUserDataAsync(RegisterUserDataRequest request) => Proxy.RequestAsync<SuccessResponse>(request);
    }
}
