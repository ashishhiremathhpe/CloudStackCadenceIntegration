using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class RegisterNetscalerServicePackageRequest : APIRequest
    {
        public RegisterNetscalerServicePackageRequest() : base("registerNetscalerServicePackage") {}

        /// <summary>
        /// Description of Service Package
        /// </summary>
        public string Description {
            get { return GetParameterValue<string>(nameof(Description).ToLower()); }
            set { SetParameterValue(nameof(Description).ToLower(), value); }
        }

        /// <summary>
        /// Name of the service Package.
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

    }
    /// <summary>
    /// Registers NCC Service Package
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        NetScalerServicePackageResponse RegisterNetscalerServicePackage(RegisterNetscalerServicePackageRequest request);
        Task<NetScalerServicePackageResponse> RegisterNetscalerServicePackageAsync(RegisterNetscalerServicePackageRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public NetScalerServicePackageResponse RegisterNetscalerServicePackage(RegisterNetscalerServicePackageRequest request) => Proxy.Request<NetScalerServicePackageResponse>(request);
        public Task<NetScalerServicePackageResponse> RegisterNetscalerServicePackageAsync(RegisterNetscalerServicePackageRequest request) => Proxy.RequestAsync<NetScalerServicePackageResponse>(request);
    }
}
