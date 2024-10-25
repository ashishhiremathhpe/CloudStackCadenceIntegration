using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateStorageCapabilitiesRequest : APIRequest
    {
        public UpdateStorageCapabilitiesRequest() : base("updateStorageCapabilities") {}

        /// <summary>
        /// Storage pool id
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Syncs capabilities of storage pools
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        StoragePoolResponse UpdateStorageCapabilities(UpdateStorageCapabilitiesRequest request);
        Task<StoragePoolResponse> UpdateStorageCapabilitiesAsync(UpdateStorageCapabilitiesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public StoragePoolResponse UpdateStorageCapabilities(UpdateStorageCapabilitiesRequest request) => Proxy.Request<StoragePoolResponse>(request);
        public Task<StoragePoolResponse> UpdateStorageCapabilitiesAsync(UpdateStorageCapabilitiesRequest request) => Proxy.RequestAsync<StoragePoolResponse>(request);
    }
}
