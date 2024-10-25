using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class StopRouterRequest : APIRequest
    {
        public StopRouterRequest() : base("stopRouter") {}

        /// <summary>
        /// the ID of the router
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// Force stop the VM (vm is marked as Stopped even when command fails to be send to the backend, otherwise a force poweroff is attempted). To be used if the caller knows the VM is stopped and should be marked as such.
        /// </summary>
        public bool? Forced {
            get { return GetParameterValue<bool?>(nameof(Forced).ToLower()); }
            set { SetParameterValue(nameof(Forced).ToLower(), value); }
        }

    }
    /// <summary>
    /// Stops a router.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse StopRouter(StopRouterRequest request);
        Task<AsyncJobResponse> StopRouterAsync(StopRouterRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse StopRouter(StopRouterRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> StopRouterAsync(StopRouterRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
