using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ImportRoleRequest : APIRequest
    {
        public ImportRoleRequest() : base("importRole") {}

        /// <summary>
        /// Creates a role with this unique name
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// Rules param list, rule and permission is must. Example: rules[0].rule=create*&rules[0].permission=allow&rules[0].description=create%20rule&rules[1].rule=list*&rules[1].permission=allow&rules[1].description=listing
        /// </summary>
        public IList<IDictionary<string, object>> Rules {
            get { return GetList<IDictionary<string, object>>(nameof(Rules).ToLower()); }
            set { SetParameterValue(nameof(Rules).ToLower(), value); }
        }

        /// <summary>
        /// The description of the role
        /// </summary>
        public string Description {
            get { return GetParameterValue<string>(nameof(Description).ToLower()); }
            set { SetParameterValue(nameof(Description).ToLower(), value); }
        }

        /// <summary>
        /// Force create a role with the same name. This overrides the role type, description and rule permissions for the existing role. Default is false.
        /// </summary>
        public bool? Forced {
            get { return GetParameterValue<bool?>(nameof(Forced).ToLower()); }
            set { SetParameterValue(nameof(Forced).ToLower(), value); }
        }

        /// <summary>
        /// Indicates whether the role will be visible to all users (public) or only to root admins (private). If this parameter is not specified during the creation of the role its value will be defaulted to true (public).
        /// </summary>
        public bool? Ispublic {
            get { return GetParameterValue<bool?>(nameof(Ispublic).ToLower()); }
            set { SetParameterValue(nameof(Ispublic).ToLower(), value); }
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
    /// Imports a role based on provided map of rule permissions
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        RoleResponse ImportRole(ImportRoleRequest request);
        Task<RoleResponse> ImportRoleAsync(ImportRoleRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public RoleResponse ImportRole(ImportRoleRequest request) => Proxy.Request<RoleResponse>(request);
        public Task<RoleResponse> ImportRoleAsync(ImportRoleRequest request) => Proxy.RequestAsync<RoleResponse>(request);
    }
}
