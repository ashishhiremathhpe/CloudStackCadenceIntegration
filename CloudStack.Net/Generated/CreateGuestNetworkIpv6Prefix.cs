using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateGuestNetworkIpv6PrefixRequest : APIRequest
    {
        public CreateGuestNetworkIpv6PrefixRequest() : base("createGuestNetworkIpv6Prefix") {}

        /// <summary>
        /// The /56 or higher IPv6 CIDR for network prefix.
        /// </summary>
        public string Prefix {
            get { return GetParameterValue<string>(nameof(Prefix).ToLower()); }
            set { SetParameterValue(nameof(Prefix).ToLower(), value); }
        }

        /// <summary>
        /// UUID of zone to which the IPv6 prefix belongs to.
        /// </summary>
        public Guid ZoneId {
            get { return GetParameterValue<Guid>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Creates a guest network IPv6 prefix.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse CreateGuestNetworkIpv6Prefix(CreateGuestNetworkIpv6PrefixRequest request);
        Task<AsyncJobResponse> CreateGuestNetworkIpv6PrefixAsync(CreateGuestNetworkIpv6PrefixRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse CreateGuestNetworkIpv6Prefix(CreateGuestNetworkIpv6PrefixRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> CreateGuestNetworkIpv6PrefixAsync(CreateGuestNetworkIpv6PrefixRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
