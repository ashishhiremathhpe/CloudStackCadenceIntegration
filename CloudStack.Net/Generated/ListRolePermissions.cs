using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListRolePermissionsRequest : APIRequest
    {
        public ListRolePermissionsRequest() : base("listRolePermissions") {}

        /// <summary>
        /// ID of the role
        /// </summary>
        public Guid? RoleId {
            get { return GetParameterValue<Guid?>(nameof(RoleId).ToLower()); }
            set { SetParameterValue(nameof(RoleId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists role permissions
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        RolePermissionResponse ListRolePermissions(ListRolePermissionsRequest request);
        Task<RolePermissionResponse> ListRolePermissionsAsync(ListRolePermissionsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public RolePermissionResponse ListRolePermissions(ListRolePermissionsRequest request) => Proxy.Request<RolePermissionResponse>(request);
        public Task<RolePermissionResponse> ListRolePermissionsAsync(ListRolePermissionsRequest request) => Proxy.RequestAsync<RolePermissionResponse>(request);
    }
}
