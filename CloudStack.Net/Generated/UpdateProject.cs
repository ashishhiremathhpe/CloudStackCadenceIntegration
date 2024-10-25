using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateProjectRequest : APIRequest
    {
        public UpdateProjectRequest() : base("updateProject") {}

        /// <summary>
        /// id of the project to be modified
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// new Admin account for the project
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// display text of the project
        /// </summary>
        public string DisplayText {
            get { return GetParameterValue<string>(nameof(DisplayText).ToLower()); }
            set { SetParameterValue(nameof(DisplayText).ToLower(), value); }
        }

        /// <summary>
        /// name of the project
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// Account level role to be assigned to the user/account : Admin/Regular
        /// </summary>
        public string RoleType {
            get { return GetParameterValue<string>(nameof(RoleType).ToLower()); }
            set { SetParameterValue(nameof(RoleType).ToLower(), value); }
        }

        /// <summary>
        /// when true, it swaps ownership with the account/ user provided. Ideally to be used when a single project administrator is present. In case of multiple project admins, swapowner is to be set to false,to promote or demote the user/account based on the roleType (Regular or Admin) provided. Defaults to true
        /// </summary>
        public bool? SwapOwner {
            get { return GetParameterValue<bool?>(nameof(SwapOwner).ToLower()); }
            set { SetParameterValue(nameof(SwapOwner).ToLower(), value); }
        }

        /// <summary>
        /// ID of the user to be promoted/demoted
        /// </summary>
        public Guid? UserId {
            get { return GetParameterValue<Guid?>(nameof(UserId).ToLower()); }
            set { SetParameterValue(nameof(UserId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Updates a project
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse UpdateProject(UpdateProjectRequest request);
        Task<AsyncJobResponse> UpdateProjectAsync(UpdateProjectRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse UpdateProject(UpdateProjectRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> UpdateProjectAsync(UpdateProjectRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
