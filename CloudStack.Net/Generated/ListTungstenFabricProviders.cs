using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListTungstenFabricProvidersRequest : APIListRequest
    {
        public ListTungstenFabricProvidersRequest() : base("listTungstenFabricProviders") {}

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        public Guid? ZoneId {
            get { return GetParameterValue<Guid?>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists Tungsten-Fabric providers
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<TungstenFabricProviderResponse> ListTungstenFabricProviders(ListTungstenFabricProvidersRequest request);
        Task<ListResponse<TungstenFabricProviderResponse>> ListTungstenFabricProvidersAsync(ListTungstenFabricProvidersRequest request);
        ListResponse<TungstenFabricProviderResponse> ListTungstenFabricProvidersAllPages(ListTungstenFabricProvidersRequest request);
        Task<ListResponse<TungstenFabricProviderResponse>> ListTungstenFabricProvidersAllPagesAsync(ListTungstenFabricProvidersRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<TungstenFabricProviderResponse> ListTungstenFabricProviders(ListTungstenFabricProvidersRequest request) => Proxy.Request<ListResponse<TungstenFabricProviderResponse>>(request);
        public Task<ListResponse<TungstenFabricProviderResponse>> ListTungstenFabricProvidersAsync(ListTungstenFabricProvidersRequest request) => Proxy.RequestAsync<ListResponse<TungstenFabricProviderResponse>>(request);
        public ListResponse<TungstenFabricProviderResponse> ListTungstenFabricProvidersAllPages(ListTungstenFabricProvidersRequest request) => Proxy.RequestAllPages<TungstenFabricProviderResponse>(request);
        public Task<ListResponse<TungstenFabricProviderResponse>> ListTungstenFabricProvidersAllPagesAsync(ListTungstenFabricProvidersRequest request) => Proxy.RequestAllPagesAsync<TungstenFabricProviderResponse>(request);
    }
}
