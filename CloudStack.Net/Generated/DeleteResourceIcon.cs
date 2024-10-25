using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteResourceIconRequest : APIRequest
    {
        public DeleteResourceIconRequest() : base("deleteResourceIcon") {}

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
    /// deletes the resource icon from the specified resource(s)
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteResourceIcon(DeleteResourceIconRequest request);
        Task<SuccessResponse> DeleteResourceIconAsync(DeleteResourceIconRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteResourceIcon(DeleteResourceIconRequest request) => Proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> DeleteResourceIconAsync(DeleteResourceIconRequest request) => Proxy.RequestAsync<SuccessResponse>(request);
    }
}
