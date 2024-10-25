using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UploadTemplateDirectDownloadCertificateRequest : APIRequest
    {
        public UploadTemplateDirectDownloadCertificateRequest() : base("uploadTemplateDirectDownloadCertificate") {}

        /// <summary>
        /// SSL certificate
        /// </summary>
        public string Certificate {
            get { return GetParameterValue<string>(nameof(Certificate).ToLower()); }
            set { SetParameterValue(nameof(Certificate).ToLower(), value); }
        }

        /// <summary>
        /// Hypervisor type
        /// </summary>
        public string Hypervisor {
            get { return GetParameterValue<string>(nameof(Hypervisor).ToLower()); }
            set { SetParameterValue(nameof(Hypervisor).ToLower(), value); }
        }

        /// <summary>
        /// Name for the uploaded certificate
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// Zone to upload certificate
        /// </summary>
        public Guid ZoneId {
            get { return GetParameterValue<Guid>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

        /// <summary>
        /// (optional) the host ID to upload certificate
        /// </summary>
        public Guid? HostId {
            get { return GetParameterValue<Guid?>(nameof(HostId).ToLower()); }
            set { SetParameterValue(nameof(HostId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Upload a certificate for HTTPS direct template download on KVM hosts
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        DirectDownloadCertificateResponse UploadTemplateDirectDownloadCertificate(UploadTemplateDirectDownloadCertificateRequest request);
        Task<DirectDownloadCertificateResponse> UploadTemplateDirectDownloadCertificateAsync(UploadTemplateDirectDownloadCertificateRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public DirectDownloadCertificateResponse UploadTemplateDirectDownloadCertificate(UploadTemplateDirectDownloadCertificateRequest request) => Proxy.Request<DirectDownloadCertificateResponse>(request);
        public Task<DirectDownloadCertificateResponse> UploadTemplateDirectDownloadCertificateAsync(UploadTemplateDirectDownloadCertificateRequest request) => Proxy.RequestAsync<DirectDownloadCertificateResponse>(request);
    }
}
