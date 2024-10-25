using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateProjectRolePermissionRequest : APIRequest
    {
        public CreateProjectRolePermissionRequest() : base("createProjectRolePermission") {}

        /// <summary>
        /// The rule permission, allow or deny. Default: deny.
        /// </summary>
        public string Permission {
            get { return GetParameterValue<string>(nameof(Permission).ToLower()); }
            set { SetParameterValue(nameof(Permission).ToLower(), value); }
        }

        /// <summary>
        /// ID of project where project role permission is to be created
        /// </summary>
        public Guid ProjectId {
            get { return GetParameterValue<Guid>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
        }

        /// <summary>
        /// ID of the project role
        /// </summary>
        public Guid ProjectRoleId {
            get { return GetParameterValue<Guid>(nameof(ProjectRoleId).ToLower()); }
            set { SetParameterValue(nameof(ProjectRoleId).ToLower(), value); }
        }

        /// <summary>
        /// The API name or wildcard rule such as list*
        /// </summary>
        public string Rule {
            get { return GetParameterValue<string>(nameof(Rule).ToLower()); }
            set { SetParameterValue(nameof(Rule).ToLower(), value); }
        }

        /// <summary>
        /// The description of the role permission
        /// </summary>
        public string Description {
            get { return GetParameterValue<string>(nameof(Description).ToLower()); }
            set { SetParameterValue(nameof(Description).ToLower(), value); }
        }

    }
    /// <summary>
    /// Adds API permissions to a project role
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ProjectRolePermissionResponse CreateProjectRolePermission(CreateProjectRolePermissionRequest request);
        Task<ProjectRolePermissionResponse> CreateProjectRolePermissionAsync(CreateProjectRolePermissionRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ProjectRolePermissionResponse CreateProjectRolePermission(CreateProjectRolePermissionRequest request) => Proxy.Request<ProjectRolePermissionResponse>(request);
        public Task<ProjectRolePermissionResponse> CreateProjectRolePermissionAsync(CreateProjectRolePermissionRequest request) => Proxy.RequestAsync<ProjectRolePermissionResponse>(request);
    }
}
