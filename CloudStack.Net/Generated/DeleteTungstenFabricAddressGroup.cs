using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteTungstenFabricAddressGroupRequest : APIRequest
    {
        public DeleteTungstenFabricAddressGroupRequest() : base("deleteTungstenFabricAddressGroup") {}

        /// <summary>
        /// the uuid of Tungsten-Fabric address group
        /// </summary>
        public string AddressGroupUuid {
            get { return GetParameterValue<string>(nameof(AddressGroupUuid).ToLower()); }
            set { SetParameterValue(nameof(AddressGroupUuid).ToLower(), value); }
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
    /// delete Tungsten-Fabric address group
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeleteTungstenFabricAddressGroup(DeleteTungstenFabricAddressGroupRequest request);
        Task<AsyncJobResponse> DeleteTungstenFabricAddressGroupAsync(DeleteTungstenFabricAddressGroupRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteTungstenFabricAddressGroup(DeleteTungstenFabricAddressGroupRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DeleteTungstenFabricAddressGroupAsync(DeleteTungstenFabricAddressGroupRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}