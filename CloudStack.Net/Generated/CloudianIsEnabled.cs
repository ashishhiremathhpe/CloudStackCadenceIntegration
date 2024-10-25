using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CloudianIsEnabledRequest : APIRequest
    {
        public CloudianIsEnabledRequest() : base("cloudianIsEnabled") {}

    }
    /// <summary>
    /// Checks if the Cloudian Connector is enabled
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        CloudianEnabledResponse CloudianIsEnabled(CloudianIsEnabledRequest request);
        Task<CloudianEnabledResponse> CloudianIsEnabledAsync(CloudianIsEnabledRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public CloudianEnabledResponse CloudianIsEnabled(CloudianIsEnabledRequest request) => Proxy.Request<CloudianEnabledResponse>(request);
        public Task<CloudianEnabledResponse> CloudianIsEnabledAsync(CloudianIsEnabledRequest request) => Proxy.RequestAsync<CloudianEnabledResponse>(request);
    }
}
