using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteGuestNetworkIpv6PrefixRequest : APIRequest
    {
        public DeleteGuestNetworkIpv6PrefixRequest() : base("deleteGuestNetworkIpv6Prefix") {}

        /// <summary>
        /// Id of the guest network IPv6 prefix
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Deletes an existing guest network IPv6 prefix.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeleteGuestNetworkIpv6Prefix(DeleteGuestNetworkIpv6PrefixRequest request);
        Task<AsyncJobResponse> DeleteGuestNetworkIpv6PrefixAsync(DeleteGuestNetworkIpv6PrefixRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteGuestNetworkIpv6Prefix(DeleteGuestNetworkIpv6PrefixRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DeleteGuestNetworkIpv6PrefixAsync(DeleteGuestNetworkIpv6PrefixRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
