using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteProjectRolePermissionRequest : APIRequest
    {
        public DeleteProjectRolePermissionRequest() : base("deleteProjectRolePermission") {}

        /// <summary>
        /// ID of the project role permission to be deleted
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// ID of the project where the project role permission is to be deleted
        /// </summary>
        public Guid ProjectId {
            get { return GetParameterValue<Guid>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Deletes a project role permission in the project
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteProjectRolePermission(DeleteProjectRolePermissionRequest request);
        Task<SuccessResponse> DeleteProjectRolePermissionAsync(DeleteProjectRolePermissionRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteProjectRolePermission(DeleteProjectRolePermissionRequest request) => Proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> DeleteProjectRolePermissionAsync(DeleteProjectRolePermissionRequest request) => Proxy.RequestAsync<SuccessResponse>(request);
    }
}
