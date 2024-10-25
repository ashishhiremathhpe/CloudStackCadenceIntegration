using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteUserDataRequest : APIRequest
    {
        public DeleteUserDataRequest() : base("deleteUserData") {}

        /// <summary>
        /// the ID of the Userdata
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
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
        /// an optional project for the userdata
        /// </summary>
        public Guid? ProjectId {
            get { return GetParameterValue<Guid?>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Deletes a userdata
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteUserData(DeleteUserDataRequest request);
        Task<SuccessResponse> DeleteUserDataAsync(DeleteUserDataRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteUserData(DeleteUserDataRequest request) => Proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> DeleteUserDataAsync(DeleteUserDataRequest request) => Proxy.RequestAsync<SuccessResponse>(request);
    }
}
