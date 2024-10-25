using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteTungstenFabricTagTypeRequest : APIRequest
    {
        public DeleteTungstenFabricTagTypeRequest() : base("deleteTungstenFabricTagType") {}

        /// <summary>
        /// the ID of Tungsten-Fabric tag type
        /// </summary>
        public string TagTypeUuid {
            get { return GetParameterValue<string>(nameof(TagTypeUuid).ToLower()); }
            set { SetParameterValue(nameof(TagTypeUuid).ToLower(), value); }
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
    /// delete Tungsten-Fabric tag type
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeleteTungstenFabricTagType(DeleteTungstenFabricTagTypeRequest request);
        Task<AsyncJobResponse> DeleteTungstenFabricTagTypeAsync(DeleteTungstenFabricTagTypeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteTungstenFabricTagType(DeleteTungstenFabricTagTypeRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DeleteTungstenFabricTagTypeAsync(DeleteTungstenFabricTagTypeRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
