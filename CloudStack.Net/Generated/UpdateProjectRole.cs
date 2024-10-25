using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateProjectRoleRequest : APIRequest
    {
        public UpdateProjectRoleRequest() : base("updateProjectRole") {}

        /// <summary>
        /// ID of the Project role
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// ID of project where role is being created
        /// </summary>
        public Guid ProjectId {
            get { return GetParameterValue<Guid>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
        }

        /// <summary>
        /// The description of the Project role
        /// </summary>
        public string Description {
            get { return GetParameterValue<string>(nameof(Description).ToLower()); }
            set { SetParameterValue(nameof(Description).ToLower(), value); }
        }

        /// <summary>
        /// creates a project role with this unique name
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

    }
    /// <summary>
    /// Creates a Project role
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ProjectRoleResponse UpdateProjectRole(UpdateProjectRoleRequest request);
        Task<ProjectRoleResponse> UpdateProjectRoleAsync(UpdateProjectRoleRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ProjectRoleResponse UpdateProjectRole(UpdateProjectRoleRequest request) => Proxy.Request<ProjectRoleResponse>(request);
        public Task<ProjectRoleResponse> UpdateProjectRoleAsync(UpdateProjectRoleRequest request) => Proxy.RequestAsync<ProjectRoleResponse>(request);
    }
}
