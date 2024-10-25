using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ConfigTungstenFabricServiceRequest : APIRequest
    {
        public ConfigTungstenFabricServiceRequest() : base("configTungstenFabricService") {}

        /// <summary>
        /// the ID of physical network
        /// </summary>
        public Guid PhysicalNetworkId {
            get { return GetParameterValue<Guid>(nameof(PhysicalNetworkId).ToLower()); }
            set { SetParameterValue(nameof(PhysicalNetworkId).ToLower(), value); }
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
    /// config Tungsten-Fabric service
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse ConfigTungstenFabricService(ConfigTungstenFabricServiceRequest request);
        Task<SuccessResponse> ConfigTungstenFabricServiceAsync(ConfigTungstenFabricServiceRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse ConfigTungstenFabricService(ConfigTungstenFabricServiceRequest request) => Proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> ConfigTungstenFabricServiceAsync(ConfigTungstenFabricServiceRequest request) => Proxy.RequestAsync<SuccessResponse>(request);
    }
}
