using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteServicePackageOfferingRequest : APIRequest
    {
        public DeleteServicePackageOfferingRequest() : base("deleteServicePackageOffering") {}

        /// <summary>
        /// the service offering ID
        /// </summary>
        public string ID {
            get { return GetParameterValue<string>(nameof(ID).ToLower()); }
            set { SetParameterValue(nameof(ID).ToLower(), value); }
        }

    }
    /// <summary>
    /// Delete Service Package
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteServicePackageOffering(DeleteServicePackageOfferingRequest request);
        Task<SuccessResponse> DeleteServicePackageOfferingAsync(DeleteServicePackageOfferingRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteServicePackageOffering(DeleteServicePackageOfferingRequest request) => Proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> DeleteServicePackageOfferingAsync(DeleteServicePackageOfferingRequest request) => Proxy.RequestAsync<SuccessResponse>(request);
    }
}
