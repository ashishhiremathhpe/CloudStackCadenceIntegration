using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListProjectRolePermissionsRequest : APIRequest
    {
        public ListProjectRolePermissionsRequest() : base("listProjectRolePermissions") {}

        /// <summary>
        /// ID of the project
        /// </summary>
        public Guid ProjectId {
            get { return GetParameterValue<Guid>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
        }

        /// <summary>
        /// ID of the project role
        /// </summary>
        public Guid? ProjectRoleId {
            get { return GetParameterValue<Guid?>(nameof(ProjectRoleId).ToLower()); }
            set { SetParameterValue(nameof(ProjectRoleId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists a project's project role permissions
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ProjectRolePermissionResponse ListProjectRolePermissions(ListProjectRolePermissionsRequest request);
        Task<ProjectRolePermissionResponse> ListProjectRolePermissionsAsync(ListProjectRolePermissionsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ProjectRolePermissionResponse ListProjectRolePermissions(ListProjectRolePermissionsRequest request) => Proxy.Request<ProjectRolePermissionResponse>(request);
        public Task<ProjectRolePermissionResponse> ListProjectRolePermissionsAsync(ListProjectRolePermissionsRequest request) => Proxy.RequestAsync<ProjectRolePermissionResponse>(request);
    }
}
