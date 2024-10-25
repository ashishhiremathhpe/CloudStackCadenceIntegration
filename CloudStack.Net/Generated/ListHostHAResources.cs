using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListHostHAResourcesRequest : APIRequest
    {
        public ListHostHAResourcesRequest() : base("listHostHAResources") {}

        /// <summary>
        /// List by host ID
        /// </summary>
        public Guid? HostId {
            get { return GetParameterValue<Guid?>(nameof(HostId).ToLower()); }
            set { SetParameterValue(nameof(HostId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists host HA resources
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        HostHAResponse ListHostHAResources(ListHostHAResourcesRequest request);
        Task<HostHAResponse> ListHostHAResourcesAsync(ListHostHAResourcesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public HostHAResponse ListHostHAResources(ListHostHAResourcesRequest request) => Proxy.Request<HostHAResponse>(request);
        public Task<HostHAResponse> ListHostHAResourcesAsync(ListHostHAResourcesRequest request) => Proxy.RequestAsync<HostHAResponse>(request);
    }
}
