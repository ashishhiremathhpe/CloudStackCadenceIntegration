using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateRolePermissionRequest : APIRequest
    {
        public UpdateRolePermissionRequest() : base("updateRolePermission") {}

        /// <summary>
        /// ID of the role
        /// </summary>
        public Guid RoleId {
            get { return GetParameterValue<Guid>(nameof(RoleId).ToLower()); }
            set { SetParameterValue(nameof(RoleId).ToLower(), value); }
        }

        /// <summary>
        /// Rule permission, can be: allow or deny
        /// </summary>
        public string Permission {
            get { return GetParameterValue<string>(nameof(Permission).ToLower()); }
            set { SetParameterValue(nameof(Permission).ToLower(), value); }
        }

        /// <summary>
        /// Role permission rule id
        /// </summary>
        public Guid? RuleId {
            get { return GetParameterValue<Guid?>(nameof(RuleId).ToLower()); }
            set { SetParameterValue(nameof(RuleId).ToLower(), value); }
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
    /// Updates a role permission order
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse UpdateRolePermission(UpdateRolePermissionRequest request);
        Task<SuccessResponse> UpdateRolePermissionAsync(UpdateRolePermissionRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse UpdateRolePermission(UpdateRolePermissionRequest request) => Proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> UpdateRolePermissionAsync(UpdateRolePermissionRequest request) => Proxy.RequestAsync<SuccessResponse>(request);
    }
}
