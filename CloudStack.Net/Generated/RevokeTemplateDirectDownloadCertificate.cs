using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class RevokeTemplateDirectDownloadCertificateRequest : APIRequest
    {
        public RevokeTemplateDirectDownloadCertificateRequest() : base("revokeTemplateDirectDownloadCertificate") {}

        /// <summary>
        /// (optional) zone to revoke certificate
        /// </summary>
        public Guid ZoneId {
            get { return GetParameterValue<Guid>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

        /// <summary>
        /// (optional) the host ID to revoke certificate
        /// </summary>
        public Guid? HostId {
            get { return GetParameterValue<Guid?>(nameof(HostId).ToLower()); }
            set { SetParameterValue(nameof(HostId).ToLower(), value); }
        }

        /// <summary>
        /// (optional) hypervisor type
        /// </summary>
        public string Hypervisor {
            get { return GetParameterValue<string>(nameof(Hypervisor).ToLower()); }
            set { SetParameterValue(nameof(Hypervisor).ToLower(), value); }
        }

        /// <summary>
        /// id of the certificate
        /// </summary>
        public Guid? Id {
            get { return GetParameterValue<Guid?>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// (optional) alias of the SSL certificate
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

    }
    /// <summary>
    /// Revoke a direct download certificate from hosts in a zone
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        DirectDownloadCertificateHostStatusResponse RevokeTemplateDirectDownloadCertificate(RevokeTemplateDirectDownloadCertificateRequest request);
        Task<DirectDownloadCertificateHostStatusResponse> RevokeTemplateDirectDownloadCertificateAsync(RevokeTemplateDirectDownloadCertificateRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public DirectDownloadCertificateHostStatusResponse RevokeTemplateDirectDownloadCertificate(RevokeTemplateDirectDownloadCertificateRequest request) => Proxy.Request<DirectDownloadCertificateHostStatusResponse>(request);
        public Task<DirectDownloadCertificateHostStatusResponse> RevokeTemplateDirectDownloadCertificateAsync(RevokeTemplateDirectDownloadCertificateRequest request) => Proxy.RequestAsync<DirectDownloadCertificateHostStatusResponse>(request);
    }
}
