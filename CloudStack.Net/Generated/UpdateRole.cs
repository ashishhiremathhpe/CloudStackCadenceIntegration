using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateRoleRequest : APIRequest
    {
        public UpdateRoleRequest() : base("updateRole") {}

        /// <summary>
        /// ID of the role
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// The description of the role
        /// </summary>
        public string Description {
            get { return GetParameterValue<string>(nameof(Description).ToLower()); }
            set { SetParameterValue(nameof(Description).ToLower(), value); }
        }

        /// <summary>
        /// Indicates whether the role will be visible to all users (public) or only to root admins (private).
        /// </summary>
        public bool? Ispublic {
            get { return GetParameterValue<bool?>(nameof(Ispublic).ToLower()); }
            set { SetParameterValue(nameof(Ispublic).ToLower(), value); }
        }

        /// <summary>
        /// creates a role with this unique name
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// The type of the role, valid options are: Admin, ResourceAdmin, DomainAdmin, User
        /// </summary>
        public string Type {
            get { return GetParameterValue<string>(nameof(Type).ToLower()); }
            set { SetParameterValue(nameof(Type).ToLower(), value); }
        }

    }
    /// <summary>
    /// Updates a role
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        RoleResponse UpdateRole(UpdateRoleRequest request);
        Task<RoleResponse> UpdateRoleAsync(UpdateRoleRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public RoleResponse UpdateRole(UpdateRoleRequest request) => Proxy.Request<RoleResponse>(request);
        public Task<RoleResponse> UpdateRoleAsync(UpdateRoleRequest request) => Proxy.RequestAsync<RoleResponse>(request);
    }
}
