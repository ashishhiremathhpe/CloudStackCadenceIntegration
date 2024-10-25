using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateRolePermissionRequest : APIRequest
    {
        public CreateRolePermissionRequest() : base("createRolePermission") {}

        /// <summary>
        /// The rule permission, allow or deny. Default: deny.
        /// </summary>
        public string Permission {
            get { return GetParameterValue<string>(nameof(Permission).ToLower()); }
            set { SetParameterValue(nameof(Permission).ToLower(), value); }
        }

        /// <summary>
        /// ID of the role
        /// </summary>
        public Guid RoleId {
            get { return GetParameterValue<Guid>(nameof(RoleId).ToLower()); }
            set { SetParameterValue(nameof(RoleId).ToLower(), value); }
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
    /// Adds an API permission to a role
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        RolePermissionResponse CreateRolePermission(CreateRolePermissionRequest request);
        Task<RolePermissionResponse> CreateRolePermissionAsync(CreateRolePermissionRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public RolePermissionResponse CreateRolePermission(CreateRolePermissionRequest request) => Proxy.Request<RolePermissionResponse>(request);
        public Task<RolePermissionResponse> CreateRolePermissionAsync(CreateRolePermissionRequest request) => Proxy.RequestAsync<RolePermissionResponse>(request);
    }
}
