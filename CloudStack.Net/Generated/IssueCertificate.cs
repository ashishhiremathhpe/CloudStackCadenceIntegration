using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class IssueCertificateRequest : APIRequest
    {
        public IssueCertificateRequest() : base("issueCertificate") {}

        /// <summary>
        /// The certificate signing request (in pem format), if CSR is not provided then configured/provided options are considered
        /// </summary>
        public string Csr {
            get { return GetParameterValue<string>(nameof(Csr).ToLower()); }
            set { SetParameterValue(nameof(Csr).ToLower(), value); }
        }

        /// <summary>
        /// Comma separated list of domains, the certificate should be issued for. When csr is not provided, the first domain is used as a subject/CN
        /// </summary>
        public string Domain {
            get { return GetParameterValue<string>(nameof(Domain).ToLower()); }
            set { SetParameterValue(nameof(Domain).ToLower(), value); }
        }

        /// <summary>
        /// Certificate validity duration in number of days, when not provided the default configured value will be used
        /// </summary>
        public int? Duration {
            get { return GetParameterValue<int?>(nameof(Duration).ToLower()); }
            set { SetParameterValue(nameof(Duration).ToLower(), value); }
        }

        /// <summary>
        /// Comma separated list of IP addresses, the certificate should be issued for
        /// </summary>
        public string Ipaddress {
            get { return GetParameterValue<string>(nameof(Ipaddress).ToLower()); }
            set { SetParameterValue(nameof(Ipaddress).ToLower(), value); }
        }

        /// <summary>
        /// Name of the CA service provider, otherwise the default configured provider plugin will be used
        /// </summary>
        public string Provider {
            get { return GetParameterValue<string>(nameof(Provider).ToLower()); }
            set { SetParameterValue(nameof(Provider).ToLower(), value); }
        }

    }
    /// <summary>
    /// Issues a client certificate using configured or provided CA plugin
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse IssueCertificate(IssueCertificateRequest request);
        Task<AsyncJobResponse> IssueCertificateAsync(IssueCertificateRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse IssueCertificate(IssueCertificateRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> IssueCertificateAsync(IssueCertificateRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
