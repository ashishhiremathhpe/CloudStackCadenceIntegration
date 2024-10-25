using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListVolumesUsageHistoryRequest : APIListRequest
    {
        public ListVolumesUsageHistoryRequest() : base("listVolumesUsageHistory") {}

        /// <summary>
        /// end date to filter stats.Use format "yyyy-MM-dd hh:mm:ss")
        /// </summary>
        public DateTime? EndDate {
            get { return GetParameterValue<DateTime?>(nameof(EndDate).ToLower()); }
            set { SetParameterValue(nameof(EndDate).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the volume.
        /// </summary>
        public Guid? Id {
            get { return GetParameterValue<Guid?>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// the IDs of the volumes, mutually exclusive with id.
        /// </summary>
        public IList<Guid> Ids {
            get { return GetList<Guid>(nameof(Ids).ToLower()); }
            set { SetParameterValue(nameof(Ids).ToLower(), value); }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// name of the volume (a substring match is made against the parameter value returning the data for all matching Volumes).
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// start date to filter stats.Use format "yyyy-MM-dd hh:mm:ss")
        /// </summary>
        public DateTime? StartDate {
            get { return GetParameterValue<DateTime?>(nameof(StartDate).ToLower()); }
            set { SetParameterValue(nameof(StartDate).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists volume stats
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<VolumeMetricsStatsResponse> ListVolumesUsageHistory(ListVolumesUsageHistoryRequest request);
        Task<ListResponse<VolumeMetricsStatsResponse>> ListVolumesUsageHistoryAsync(ListVolumesUsageHistoryRequest request);
        ListResponse<VolumeMetricsStatsResponse> ListVolumesUsageHistoryAllPages(ListVolumesUsageHistoryRequest request);
        Task<ListResponse<VolumeMetricsStatsResponse>> ListVolumesUsageHistoryAllPagesAsync(ListVolumesUsageHistoryRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<VolumeMetricsStatsResponse> ListVolumesUsageHistory(ListVolumesUsageHistoryRequest request) => Proxy.Request<ListResponse<VolumeMetricsStatsResponse>>(request);
        public Task<ListResponse<VolumeMetricsStatsResponse>> ListVolumesUsageHistoryAsync(ListVolumesUsageHistoryRequest request) => Proxy.RequestAsync<ListResponse<VolumeMetricsStatsResponse>>(request);
        public ListResponse<VolumeMetricsStatsResponse> ListVolumesUsageHistoryAllPages(ListVolumesUsageHistoryRequest request) => Proxy.RequestAllPages<VolumeMetricsStatsResponse>(request);
        public Task<ListResponse<VolumeMetricsStatsResponse>> ListVolumesUsageHistoryAllPagesAsync(ListVolumesUsageHistoryRequest request) => Proxy.RequestAllPagesAsync<VolumeMetricsStatsResponse>(request);
    }
}
