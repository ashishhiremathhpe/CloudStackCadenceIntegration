using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListCaCertificateRequest : APIRequest
    {
        public ListCaCertificateRequest() : base("listCaCertificate") {}

        /// <summary>
        /// Name of the CA service provider, otherwise the default configured provider plugin will be used
        /// </summary>
        public string Provider {
            get { return GetParameterValue<string>(nameof(Provider).ToLower()); }
            set { SetParameterValue(nameof(Provider).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists the CA public certificate(s) as support by the configured/provided CA plugin
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        CertificateResponse ListCaCertificate(ListCaCertificateRequest request);
        Task<CertificateResponse> ListCaCertificateAsync(ListCaCertificateRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public CertificateResponse ListCaCertificate(ListCaCertificateRequest request) => Proxy.Request<CertificateResponse>(request);
        public Task<CertificateResponse> ListCaCertificateAsync(ListCaCertificateRequest request) => Proxy.RequestAsync<CertificateResponse>(request);
    }
}
