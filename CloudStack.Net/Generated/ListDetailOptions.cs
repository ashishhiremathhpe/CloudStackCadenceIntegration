using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListDetailOptionsRequest : APIRequest
    {
        public ListDetailOptionsRequest() : base("listDetailOptions") {}

        /// <summary>
        /// the resource type such as UserVm, Template etc.
        /// </summary>
        public string ResourceType {
            get { return GetParameterValue<string>(nameof(ResourceType).ToLower()); }
            set { SetParameterValue(nameof(ResourceType).ToLower(), value); }
        }

        /// <summary>
        /// the UUID of the resource (optional)
        /// </summary>
        public string ResourceId {
            get { return GetParameterValue<string>(nameof(ResourceId).ToLower()); }
            set { SetParameterValue(nameof(ResourceId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists all possible details and their options for a resource type such as a VM or a template
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        DetailOptionsResponse ListDetailOptions(ListDetailOptionsRequest request);
        Task<DetailOptionsResponse> ListDetailOptionsAsync(ListDetailOptionsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public DetailOptionsResponse ListDetailOptions(ListDetailOptionsRequest request) => Proxy.Request<DetailOptionsResponse>(request);
        public Task<DetailOptionsResponse> ListDetailOptionsAsync(ListDetailOptionsRequest request) => Proxy.RequestAsync<DetailOptionsResponse>(request);
    }
}
