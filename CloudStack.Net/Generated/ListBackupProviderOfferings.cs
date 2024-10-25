using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListBackupProviderOfferingsRequest : APIListRequest
    {
        public ListBackupProviderOfferingsRequest() : base("listBackupProviderOfferings") {}

        /// <summary>
        /// The zone ID
        /// </summary>
        public Guid ZoneId {
            get { return GetParameterValue<Guid>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists external backup offerings of the provider
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<BackupOfferingResponse> ListBackupProviderOfferings(ListBackupProviderOfferingsRequest request);
        Task<ListResponse<BackupOfferingResponse>> ListBackupProviderOfferingsAsync(ListBackupProviderOfferingsRequest request);
        ListResponse<BackupOfferingResponse> ListBackupProviderOfferingsAllPages(ListBackupProviderOfferingsRequest request);
        Task<ListResponse<BackupOfferingResponse>> ListBackupProviderOfferingsAllPagesAsync(ListBackupProviderOfferingsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<BackupOfferingResponse> ListBackupProviderOfferings(ListBackupProviderOfferingsRequest request) => Proxy.Request<ListResponse<BackupOfferingResponse>>(request);
        public Task<ListResponse<BackupOfferingResponse>> ListBackupProviderOfferingsAsync(ListBackupProviderOfferingsRequest request) => Proxy.RequestAsync<ListResponse<BackupOfferingResponse>>(request);
        public ListResponse<BackupOfferingResponse> ListBackupProviderOfferingsAllPages(ListBackupProviderOfferingsRequest request) => Proxy.RequestAllPages<BackupOfferingResponse>(request);
        public Task<ListResponse<BackupOfferingResponse>> ListBackupProviderOfferingsAllPagesAsync(ListBackupProviderOfferingsRequest request) => Proxy.RequestAllPagesAsync<BackupOfferingResponse>(request);
    }
}
