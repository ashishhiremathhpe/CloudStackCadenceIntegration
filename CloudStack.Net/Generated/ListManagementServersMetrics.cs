using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListManagementServersMetricsRequest : APIListRequest
    {
        public ListManagementServersMetricsRequest() : base("listManagementServersMetrics") {}

        /// <summary>
        /// the id of the management server
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
        /// the name of the management server
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// include system level stats
        /// </summary>
        public bool? System {
            get { return GetParameterValue<bool?>(nameof(System).ToLower()); }
            set { SetParameterValue(nameof(System).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists Management Server metrics
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<ManagementServerMetricsResponse> ListManagementServersMetrics(ListManagementServersMetricsRequest request);
        Task<ListResponse<ManagementServerMetricsResponse>> ListManagementServersMetricsAsync(ListManagementServersMetricsRequest request);
        ListResponse<ManagementServerMetricsResponse> ListManagementServersMetricsAllPages(ListManagementServersMetricsRequest request);
        Task<ListResponse<ManagementServerMetricsResponse>> ListManagementServersMetricsAllPagesAsync(ListManagementServersMetricsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<ManagementServerMetricsResponse> ListManagementServersMetrics(ListManagementServersMetricsRequest request) => Proxy.Request<ListResponse<ManagementServerMetricsResponse>>(request);
        public Task<ListResponse<ManagementServerMetricsResponse>> ListManagementServersMetricsAsync(ListManagementServersMetricsRequest request) => Proxy.RequestAsync<ListResponse<ManagementServerMetricsResponse>>(request);
        public ListResponse<ManagementServerMetricsResponse> ListManagementServersMetricsAllPages(ListManagementServersMetricsRequest request) => Proxy.RequestAllPages<ManagementServerMetricsResponse>(request);
        public Task<ListResponse<ManagementServerMetricsResponse>> ListManagementServersMetricsAllPagesAsync(ListManagementServersMetricsRequest request) => Proxy.RequestAllPagesAsync<ManagementServerMetricsResponse>(request);
    }
}
