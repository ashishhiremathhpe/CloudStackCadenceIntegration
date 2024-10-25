using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListCAProvidersRequest : APIRequest
    {
        public ListCAProvidersRequest() : base("listCAProviders") {}

        /// <summary>
        /// List CA service provider by name
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists available certificate authority providers in CloudStack
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        CAProviderResponse ListCAProviders(ListCAProvidersRequest request);
        Task<CAProviderResponse> ListCAProvidersAsync(ListCAProvidersRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public CAProviderResponse ListCAProviders(ListCAProvidersRequest request) => Proxy.Request<CAProviderResponse>(request);
        public Task<CAProviderResponse> ListCAProvidersAsync(ListCAProvidersRequest request) => Proxy.RequestAsync<CAProviderResponse>(request);
    }
}
