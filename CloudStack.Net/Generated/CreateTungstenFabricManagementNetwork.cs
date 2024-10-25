using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateTungstenFabricManagementNetworkRequest : APIRequest
    {
        public CreateTungstenFabricManagementNetworkRequest() : base("createTungstenFabricManagementNetwork") {}

        /// <summary>
        /// the ID of pod
        /// </summary>
        public Guid PodId {
            get { return GetParameterValue<Guid>(nameof(PodId).ToLower()); }
            set { SetParameterValue(nameof(PodId).ToLower(), value); }
        }

    }
    /// <summary>
    /// create Tungsten-Fabric management network
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse CreateTungstenFabricManagementNetwork(CreateTungstenFabricManagementNetworkRequest request);
        Task<SuccessResponse> CreateTungstenFabricManagementNetworkAsync(CreateTungstenFabricManagementNetworkRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse CreateTungstenFabricManagementNetwork(CreateTungstenFabricManagementNetworkRequest request) => Proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> CreateTungstenFabricManagementNetworkAsync(CreateTungstenFabricManagementNetworkRequest request) => Proxy.RequestAsync<SuccessResponse>(request);
    }
}
