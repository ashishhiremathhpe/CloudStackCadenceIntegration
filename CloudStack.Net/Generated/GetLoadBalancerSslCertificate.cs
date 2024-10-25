using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class GetLoadBalancerSslCertificateRequest : APIRequest
    {
        public GetLoadBalancerSslCertificateRequest() : base("getLoadBalancerSslCertificate") {}

        /// <summary>
        /// the ID of Lb
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// get load balancer certificate
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        TlsDataResponse GetLoadBalancerSslCertificate(GetLoadBalancerSslCertificateRequest request);
        Task<TlsDataResponse> GetLoadBalancerSslCertificateAsync(GetLoadBalancerSslCertificateRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public TlsDataResponse GetLoadBalancerSslCertificate(GetLoadBalancerSslCertificateRequest request) => Proxy.Request<TlsDataResponse>(request);
        public Task<TlsDataResponse> GetLoadBalancerSslCertificateAsync(GetLoadBalancerSslCertificateRequest request) => Proxy.RequestAsync<TlsDataResponse>(request);
    }
}
