using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AcquirePodIpAddressRequest : APIRequest
    {
        public AcquirePodIpAddressRequest() : base("acquirePodIpAddress") {}

        /// <summary>
        /// the ID of the zone
        /// </summary>
        public string ZoneId {
            get { return GetParameterValue<string>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

        /// <summary>
        /// Pod ID
        /// </summary>
        public string PodId {
            get { return GetParameterValue<string>(nameof(PodId).ToLower()); }
            set { SetParameterValue(nameof(PodId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Allocates IP addresses in respective Pod of a Zone
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AcquirePodIpCmdResponse AcquirePodIpAddress(AcquirePodIpAddressRequest request);
        Task<AcquirePodIpCmdResponse> AcquirePodIpAddressAsync(AcquirePodIpAddressRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AcquirePodIpCmdResponse AcquirePodIpAddress(AcquirePodIpAddressRequest request) => Proxy.Request<AcquirePodIpCmdResponse>(request);
        public Task<AcquirePodIpCmdResponse> AcquirePodIpAddressAsync(AcquirePodIpAddressRequest request) => Proxy.RequestAsync<AcquirePodIpCmdResponse>(request);
    }
}
