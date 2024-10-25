using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateTungstenFabricServiceGroupRequest : APIRequest
    {
        public CreateTungstenFabricServiceGroupRequest() : base("createTungstenFabricServiceGroup") {}

        /// <summary>
        /// Tungsten-Fabric service group end port
        /// </summary>
        public int? EndPort {
            get { return GetParameterValue<int?>(nameof(EndPort).ToLower()); }
            set { SetParameterValue(nameof(EndPort).ToLower(), value); }
        }

        /// <summary>
        /// Tungsten-Fabric service group name
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// Tungsten-Fabric service group protocol
        /// </summary>
        public string Protocol {
            get { return GetParameterValue<string>(nameof(Protocol).ToLower()); }
            set { SetParameterValue(nameof(Protocol).ToLower(), value); }
        }

        /// <summary>
        /// Tungsten-Fabric service group start port
        /// </summary>
        public int? StartPort {
            get { return GetParameterValue<int?>(nameof(StartPort).ToLower()); }
            set { SetParameterValue(nameof(StartPort).ToLower(), value); }
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
    /// create Tungsten-Fabric service group
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse CreateTungstenFabricServiceGroup(CreateTungstenFabricServiceGroupRequest request);
        Task<AsyncJobResponse> CreateTungstenFabricServiceGroupAsync(CreateTungstenFabricServiceGroupRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse CreateTungstenFabricServiceGroup(CreateTungstenFabricServiceGroupRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> CreateTungstenFabricServiceGroupAsync(CreateTungstenFabricServiceGroupRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
