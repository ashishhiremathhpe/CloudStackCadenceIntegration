using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListStoragePoolObjectsRequest : APIListRequest
    {
        public ListStoragePoolObjectsRequest() : base("listStoragePoolObjects") {}

        /// <summary>
        /// id of the storage pool
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
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
        /// path to list on storage pool
        /// </summary>
        public string Path {
            get { return GetParameterValue<string>(nameof(Path).ToLower()); }
            set { SetParameterValue(nameof(Path).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists objects at specified path on a storage pool.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<DataStoreObjectResponse> ListStoragePoolObjects(ListStoragePoolObjectsRequest request);
        Task<ListResponse<DataStoreObjectResponse>> ListStoragePoolObjectsAsync(ListStoragePoolObjectsRequest request);
        ListResponse<DataStoreObjectResponse> ListStoragePoolObjectsAllPages(ListStoragePoolObjectsRequest request);
        Task<ListResponse<DataStoreObjectResponse>> ListStoragePoolObjectsAllPagesAsync(ListStoragePoolObjectsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<DataStoreObjectResponse> ListStoragePoolObjects(ListStoragePoolObjectsRequest request) => Proxy.Request<ListResponse<DataStoreObjectResponse>>(request);
        public Task<ListResponse<DataStoreObjectResponse>> ListStoragePoolObjectsAsync(ListStoragePoolObjectsRequest request) => Proxy.RequestAsync<ListResponse<DataStoreObjectResponse>>(request);
        public ListResponse<DataStoreObjectResponse> ListStoragePoolObjectsAllPages(ListStoragePoolObjectsRequest request) => Proxy.RequestAllPages<DataStoreObjectResponse>(request);
        public Task<ListResponse<DataStoreObjectResponse>> ListStoragePoolObjectsAllPagesAsync(ListStoragePoolObjectsRequest request) => Proxy.RequestAllPagesAsync<DataStoreObjectResponse>(request);
    }
}
