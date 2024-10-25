using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class RestartNetworkRequest : APIRequest
    {
        public RestartNetworkRequest() : base("restartNetwork") {}

        /// <summary>
        /// The ID of the network to restart.
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// If cleanup old network elements
        /// </summary>
        public bool? Cleanup {
            get { return GetParameterValue<bool?>(nameof(Cleanup).ToLower()); }
            set { SetParameterValue(nameof(Cleanup).ToLower(), value); }
        }

        /// <summary>
        /// Live patches the router software before restarting it. This parameter will only work when 'cleanup' is false.
        /// </summary>
        public bool? LivePatch {
            get { return GetParameterValue<bool?>(nameof(LivePatch).ToLower()); }
            set { SetParameterValue(nameof(LivePatch).ToLower(), value); }
        }

        /// <summary>
        /// Turn the network into a network with redundant routers.
        /// </summary>
        public bool? MakeRedundant {
            get { return GetParameterValue<bool?>(nameof(MakeRedundant).ToLower()); }
            set { SetParameterValue(nameof(MakeRedundant).ToLower(), value); }
        }

    }
    /// <summary>
    /// Restarts the network; includes 1) restarting network elements - virtual routers, DHCP servers 2) reapplying all public IPs 3) reapplying loadBalancing/portForwarding rules
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse RestartNetwork(RestartNetworkRequest request);
        Task<AsyncJobResponse> RestartNetworkAsync(RestartNetworkRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse RestartNetwork(RestartNetworkRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> RestartNetworkAsync(RestartNetworkRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
