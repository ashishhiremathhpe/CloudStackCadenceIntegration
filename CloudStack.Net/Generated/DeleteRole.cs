using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteRoleRequest : APIRequest
    {
        public DeleteRoleRequest() : base("deleteRole") {}

        /// <summary>
        /// ID of the role
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Deletes a role
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteRole(DeleteRoleRequest request);
        Task<SuccessResponse> DeleteRoleAsync(DeleteRoleRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteRole(DeleteRoleRequest request) => Proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> DeleteRoleAsync(DeleteRoleRequest request) => Proxy.RequestAsync<SuccessResponse>(request);
    }
}
