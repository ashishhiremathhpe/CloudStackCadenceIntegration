using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListResourceIconRequest : APIRequest
    {
        public ListResourceIconRequest() : base("listResourceIcon") {}

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
    /// Lists the resource icon for the specified resource(s)
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ResourceIconResponse ListResourceIcon(ListResourceIconRequest request);
        Task<ResourceIconResponse> ListResourceIconAsync(ListResourceIconRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ResourceIconResponse ListResourceIcon(ListResourceIconRequest request) => Proxy.Request<ResourceIconResponse>(request);
        public Task<ResourceIconResponse> ListResourceIconAsync(ListResourceIconRequest request) => Proxy.RequestAsync<ResourceIconResponse>(request);
    }
}
