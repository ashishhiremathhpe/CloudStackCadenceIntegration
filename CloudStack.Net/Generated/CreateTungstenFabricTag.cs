using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateTungstenFabricTagRequest : APIRequest
    {
        public CreateTungstenFabricTagRequest() : base("createTungstenFabricTag") {}

        /// <summary>
        /// Tungsten-Fabric tag type
        /// </summary>
        public string TagType {
            get { return GetParameterValue<string>(nameof(TagType).ToLower()); }
            set { SetParameterValue(nameof(TagType).ToLower(), value); }
        }

        /// <summary>
        /// Tungsten-Fabric tag value
        /// </summary>
        public string TagValue {
            get { return GetParameterValue<string>(nameof(TagValue).ToLower()); }
            set { SetParameterValue(nameof(TagValue).ToLower(), value); }
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
    /// create Tungsten-Fabric tag
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse CreateTungstenFabricTag(CreateTungstenFabricTagRequest request);
        Task<AsyncJobResponse> CreateTungstenFabricTagAsync(CreateTungstenFabricTagRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse CreateTungstenFabricTag(CreateTungstenFabricTagRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> CreateTungstenFabricTagAsync(CreateTungstenFabricTagRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
