using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteProjectRoleRequest : APIRequest
    {
        public DeleteProjectRoleRequest() : base("deleteProjectRole") {}

        /// <summary>
        /// ID of the project role to be deleted
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// ID of the project from where the role is to be deleted
        /// </summary>
        public Guid ProjectId {
            get { return GetParameterValue<Guid>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Delete Project roles in CloudStack
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteProjectRole(DeleteProjectRoleRequest request);
        Task<SuccessResponse> DeleteProjectRoleAsync(DeleteProjectRoleRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteProjectRole(DeleteProjectRoleRequest request) => Proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> DeleteProjectRoleAsync(DeleteProjectRoleRequest request) => Proxy.RequestAsync<SuccessResponse>(request);
    }
}
