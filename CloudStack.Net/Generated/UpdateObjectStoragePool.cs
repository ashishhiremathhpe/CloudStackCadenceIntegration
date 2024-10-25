using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateObjectStoragePoolRequest : APIRequest
    {
        public UpdateObjectStoragePoolRequest() : base("updateObjectStoragePool") {}

        /// <summary>
        /// Object Store ID
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// the name for the object store
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// the url for the object store
        /// </summary>
        public string Url {
            get { return GetParameterValue<string>(nameof(Url).ToLower()); }
            set { SetParameterValue(nameof(Url).ToLower(), value); }
        }

    }
    /// <summary>
    /// Updates object storage pool
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ObjectStoreResponse UpdateObjectStoragePool(UpdateObjectStoragePoolRequest request);
        Task<ObjectStoreResponse> UpdateObjectStoragePoolAsync(UpdateObjectStoragePoolRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ObjectStoreResponse UpdateObjectStoragePool(UpdateObjectStoragePoolRequest request) => Proxy.Request<ObjectStoreResponse>(request);
        public Task<ObjectStoreResponse> UpdateObjectStoragePoolAsync(UpdateObjectStoragePoolRequest request) => Proxy.RequestAsync<ObjectStoreResponse>(request);
    }
}
