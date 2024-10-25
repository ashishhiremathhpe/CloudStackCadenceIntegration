using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ReleaseIpAddressRequest : APIRequest
    {
        public ReleaseIpAddressRequest() : base("releaseIpAddress") {}

        /// <summary>
        /// the ID of the public IP address to release
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Releases an IP address from the account.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse ReleaseIpAddress(ReleaseIpAddressRequest request);
        Task<SuccessResponse> ReleaseIpAddressAsync(ReleaseIpAddressRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse ReleaseIpAddress(ReleaseIpAddressRequest request) => Proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> ReleaseIpAddressAsync(ReleaseIpAddressRequest request) => Proxy.RequestAsync<SuccessResponse>(request);
    }
}
