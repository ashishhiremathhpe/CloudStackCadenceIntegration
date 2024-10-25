using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListHostHAProvidersRequest : APIRequest
    {
        public ListHostHAProvidersRequest() : base("listHostHAProviders") {}

        /// <summary>
        /// Hypervisor type of the resource
        /// </summary>
        public string Hypervisor {
            get { return GetParameterValue<string>(nameof(Hypervisor).ToLower()); }
            set { SetParameterValue(nameof(Hypervisor).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists HA providers
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        HostHAResponse ListHostHAProviders(ListHostHAProvidersRequest request);
        Task<HostHAResponse> ListHostHAProvidersAsync(ListHostHAProvidersRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public HostHAResponse ListHostHAProviders(ListHostHAProvidersRequest request) => Proxy.Request<HostHAResponse>(request);
        public Task<HostHAResponse> ListHostHAProvidersAsync(ListHostHAProvidersRequest request) => Proxy.RequestAsync<HostHAResponse>(request);
    }
}
