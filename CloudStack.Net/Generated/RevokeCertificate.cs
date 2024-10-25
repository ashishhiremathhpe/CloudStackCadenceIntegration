using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class RevokeCertificateRequest : APIRequest
    {
        public RevokeCertificateRequest() : base("revokeCertificate") {}

        /// <summary>
        /// The certificate serial number, as a hex value
        /// </summary>
        public string Serial {
            get { return GetParameterValue<string>(nameof(Serial).ToLower()); }
            set { SetParameterValue(nameof(Serial).ToLower(), value); }
        }

        /// <summary>
        /// The certificate CN
        /// </summary>
        public string Cn {
            get { return GetParameterValue<string>(nameof(Cn).ToLower()); }
            set { SetParameterValue(nameof(Cn).ToLower(), value); }
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
    /// Revokes certificate using configured CA plugin
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse RevokeCertificate(RevokeCertificateRequest request);
        Task<AsyncJobResponse> RevokeCertificateAsync(RevokeCertificateRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse RevokeCertificate(RevokeCertificateRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> RevokeCertificateAsync(RevokeCertificateRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
