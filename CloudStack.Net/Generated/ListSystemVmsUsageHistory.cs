using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListSystemVmsUsageHistoryRequest : APIListRequest
    {
        public ListSystemVmsUsageHistoryRequest() : base("listSystemVmsUsageHistory") {}

        /// <summary>
        /// end date to filter stats.Use format "yyyy-MM-dd hh:mm:ss")
        /// </summary>
        public DateTime? EndDate {
            get { return GetParameterValue<DateTime?>(nameof(EndDate).ToLower()); }
            set { SetParameterValue(nameof(EndDate).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the system VM.
        /// </summary>
        public Guid? Id {
            get { return GetParameterValue<Guid?>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// the IDs of the system VMs, mutually exclusive with id.
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
        /// name of the system VMs (a substring match is made against the parameter value returning the data for all matching VMs).
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
    /// Lists System VM stats
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<VmMetricsStatsResponse> ListSystemVmsUsageHistory(ListSystemVmsUsageHistoryRequest request);
        Task<ListResponse<VmMetricsStatsResponse>> ListSystemVmsUsageHistoryAsync(ListSystemVmsUsageHistoryRequest request);
        ListResponse<VmMetricsStatsResponse> ListSystemVmsUsageHistoryAllPages(ListSystemVmsUsageHistoryRequest request);
        Task<ListResponse<VmMetricsStatsResponse>> ListSystemVmsUsageHistoryAllPagesAsync(ListSystemVmsUsageHistoryRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<VmMetricsStatsResponse> ListSystemVmsUsageHistory(ListSystemVmsUsageHistoryRequest request) => Proxy.Request<ListResponse<VmMetricsStatsResponse>>(request);
        public Task<ListResponse<VmMetricsStatsResponse>> ListSystemVmsUsageHistoryAsync(ListSystemVmsUsageHistoryRequest request) => Proxy.RequestAsync<ListResponse<VmMetricsStatsResponse>>(request);
        public ListResponse<VmMetricsStatsResponse> ListSystemVmsUsageHistoryAllPages(ListSystemVmsUsageHistoryRequest request) => Proxy.RequestAllPages<VmMetricsStatsResponse>(request);
        public Task<ListResponse<VmMetricsStatsResponse>> ListSystemVmsUsageHistoryAllPagesAsync(ListSystemVmsUsageHistoryRequest request) => Proxy.RequestAllPagesAsync<VmMetricsStatsResponse>(request);
    }
}
