using System;
using System.Linq;

namespace CloudStack.Net
{
    public partial interface ICloudStackAPIClient { }

    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public CloudStackAPIClient(ICloudStackAPIProxy proxy)
        {
            Proxy = proxy;
        }

        public CloudStackAPIClient(string serviceUrl, string apiKey, string secretKey)
            : this(new CloudStackAPIProxy(serviceUrl, apiKey, secretKey))
        { }
        
        public CloudStackAPIClient(string serviceUrl, string apiKey, string secretKey,TimeSpan httpRequestTimeout)
            : this(new CloudStackAPIProxy(serviceUrl, apiKey, secretKey, httpRequestTimeout))
        { }

        public ICloudStackAPIProxy Proxy { get; }
    }
}