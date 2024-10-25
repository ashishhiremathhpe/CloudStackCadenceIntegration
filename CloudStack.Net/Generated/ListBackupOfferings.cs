using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListBackupOfferingsRequest : APIListRequest
    {
        public ListBackupOfferingsRequest() : base("listBackupOfferings") {}

        /// <summary>
        /// The backup offering ID
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
        /// The zone ID
        /// </summary>
        public Guid? ZoneId {
            get { return GetParameterValue<Guid?>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists backup offerings
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<BackupOfferingResponse> ListBackupOfferings(ListBackupOfferingsRequest request);
        Task<ListResponse<BackupOfferingResponse>> ListBackupOfferingsAsync(ListBackupOfferingsRequest request);
        ListResponse<BackupOfferingResponse> ListBackupOfferingsAllPages(ListBackupOfferingsRequest request);
        Task<ListResponse<BackupOfferingResponse>> ListBackupOfferingsAllPagesAsync(ListBackupOfferingsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<BackupOfferingResponse> ListBackupOfferings(ListBackupOfferingsRequest request) => Proxy.Request<ListResponse<BackupOfferingResponse>>(request);
        public Task<ListResponse<BackupOfferingResponse>> ListBackupOfferingsAsync(ListBackupOfferingsRequest request) => Proxy.RequestAsync<ListResponse<BackupOfferingResponse>>(request);
        public ListResponse<BackupOfferingResponse> ListBackupOfferingsAllPages(ListBackupOfferingsRequest request) => Proxy.RequestAllPages<BackupOfferingResponse>(request);
        public Task<ListResponse<BackupOfferingResponse>> ListBackupOfferingsAllPagesAsync(ListBackupOfferingsRequest request) => Proxy.RequestAllPagesAsync<BackupOfferingResponse>(request);
    }
}
