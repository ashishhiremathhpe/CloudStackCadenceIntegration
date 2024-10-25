using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateProjectRoleRequest : APIRequest
    {
        public CreateProjectRoleRequest() : base("createProjectRole") {}

        /// <summary>
        /// creates a project role with this unique name
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
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

    }
    /// <summary>
    /// Creates a Project role
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ProjectRoleResponse CreateProjectRole(CreateProjectRoleRequest request);
        Task<ProjectRoleResponse> CreateProjectRoleAsync(CreateProjectRoleRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ProjectRoleResponse CreateProjectRole(CreateProjectRoleRequest request) => Proxy.Request<ProjectRoleResponse>(request);
        public Task<ProjectRoleResponse> CreateProjectRoleAsync(CreateProjectRoleRequest request) => Proxy.RequestAsync<ProjectRoleResponse>(request);
    }
}
