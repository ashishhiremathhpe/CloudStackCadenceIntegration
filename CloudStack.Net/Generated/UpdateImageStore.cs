using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateImageStoreRequest : APIRequest
    {
        public UpdateImageStoreRequest() : base("updateImageStore") {}

        /// <summary>
        /// Image Store UUID
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// If set to true, it designates the corresponding image store to read-only, hence not considering them during storage migration
        /// </summary>
        public bool Readonly {
            get { return GetParameterValue<bool>(nameof(Readonly).ToLower()); }
            set { SetParameterValue(nameof(Readonly).ToLower(), value); }
        }

    }
    /// <summary>
    /// Updates image store read-only status
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ImageStoreResponse UpdateImageStore(UpdateImageStoreRequest request);
        Task<ImageStoreResponse> UpdateImageStoreAsync(UpdateImageStoreRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ImageStoreResponse UpdateImageStore(UpdateImageStoreRequest request) => Proxy.Request<ImageStoreResponse>(request);
        public Task<ImageStoreResponse> UpdateImageStoreAsync(UpdateImageStoreRequest request) => Proxy.RequestAsync<ImageStoreResponse>(request);
    }
}
