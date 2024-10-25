using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteManagementNetworkIpRangeRequest : APIRequest
    {
        public DeleteManagementNetworkIpRangeRequest() : base("deleteManagementNetworkIpRange") {}

        /// <summary>
        /// The ending IP address.
        /// </summary>
        public string EndIp {
            get { return GetParameterValue<string>(nameof(EndIp).ToLower()); }
            set { SetParameterValue(nameof(EndIp).ToLower(), value); }
        }

        /// <summary>
        /// UUID of POD, where the IP range belongs to.
        /// </summary>
        public Guid PodId {
            get { return GetParameterValue<Guid>(nameof(PodId).ToLower()); }
            set { SetParameterValue(nameof(PodId).ToLower(), value); }
        }

        /// <summary>
        /// The starting IP address.
        /// </summary>
        public string StartIp {
            get { return GetParameterValue<string>(nameof(StartIp).ToLower()); }
            set { SetParameterValue(nameof(StartIp).ToLower(), value); }
        }

        /// <summary>
        /// The vlan id the ip range sits on
        /// </summary>
        public string Vlan {
            get { return GetParameterValue<string>(nameof(Vlan).ToLower()); }
            set { SetParameterValue(nameof(Vlan).ToLower(), value); }
        }

    }
    /// <summary>
    /// Deletes a management network IP range. This action is only allowed when no IPs in this range are allocated.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeleteManagementNetworkIpRange(DeleteManagementNetworkIpRangeRequest request);
        Task<AsyncJobResponse> DeleteManagementNetworkIpRangeAsync(DeleteManagementNetworkIpRangeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteManagementNetworkIpRange(DeleteManagementNetworkIpRangeRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DeleteManagementNetworkIpRangeAsync(DeleteManagementNetworkIpRangeRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
