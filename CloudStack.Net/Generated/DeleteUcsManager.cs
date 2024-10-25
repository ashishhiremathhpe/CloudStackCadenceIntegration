using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteUcsManagerRequest : APIRequest
    {
        public DeleteUcsManagerRequest() : base("deleteUcsManager") {}

        /// <summary>
        /// ucs manager id
        /// </summary>
        public Guid UcsManagerId {
            get { return GetParameterValue<Guid>(nameof(UcsManagerId).ToLower()); }
            set { SetParameterValue(nameof(UcsManagerId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Delete a Ucs manager
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteUcsManager(DeleteUcsManagerRequest request);
        Task<SuccessResponse> DeleteUcsManagerAsync(DeleteUcsManagerRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteUcsManager(DeleteUcsManagerRequest request) => Proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> DeleteUcsManagerAsync(DeleteUcsManagerRequest request) => Proxy.RequestAsync<SuccessResponse>(request);
    }
}
