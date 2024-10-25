using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UploadResourceIconRequest : APIRequest
    {
        public UploadResourceIconRequest() : base("uploadResourceIcon") {}

        /// <summary>
        /// Base64 string representation of the resource icon/image
        /// </summary>
        public string Base64image {
            get { return GetParameterValue<string>(nameof(Base64image).ToLower()); }
            set { SetParameterValue(nameof(Base64image).ToLower(), value); }
        }

        /// <summary>
        /// list of resources to upload the icon/image for
        /// </summary>
        public IList<string> ResourceIds {
            get { return GetList<string>(nameof(ResourceIds).ToLower()); }
            set { SetParameterValue(nameof(ResourceIds).ToLower(), value); }
        }

        /// <summary>
        /// type of the resource
        /// </summary>
        public string ResourceType {
            get { return GetParameterValue<string>(nameof(ResourceType).ToLower()); }
            set { SetParameterValue(nameof(ResourceType).ToLower(), value); }
        }

    }
    /// <summary>
    /// Uploads an icon for the specified resource(s)
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse UploadResourceIcon(UploadResourceIconRequest request);
        Task<SuccessResponse> UploadResourceIconAsync(UploadResourceIconRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse UploadResourceIcon(UploadResourceIconRequest request) => Proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> UploadResourceIconAsync(UploadResourceIconRequest request) => Proxy.RequestAsync<SuccessResponse>(request);
    }
}
