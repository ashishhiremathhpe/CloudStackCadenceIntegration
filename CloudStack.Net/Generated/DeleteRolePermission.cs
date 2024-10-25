using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteRolePermissionRequest : APIRequest
    {
        public DeleteRolePermissionRequest() : base("deleteRolePermission") {}

        /// <summary>
        /// ID of the role permission
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Deletes a role permission
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteRolePermission(DeleteRolePermissionRequest request);
        Task<SuccessResponse> DeleteRolePermissionAsync(DeleteRolePermissionRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteRolePermission(DeleteRolePermissionRequest request) => Proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> DeleteRolePermissionAsync(DeleteRolePermissionRequest request) => Proxy.RequestAsync<SuccessResponse>(request);
    }
}
