using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListTemplateDirectDownloadCertificatesRequest : APIListRequest
    {
        public ListTemplateDirectDownloadCertificatesRequest() : base("listTemplateDirectDownloadCertificates") {}

        /// <summary>
        /// list direct download certificate by ID
        /// </summary>
        public Guid? Id {
            get { return GetParameterValue<Guid?>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// if set to true: include the hosts where the certificate is uploaded to
        /// </summary>
        public bool? ListHosts {
            get { return GetParameterValue<bool?>(nameof(ListHosts).ToLower()); }
            set { SetParameterValue(nameof(ListHosts).ToLower(), value); }
        }

        /// <summary>
        /// the zone where certificates are uploaded
        /// </summary>
        public Guid? ZoneId {
            get { return GetParameterValue<Guid?>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

    }
    /// <summary>
    /// List the uploaded certificates for direct download templates
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<DirectDownloadCertificateResponse> ListTemplateDirectDownloadCertificates(ListTemplateDirectDownloadCertificatesRequest request);
        Task<ListResponse<DirectDownloadCertificateResponse>> ListTemplateDirectDownloadCertificatesAsync(ListTemplateDirectDownloadCertificatesRequest request);
        ListResponse<DirectDownloadCertificateResponse> ListTemplateDirectDownloadCertificatesAllPages(ListTemplateDirectDownloadCertificatesRequest request);
        Task<ListResponse<DirectDownloadCertificateResponse>> ListTemplateDirectDownloadCertificatesAllPagesAsync(ListTemplateDirectDownloadCertificatesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<DirectDownloadCertificateResponse> ListTemplateDirectDownloadCertificates(ListTemplateDirectDownloadCertificatesRequest request) => Proxy.Request<ListResponse<DirectDownloadCertificateResponse>>(request);
        public Task<ListResponse<DirectDownloadCertificateResponse>> ListTemplateDirectDownloadCertificatesAsync(ListTemplateDirectDownloadCertificatesRequest request) => Proxy.RequestAsync<ListResponse<DirectDownloadCertificateResponse>>(request);
        public ListResponse<DirectDownloadCertificateResponse> ListTemplateDirectDownloadCertificatesAllPages(ListTemplateDirectDownloadCertificatesRequest request) => Proxy.RequestAllPages<DirectDownloadCertificateResponse>(request);
        public Task<ListResponse<DirectDownloadCertificateResponse>> ListTemplateDirectDownloadCertificatesAllPagesAsync(ListTemplateDirectDownloadCertificatesRequest request) => Proxy.RequestAllPagesAsync<DirectDownloadCertificateResponse>(request);
    }
}
