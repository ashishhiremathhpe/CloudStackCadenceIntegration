using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateTungstenFabricLogicalRouterRequest : APIRequest
    {
        public CreateTungstenFabricLogicalRouterRequest() : base("createTungstenFabricLogicalRouter") {}

        /// <summary>
        /// Tungsten-Fabric logical router name
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// the ID of zone
        /// </summary>
        public Guid ZoneId {
            get { return GetParameterValue<Guid>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

    }
    /// <summary>
    /// create Tungsten-Fabric logical router
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse CreateTungstenFabricLogicalRouter(CreateTungstenFabricLogicalRouterRequest request);
        Task<AsyncJobResponse> CreateTungstenFabricLogicalRouterAsync(CreateTungstenFabricLogicalRouterRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse CreateTungstenFabricLogicalRouter(CreateTungstenFabricLogicalRouterRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> CreateTungstenFabricLogicalRouterAsync(CreateTungstenFabricLogicalRouterRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
