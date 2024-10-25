using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteUserFromProjectRequest : APIRequest
    {
        public DeleteUserFromProjectRequest() : base("deleteUserFromProject") {}

        /// <summary>
        /// ID of the project to remove the user from
        /// </summary>
        public Guid ProjectId {
            get { return GetParameterValue<Guid>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
        }

        /// <summary>
        /// Id of the user to be removed from the project
        /// </summary>
        public Guid UserId {
            get { return GetParameterValue<Guid>(nameof(UserId).ToLower()); }
            set { SetParameterValue(nameof(UserId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Deletes user from the project
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeleteUserFromProject(DeleteUserFromProjectRequest request);
        Task<AsyncJobResponse> DeleteUserFromProjectAsync(DeleteUserFromProjectRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteUserFromProject(DeleteUserFromProjectRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DeleteUserFromProjectAsync(DeleteUserFromProjectRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
