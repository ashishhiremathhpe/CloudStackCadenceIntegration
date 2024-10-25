using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DownloadImageStoreObjectRequest : APIRequest
    {
        public DownloadImageStoreObjectRequest() : base("downloadImageStoreObject") {}

        /// <summary>
        /// id of the image store
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// path to download on image store
        /// </summary>
        public string Path {
            get { return GetParameterValue<string>(nameof(Path).ToLower()); }
            set { SetParameterValue(nameof(Path).ToLower(), value); }
        }

    }
    /// <summary>
    /// Download object at a specified path on an image store.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DownloadImageStoreObject(DownloadImageStoreObjectRequest request);
        Task<AsyncJobResponse> DownloadImageStoreObjectAsync(DownloadImageStoreObjectRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DownloadImageStoreObject(DownloadImageStoreObjectRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DownloadImageStoreObjectAsync(DownloadImageStoreObjectRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
