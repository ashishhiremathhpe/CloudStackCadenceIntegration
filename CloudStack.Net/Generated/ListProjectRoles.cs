using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListProjectRolesRequest : APIListRequest
    {
        public ListProjectRolesRequest() : base("listProjectRoles") {}

        /// <summary>
        /// List project role by project ID.
        /// </summary>
        public Guid ProjectId {
            get { return GetParameterValue<Guid>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// List project role by project role name.
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// List project role by project role ID.
        /// </summary>
        public Guid? ProjectRoleId {
            get { return GetParameterValue<Guid?>(nameof(ProjectRoleId).ToLower()); }
            set { SetParameterValue(nameof(ProjectRoleId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists Project roles in CloudStack
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<ProjectRoleResponse> ListProjectRoles(ListProjectRolesRequest request);
        Task<ListResponse<ProjectRoleResponse>> ListProjectRolesAsync(ListProjectRolesRequest request);
        ListResponse<ProjectRoleResponse> ListProjectRolesAllPages(ListProjectRolesRequest request);
        Task<ListResponse<ProjectRoleResponse>> ListProjectRolesAllPagesAsync(ListProjectRolesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<ProjectRoleResponse> ListProjectRoles(ListProjectRolesRequest request) => Proxy.Request<ListResponse<ProjectRoleResponse>>(request);
        public Task<ListResponse<ProjectRoleResponse>> ListProjectRolesAsync(ListProjectRolesRequest request) => Proxy.RequestAsync<ListResponse<ProjectRoleResponse>>(request);
        public ListResponse<ProjectRoleResponse> ListProjectRolesAllPages(ListProjectRolesRequest request) => Proxy.RequestAllPages<ProjectRoleResponse>(request);
        public Task<ListResponse<ProjectRoleResponse>> ListProjectRolesAllPagesAsync(ListProjectRolesRequest request) => Proxy.RequestAllPagesAsync<ProjectRoleResponse>(request);
    }
}
