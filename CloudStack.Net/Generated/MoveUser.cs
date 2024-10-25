using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class MoveUserRequest : APIRequest
    {
        public MoveUserRequest() : base("moveUser") {}

        /// <summary>
        /// id of the user to be deleted
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// Creates the user under the specified account. If no account is specified, the username will be used as the account name.
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// Creates the user under the specified domain. Has to be accompanied with the account parameter
        /// </summary>
        public Guid? AccountId {
            get { return GetParameterValue<Guid?>(nameof(AccountId).ToLower()); }
            set { SetParameterValue(nameof(AccountId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Moves a user to another account
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse MoveUser(MoveUserRequest request);
        Task<SuccessResponse> MoveUserAsync(MoveUserRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse MoveUser(MoveUserRequest request) => Proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> MoveUserAsync(MoveUserRequest request) => Proxy.RequestAsync<SuccessResponse>(request);
    }
}
