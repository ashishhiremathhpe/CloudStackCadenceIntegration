using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListClustersMetricsRequest : APIListRequest
    {
        public ListClustersMetricsRequest() : base("listClustersMetrics") {}

        /// <summary>
        /// lists clusters by allocation state
        /// </summary>
        public string AllocationState {
            get { return GetParameterValue<string>(nameof(AllocationState).ToLower()); }
            set { SetParameterValue(nameof(AllocationState).ToLower(), value); }
        }

        /// <summary>
        /// lists clusters by cluster type
        /// </summary>
        public string ClusterType {
            get { return GetParameterValue<string>(nameof(ClusterType).ToLower()); }
            set { SetParameterValue(nameof(ClusterType).ToLower(), value); }
        }

        /// <summary>
        /// lists clusters by hypervisor type
        /// </summary>
        public string Hypervisor {
            get { return GetParameterValue<string>(nameof(Hypervisor).ToLower()); }
            set { SetParameterValue(nameof(Hypervisor).ToLower(), value); }
        }

        /// <summary>
        /// lists clusters by the cluster ID
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
        /// whether this cluster is managed by cloudstack
        /// </summary>
        public string ManagedState {
            get { return GetParameterValue<string>(nameof(ManagedState).ToLower()); }
            set { SetParameterValue(nameof(ManagedState).ToLower(), value); }
        }

        /// <summary>
        /// lists clusters by the cluster name
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// lists clusters by Pod ID
        /// </summary>
        public Guid? PodId {
            get { return GetParameterValue<Guid?>(nameof(PodId).ToLower()); }
            set { SetParameterValue(nameof(PodId).ToLower(), value); }
        }

        /// <summary>
        /// flag to display the capacity of the clusters
        /// </summary>
        public bool? ShowCapacities {
            get { return GetParameterValue<bool?>(nameof(ShowCapacities).ToLower()); }
            set { SetParameterValue(nameof(ShowCapacities).ToLower(), value); }
        }

        /// <summary>
        /// lists clusters by Zone ID
        /// </summary>
        public Guid? ZoneId {
            get { return GetParameterValue<Guid?>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists clusters metrics
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<ClusterMetricsResponse> ListClustersMetrics(ListClustersMetricsRequest request);
        Task<ListResponse<ClusterMetricsResponse>> ListClustersMetricsAsync(ListClustersMetricsRequest request);
        ListResponse<ClusterMetricsResponse> ListClustersMetricsAllPages(ListClustersMetricsRequest request);
        Task<ListResponse<ClusterMetricsResponse>> ListClustersMetricsAllPagesAsync(ListClustersMetricsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<ClusterMetricsResponse> ListClustersMetrics(ListClustersMetricsRequest request) => Proxy.Request<ListResponse<ClusterMetricsResponse>>(request);
        public Task<ListResponse<ClusterMetricsResponse>> ListClustersMetricsAsync(ListClustersMetricsRequest request) => Proxy.RequestAsync<ListResponse<ClusterMetricsResponse>>(request);
        public ListResponse<ClusterMetricsResponse> ListClustersMetricsAllPages(ListClustersMetricsRequest request) => Proxy.RequestAllPages<ClusterMetricsResponse>(request);
        public Task<ListResponse<ClusterMetricsResponse>> ListClustersMetricsAllPagesAsync(ListClustersMetricsRequest request) => Proxy.RequestAllPagesAsync<ClusterMetricsResponse>(request);
    }
}
