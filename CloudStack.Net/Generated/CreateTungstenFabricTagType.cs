using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateTungstenFabricTagTypeRequest : APIRequest
    {
        public CreateTungstenFabricTagTypeRequest() : base("createTungstenFabricTagType") {}

        /// <summary>
        /// Tungsten-Fabric tag type name
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
    /// create Tungsten-Fabric tag type
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse CreateTungstenFabricTagType(CreateTungstenFabricTagTypeRequest request);
        Task<AsyncJobResponse> CreateTungstenFabricTagTypeAsync(CreateTungstenFabricTagTypeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse CreateTungstenFabricTagType(CreateTungstenFabricTagTypeRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> CreateTungstenFabricTagTypeAsync(CreateTungstenFabricTagTypeRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
