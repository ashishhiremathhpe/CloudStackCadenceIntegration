using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateRoleRequest : APIRequest
    {
        public CreateRoleRequest() : base("createRole") {}

        /// <summary>
        /// Creates a role with this unique name
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// The description of the role
        /// </summary>
        public string Description {
            get { return GetParameterValue<string>(nameof(Description).ToLower()); }
            set { SetParameterValue(nameof(Description).ToLower(), value); }
        }

        /// <summary>
        /// Indicates whether the role will be visible to all users (public) or only to root admins (private). Default is true.
        /// </summary>
        public bool? Ispublic {
            get { return GetParameterValue<bool?>(nameof(Ispublic).ToLower()); }
            set { SetParameterValue(nameof(Ispublic).ToLower(), value); }
        }

        /// <summary>
        /// ID of the role to be cloned from. Either roleid or type must be passed in
        /// </summary>
        public Guid? RoleId {
            get { return GetParameterValue<Guid?>(nameof(RoleId).ToLower()); }
            set { SetParameterValue(nameof(RoleId).ToLower(), value); }
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
    /// Creates a role
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        RoleResponse CreateRole(CreateRoleRequest request);
        Task<RoleResponse> CreateRoleAsync(CreateRoleRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public RoleResponse CreateRole(CreateRoleRequest request) => Proxy.Request<RoleResponse>(request);
        public Task<RoleResponse> CreateRoleAsync(CreateRoleRequest request) => Proxy.RequestAsync<RoleResponse>(request);
    }
}
