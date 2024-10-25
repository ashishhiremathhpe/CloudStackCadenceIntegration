using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CloudianSsoLoginRequest : APIRequest
    {
        public CloudianSsoLoginRequest() : base("cloudianSsoLogin") {}

    }
    /// <summary>
    /// Generates single-sign-on login url for logged-in CloudStack user to access the Cloudian Management Console
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        CloudianSsoLoginResponse CloudianSsoLogin(CloudianSsoLoginRequest request);
        Task<CloudianSsoLoginResponse> CloudianSsoLoginAsync(CloudianSsoLoginRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public CloudianSsoLoginResponse CloudianSsoLogin(CloudianSsoLoginRequest request) => Proxy.Request<CloudianSsoLoginResponse>(request);
        public Task<CloudianSsoLoginResponse> CloudianSsoLoginAsync(CloudianSsoLoginRequest request) => Proxy.RequestAsync<CloudianSsoLoginResponse>(request);
    }
}
