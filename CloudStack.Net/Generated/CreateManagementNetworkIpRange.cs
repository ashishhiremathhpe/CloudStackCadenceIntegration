using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateManagementNetworkIpRangeRequest : APIRequest
    {
        public CreateManagementNetworkIpRangeRequest() : base("createManagementNetworkIpRange") {}

        /// <summary>
        /// The gateway for the management network.
        /// </summary>
        public string Gateway {
            get { return GetParameterValue<string>(nameof(Gateway).ToLower()); }
            set { SetParameterValue(nameof(Gateway).ToLower(), value); }
        }

        /// <summary>
        /// The netmask for the management network.
        /// </summary>
        public string Netmask {
            get { return GetParameterValue<string>(nameof(Netmask).ToLower()); }
            set { SetParameterValue(nameof(Netmask).ToLower(), value); }
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
        /// The ending IP address.
        /// </summary>
        public string EndIp {
            get { return GetParameterValue<string>(nameof(EndIp).ToLower()); }
            set { SetParameterValue(nameof(EndIp).ToLower(), value); }
        }

        /// <summary>
        /// Specify if range is dedicated for CPVM and SSVM.
        /// </summary>
        public bool? ForSystemVms {
            get { return GetParameterValue<bool?>(nameof(ForSystemVms).ToLower()); }
            set { SetParameterValue(nameof(ForSystemVms).ToLower(), value); }
        }

        /// <summary>
        /// Optional. The vlan id the ip range sits on, default to Null when it is not specified which means your network is not on any Vlan
        /// </summary>
        public string Vlan {
            get { return GetParameterValue<string>(nameof(Vlan).ToLower()); }
            set { SetParameterValue(nameof(Vlan).ToLower(), value); }
        }

    }
    /// <summary>
    /// Creates a Management network IP range.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse CreateManagementNetworkIpRange(CreateManagementNetworkIpRangeRequest request);
        Task<AsyncJobResponse> CreateManagementNetworkIpRangeAsync(CreateManagementNetworkIpRangeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse CreateManagementNetworkIpRange(CreateManagementNetworkIpRangeRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> CreateManagementNetworkIpRangeAsync(CreateManagementNetworkIpRangeRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
