using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteTungstenFabricServiceGroupRequest : APIRequest
    {
        public DeleteTungstenFabricServiceGroupRequest() : base("deleteTungstenFabricServiceGroup") {}

        /// <summary>
        /// the uuid of Tungsten-Fabric service group
        /// </summary>
        public string ServiceGroupUuid {
            get { return GetParameterValue<string>(nameof(ServiceGroupUuid).ToLower()); }
            set { SetParameterValue(nameof(ServiceGroupUuid).ToLower(), value); }
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
    /// delete Tungsten-Fabric service group
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeleteTungstenFabricServiceGroup(DeleteTungstenFabricServiceGroupRequest request);
        Task<AsyncJobResponse> DeleteTungstenFabricServiceGroupAsync(DeleteTungstenFabricServiceGroupRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteTungstenFabricServiceGroup(DeleteTungstenFabricServiceGroupRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DeleteTungstenFabricServiceGroupAsync(DeleteTungstenFabricServiceGroupRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
