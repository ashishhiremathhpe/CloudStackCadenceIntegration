using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteStratosphereSspRequest : APIRequest
    {
        public DeleteStratosphereSspRequest() : base("deleteStratosphereSsp") {}

        /// <summary>
        /// the host ID of ssp server
        /// </summary>
        public Guid HostId {
            get { return GetParameterValue<Guid>(nameof(HostId).ToLower()); }
            set { SetParameterValue(nameof(HostId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Removes stratosphere ssp server
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteStratosphereSsp(DeleteStratosphereSspRequest request);
        Task<SuccessResponse> DeleteStratosphereSspAsync(DeleteStratosphereSspRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteStratosphereSsp(DeleteStratosphereSspRequest request) => Proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> DeleteStratosphereSspAsync(DeleteStratosphereSspRequest request) => Proxy.RequestAsync<SuccessResponse>(request);
    }
}
