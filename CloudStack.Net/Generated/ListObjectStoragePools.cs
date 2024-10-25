using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListObjectStoragePoolsRequest : APIListRequest
    {
        public ListObjectStoragePoolsRequest() : base("listObjectStoragePools") {}

        /// <summary>
        /// the ID of the storage pool
        /// </summary>
        public Guid? Id {
            get { return GetParameterValue<Guid?>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// the name of the object store
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// the object store provider
        /// </summary>
        public string Provider {
            get { return GetParameterValue<string>(nameof(Provider).ToLower()); }
            set { SetParameterValue(nameof(Provider).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists object storage pools.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<ObjectStoreResponse> ListObjectStoragePools(ListObjectStoragePoolsRequest request);
        Task<ListResponse<ObjectStoreResponse>> ListObjectStoragePoolsAsync(ListObjectStoragePoolsRequest request);
        ListResponse<ObjectStoreResponse> ListObjectStoragePoolsAllPages(ListObjectStoragePoolsRequest request);
        Task<ListResponse<ObjectStoreResponse>> ListObjectStoragePoolsAllPagesAsync(ListObjectStoragePoolsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<ObjectStoreResponse> ListObjectStoragePools(ListObjectStoragePoolsRequest request) => Proxy.Request<ListResponse<ObjectStoreResponse>>(request);
        public Task<ListResponse<ObjectStoreResponse>> ListObjectStoragePoolsAsync(ListObjectStoragePoolsRequest request) => Proxy.RequestAsync<ListResponse<ObjectStoreResponse>>(request);
        public ListResponse<ObjectStoreResponse> ListObjectStoragePoolsAllPages(ListObjectStoragePoolsRequest request) => Proxy.RequestAllPages<ObjectStoreResponse>(request);
        public Task<ListResponse<ObjectStoreResponse>> ListObjectStoragePoolsAllPagesAsync(ListObjectStoragePoolsRequest request) => Proxy.RequestAllPagesAsync<ObjectStoreResponse>(request);
    }
}
