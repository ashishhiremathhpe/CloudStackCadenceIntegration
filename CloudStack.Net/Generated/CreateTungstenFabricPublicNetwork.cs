using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateTungstenFabricPublicNetworkRequest : APIRequest
    {
        public CreateTungstenFabricPublicNetworkRequest() : base("createTungstenFabricPublicNetwork") {}

        /// <summary>
        /// the ID of zone
        /// </summary>
        public Guid ZoneId {
            get { return GetParameterValue<Guid>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

    }
    /// <summary>
    /// create Tungsten-Fabric public network
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse CreateTungstenFabricPublicNetwork(CreateTungstenFabricPublicNetworkRequest request);
        Task<SuccessResponse> CreateTungstenFabricPublicNetworkAsync(CreateTungstenFabricPublicNetworkRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse CreateTungstenFabricPublicNetwork(CreateTungstenFabricPublicNetworkRequest request) => Proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> CreateTungstenFabricPublicNetworkAsync(CreateTungstenFabricPublicNetworkRequest request) => Proxy.RequestAsync<SuccessResponse>(request);
    }
}
