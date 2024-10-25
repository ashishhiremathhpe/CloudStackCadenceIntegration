using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ProvisionTemplateDirectDownloadCertificateRequest : APIRequest
    {
        public ProvisionTemplateDirectDownloadCertificateRequest() : base("provisionTemplateDirectDownloadCertificate") {}

        /// <summary>
        /// the id of the direct download certificate to provision
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// the host to provision the certificate
        /// </summary>
        public Guid HostId {
            get { return GetParameterValue<Guid>(nameof(HostId).ToLower()); }
            set { SetParameterValue(nameof(HostId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Provisions a host with a direct download certificate
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        DirectDownloadCertificateHostStatusResponse ProvisionTemplateDirectDownloadCertificate(ProvisionTemplateDirectDownloadCertificateRequest request);
        Task<DirectDownloadCertificateHostStatusResponse> ProvisionTemplateDirectDownloadCertificateAsync(ProvisionTemplateDirectDownloadCertificateRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public DirectDownloadCertificateHostStatusResponse ProvisionTemplateDirectDownloadCertificate(ProvisionTemplateDirectDownloadCertificateRequest request) => Proxy.Request<DirectDownloadCertificateHostStatusResponse>(request);
        public Task<DirectDownloadCertificateHostStatusResponse> ProvisionTemplateDirectDownloadCertificateAsync(ProvisionTemplateDirectDownloadCertificateRequest request) => Proxy.RequestAsync<DirectDownloadCertificateHostStatusResponse>(request);
    }
}
