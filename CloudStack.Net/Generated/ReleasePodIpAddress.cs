using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ReleasePodIpAddressRequest : APIRequest
    {
        public ReleasePodIpAddressRequest() : base("releasePodIpAddress") {}

        /// <summary>
        /// UUID of the Pod IP
        /// </summary>
        public long Id {
            get { return GetParameterValue<long>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Releases a Pod IP back to the Pod
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse ReleasePodIpAddress(ReleasePodIpAddressRequest request);
        Task<SuccessResponse> ReleasePodIpAddressAsync(ReleasePodIpAddressRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse ReleasePodIpAddress(ReleasePodIpAddressRequest request) => Proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> ReleasePodIpAddressAsync(ReleasePodIpAddressRequest request) => Proxy.RequestAsync<SuccessResponse>(request);
    }
}
