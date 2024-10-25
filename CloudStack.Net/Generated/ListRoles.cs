using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListRolesRequest : APIListRequest
    {
        public ListRolesRequest() : base("listRoles") {}

        /// <summary>
        /// List role by role ID.
        /// </summary>
        public Guid? Id {
            get { return GetParameterValue<Guid?>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// List role by role name.
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// List role by role type, valid options are: Admin, ResourceAdmin, DomainAdmin, User.
        /// </summary>
        public string Type {
            get { return GetParameterValue<string>(nameof(Type).ToLower()); }
            set { SetParameterValue(nameof(Type).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists dynamic roles in CloudStack
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<RoleResponse> ListRoles(ListRolesRequest request);
        Task<ListResponse<RoleResponse>> ListRolesAsync(ListRolesRequest request);
        ListResponse<RoleResponse> ListRolesAllPages(ListRolesRequest request);
        Task<ListResponse<RoleResponse>> ListRolesAllPagesAsync(ListRolesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<RoleResponse> ListRoles(ListRolesRequest request) => Proxy.Request<ListResponse<RoleResponse>>(request);
        public Task<ListResponse<RoleResponse>> ListRolesAsync(ListRolesRequest request) => Proxy.RequestAsync<ListResponse<RoleResponse>>(request);
        public ListResponse<RoleResponse> ListRolesAllPages(ListRolesRequest request) => Proxy.RequestAllPages<RoleResponse>(request);
        public Task<ListResponse<RoleResponse>> ListRolesAllPagesAsync(ListRolesRequest request) => Proxy.RequestAllPagesAsync<RoleResponse>(request);
    }
}
