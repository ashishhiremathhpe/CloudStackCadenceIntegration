using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AddObjectStoragePoolRequest : APIRequest
    {
        public AddObjectStoragePoolRequest() : base("addObjectStoragePool") {}

        /// <summary>
        /// the name for the object store
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// the object store provider name
        /// </summary>
        public string Provider {
            get { return GetParameterValue<string>(nameof(Provider).ToLower()); }
            set { SetParameterValue(nameof(Provider).ToLower(), value); }
        }

        /// <summary>
        /// the URL for the object store
        /// </summary>
        public string Url {
            get { return GetParameterValue<string>(nameof(Url).ToLower()); }
            set { SetParameterValue(nameof(Url).ToLower(), value); }
        }

        /// <summary>
        /// the details for the object store. Example: details[0].key=accesskey&details[0].value=s389ddssaa&details[1].key=secretkey&details[1].value=8dshfsss
        /// </summary>
        public IList<IDictionary<string, object>> Details {
            get { return GetList<IDictionary<string, object>>(nameof(Details).ToLower()); }
            set { SetParameterValue(nameof(Details).ToLower(), value); }
        }

        /// <summary>
        /// the tags for the storage pool
        /// </summary>
        public string Tags {
            get { return GetParameterValue<string>(nameof(Tags).ToLower()); }
            set { SetParameterValue(nameof(Tags).ToLower(), value); }
        }

    }
    /// <summary>
    /// Adds a object storage pool
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ObjectStoreResponse AddObjectStoragePool(AddObjectStoragePoolRequest request);
        Task<ObjectStoreResponse> AddObjectStoragePoolAsync(AddObjectStoragePoolRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ObjectStoreResponse AddObjectStoragePool(AddObjectStoragePoolRequest request) => Proxy.Request<ObjectStoreResponse>(request);
        public Task<ObjectStoreResponse> AddObjectStoragePoolAsync(AddObjectStoragePoolRequest request) => Proxy.RequestAsync<ObjectStoreResponse>(request);
    }
}
