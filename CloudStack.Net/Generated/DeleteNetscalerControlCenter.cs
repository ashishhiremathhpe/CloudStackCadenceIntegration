using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteNetscalerControlCenterRequest : APIRequest
    {
        public DeleteNetscalerControlCenterRequest() : base("deleteNetscalerControlCenter") {}

        /// <summary>
        /// Netscaler Control Center ID
        /// </summary>
        public string ID {
            get { return GetParameterValue<string>(nameof(ID).ToLower()); }
            set { SetParameterValue(nameof(ID).ToLower(), value); }
        }

    }
    /// <summary>
    /// Delete Netscaler Control Center
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteNetscalerControlCenter(DeleteNetscalerControlCenterRequest request);
        Task<SuccessResponse> DeleteNetscalerControlCenterAsync(DeleteNetscalerControlCenterRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteNetscalerControlCenter(DeleteNetscalerControlCenterRequest request) => Proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> DeleteNetscalerControlCenterAsync(DeleteNetscalerControlCenterRequest request) => Proxy.RequestAsync<SuccessResponse>(request);
    }
}
