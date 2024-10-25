using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListImageStoreObjectsRequest : APIListRequest
    {
        public ListImageStoreObjectsRequest() : base("listImageStoreObjects") {}

        /// <summary>
        /// id of the image store
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
        /// path to list on image store
        /// </summary>
        public string Path {
            get { return GetParameterValue<string>(nameof(Path).ToLower()); }
            set { SetParameterValue(nameof(Path).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists objects at specified path on an image store.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<DataStoreObjectResponse> ListImageStoreObjects(ListImageStoreObjectsRequest request);
        Task<ListResponse<DataStoreObjectResponse>> ListImageStoreObjectsAsync(ListImageStoreObjectsRequest request);
        ListResponse<DataStoreObjectResponse> ListImageStoreObjectsAllPages(ListImageStoreObjectsRequest request);
        Task<ListResponse<DataStoreObjectResponse>> ListImageStoreObjectsAllPagesAsync(ListImageStoreObjectsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<DataStoreObjectResponse> ListImageStoreObjects(ListImageStoreObjectsRequest request) => Proxy.Request<ListResponse<DataStoreObjectResponse>>(request);
        public Task<ListResponse<DataStoreObjectResponse>> ListImageStoreObjectsAsync(ListImageStoreObjectsRequest request) => Proxy.RequestAsync<ListResponse<DataStoreObjectResponse>>(request);
        public ListResponse<DataStoreObjectResponse> ListImageStoreObjectsAllPages(ListImageStoreObjectsRequest request) => Proxy.RequestAllPages<DataStoreObjectResponse>(request);
        public Task<ListResponse<DataStoreObjectResponse>> ListImageStoreObjectsAllPagesAsync(ListImageStoreObjectsRequest request) => Proxy.RequestAllPagesAsync<DataStoreObjectResponse>(request);
    }
}
