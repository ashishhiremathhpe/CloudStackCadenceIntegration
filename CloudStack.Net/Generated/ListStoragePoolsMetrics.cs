using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListStoragePoolsMetricsRequest : APIListRequest
    {
        public ListStoragePoolsMetricsRequest() : base("listStoragePoolsMetrics") {}

        /// <summary>
        /// list storage pools belongig to the specific cluster
        /// </summary>
        public Guid? ClusterId {
            get { return GetParameterValue<Guid?>(nameof(ClusterId).ToLower()); }
            set { SetParameterValue(nameof(ClusterId).ToLower(), value); }
        }

        /// <summary>
        /// host ID of the storage pools
        /// </summary>
        public Guid? HostId {
            get { return GetParameterValue<Guid?>(nameof(HostId).ToLower()); }
            set { SetParameterValue(nameof(HostId).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the storage pool
        /// </summary>
        public Guid? Id {
            get { return GetParameterValue<Guid?>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// the IP address for the storage pool
        /// </summary>
        public string IpAddress {
            get { return GetParameterValue<string>(nameof(IpAddress).ToLower()); }
            set { SetParameterValue(nameof(IpAddress).ToLower(), value); }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// the name of the storage pool
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// the storage pool path
        /// </summary>
        public string Path {
            get { return GetParameterValue<string>(nameof(Path).ToLower()); }
            set { SetParameterValue(nameof(Path).ToLower(), value); }
        }

        /// <summary>
        /// the Pod ID for the storage pool
        /// </summary>
        public Guid? PodId {
            get { return GetParameterValue<Guid?>(nameof(PodId).ToLower()); }
            set { SetParameterValue(nameof(PodId).ToLower(), value); }
        }

        /// <summary>
        /// the scope of the storage pool
        /// </summary>
        public string Scope {
            get { return GetParameterValue<string>(nameof(Scope).ToLower()); }
            set { SetParameterValue(nameof(Scope).ToLower(), value); }
        }

        /// <summary>
        /// the status of the storage pool
        /// </summary>
        public string Status {
            get { return GetParameterValue<string>(nameof(Status).ToLower()); }
            set { SetParameterValue(nameof(Status).ToLower(), value); }
        }

        /// <summary>
        /// the Zone ID for the storage pool
        /// </summary>
        public Guid? ZoneId {
            get { return GetParameterValue<Guid?>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists storage pool metrics
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<StoragePoolMetricsResponse> ListStoragePoolsMetrics(ListStoragePoolsMetricsRequest request);
        Task<ListResponse<StoragePoolMetricsResponse>> ListStoragePoolsMetricsAsync(ListStoragePoolsMetricsRequest request);
        ListResponse<StoragePoolMetricsResponse> ListStoragePoolsMetricsAllPages(ListStoragePoolsMetricsRequest request);
        Task<ListResponse<StoragePoolMetricsResponse>> ListStoragePoolsMetricsAllPagesAsync(ListStoragePoolsMetricsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<StoragePoolMetricsResponse> ListStoragePoolsMetrics(ListStoragePoolsMetricsRequest request) => Proxy.Request<ListResponse<StoragePoolMetricsResponse>>(request);
        public Task<ListResponse<StoragePoolMetricsResponse>> ListStoragePoolsMetricsAsync(ListStoragePoolsMetricsRequest request) => Proxy.RequestAsync<ListResponse<StoragePoolMetricsResponse>>(request);
        public ListResponse<StoragePoolMetricsResponse> ListStoragePoolsMetricsAllPages(ListStoragePoolsMetricsRequest request) => Proxy.RequestAllPages<StoragePoolMetricsResponse>(request);
        public Task<ListResponse<StoragePoolMetricsResponse>> ListStoragePoolsMetricsAllPagesAsync(ListStoragePoolsMetricsRequest request) => Proxy.RequestAllPagesAsync<StoragePoolMetricsResponse>(request);
    }
}
