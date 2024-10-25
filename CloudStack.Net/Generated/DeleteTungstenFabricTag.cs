using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteTungstenFabricTagRequest : APIRequest
    {
        public DeleteTungstenFabricTagRequest() : base("deleteTungstenFabricTag") {}

        /// <summary>
        /// the uuid of Tungsten-Fabric tag
        /// </summary>
        public string TagUuid {
            get { return GetParameterValue<string>(nameof(TagUuid).ToLower()); }
            set { SetParameterValue(nameof(TagUuid).ToLower(), value); }
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
    /// delete Tungsten-Fabric tag
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeleteTungstenFabricTag(DeleteTungstenFabricTagRequest request);
        Task<AsyncJobResponse> DeleteTungstenFabricTagAsync(DeleteTungstenFabricTagRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteTungstenFabricTag(DeleteTungstenFabricTagRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DeleteTungstenFabricTagAsync(DeleteTungstenFabricTagRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
