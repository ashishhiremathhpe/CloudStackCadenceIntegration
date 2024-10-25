using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdatePodManagementNetworkIpRangeRequest : APIRequest
    {
        public UpdatePodManagementNetworkIpRangeRequest() : base("updatePodManagementNetworkIpRange") {}

        /// <summary>
        /// The current ending IP address.
        /// </summary>
        public string CurrentEndIp {
            get { return GetParameterValue<string>(nameof(CurrentEndIp).ToLower()); }
            set { SetParameterValue(nameof(CurrentEndIp).ToLower(), value); }
        }

        /// <summary>
        /// The current starting IP address.
        /// </summary>
        public string CurrentStartIp {
            get { return GetParameterValue<string>(nameof(CurrentStartIp).ToLower()); }
            set { SetParameterValue(nameof(CurrentStartIp).ToLower(), value); }
        }

        /// <summary>
        /// UUID of POD, where the IP range belongs to.
        /// </summary>
        public Guid PodId {
            get { return GetParameterValue<Guid>(nameof(PodId).ToLower()); }
            set { SetParameterValue(nameof(PodId).ToLower(), value); }
        }

        /// <summary>
        /// The new ending IP address.
        /// </summary>
        public string NewEndIp {
            get { return GetParameterValue<string>(nameof(NewEndIp).ToLower()); }
            set { SetParameterValue(nameof(NewEndIp).ToLower(), value); }
        }

        /// <summary>
        /// The new starting IP address.
        /// </summary>
        public string NewStartIp {
            get { return GetParameterValue<string>(nameof(NewStartIp).ToLower()); }
            set { SetParameterValue(nameof(NewStartIp).ToLower(), value); }
        }

    }
    /// <summary>
    /// Updates a management network IP range. Only allowed when no IPs are allocated.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse UpdatePodManagementNetworkIpRange(UpdatePodManagementNetworkIpRangeRequest request);
        Task<AsyncJobResponse> UpdatePodManagementNetworkIpRangeAsync(UpdatePodManagementNetworkIpRangeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse UpdatePodManagementNetworkIpRange(UpdatePodManagementNetworkIpRangeRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> UpdatePodManagementNetworkIpRangeAsync(UpdatePodManagementNetworkIpRangeRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
