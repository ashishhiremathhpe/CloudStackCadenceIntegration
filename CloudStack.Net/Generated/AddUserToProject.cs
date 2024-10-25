using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AddUserToProjectRequest : APIRequest
    {
        public AddUserToProjectRequest() : base("addUserToProject") {}

        /// <summary>
        /// ID of the project to add the user to
        /// </summary>
        public Guid ProjectId {
            get { return GetParameterValue<Guid>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
        }

        /// <summary>
        /// Name of the user to be added to the project
        /// </summary>
        public string Username {
            get { return GetParameterValue<string>(nameof(Username).ToLower()); }
            set { SetParameterValue(nameof(Username).ToLower(), value); }
        }

        /// <summary>
        /// email ID of user to which invitation to the project is going to be sent
        /// </summary>
        public string Email {
            get { return GetParameterValue<string>(nameof(Email).ToLower()); }
            set { SetParameterValue(nameof(Email).ToLower(), value); }
        }

        /// <summary>
        /// ID of the project role
        /// </summary>
        public Guid? ProjectRoleId {
            get { return GetParameterValue<Guid?>(nameof(ProjectRoleId).ToLower()); }
            set { SetParameterValue(nameof(ProjectRoleId).ToLower(), value); }
        }

        /// <summary>
        /// Project role type to be assigned to the user - Admin/Regular
        /// </summary>
        public string RoleType {
            get { return GetParameterValue<string>(nameof(RoleType).ToLower()); }
            set { SetParameterValue(nameof(RoleType).ToLower(), value); }
        }

    }
    /// <summary>
    /// Adds user to a project
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse AddUserToProject(AddUserToProjectRequest request);
        Task<AsyncJobResponse> AddUserToProjectAsync(AddUserToProjectRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse AddUserToProject(AddUserToProjectRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> AddUserToProjectAsync(AddUserToProjectRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
