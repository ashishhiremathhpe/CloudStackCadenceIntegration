using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateProjectRolePermissionRequest : APIRequest
    {
        public UpdateProjectRolePermissionRequest() : base("updateProjectRolePermission") {}

        /// <summary>
        /// ID of project where project role permission is to be updated
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
        /// Rule permission, can be: allow or deny
        /// </summary>
        public string Permission {
            get { return GetParameterValue<string>(nameof(Permission).ToLower()); }
            set { SetParameterValue(nameof(Permission).ToLower(), value); }
        }

        /// <summary>
        /// Project Role permission rule id
        /// </summary>
        public Guid? Projectrolepermissionid {
            get { return GetParameterValue<Guid?>(nameof(Projectrolepermissionid).ToLower()); }
            set { SetParameterValue(nameof(Projectrolepermissionid).ToLower(), value); }
        }

        /// <summary>
        /// The parent role permission uuid, use 0 to move this rule at the top of the list
        /// </summary>
        public IList<Guid> Ruleorder {
            get { return GetList<Guid>(nameof(Ruleorder).ToLower()); }
            set { SetParameterValue(nameof(Ruleorder).ToLower(), value); }
        }

    }
    /// <summary>
    /// Updates a project role permission and/or order
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse UpdateProjectRolePermission(UpdateProjectRolePermissionRequest request);
        Task<SuccessResponse> UpdateProjectRolePermissionAsync(UpdateProjectRolePermissionRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse UpdateProjectRolePermission(UpdateProjectRolePermissionRequest request) => Proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> UpdateProjectRolePermissionAsync(UpdateProjectRolePermissionRequest request) => Proxy.RequestAsync<SuccessResponse>(request);
    }
}
