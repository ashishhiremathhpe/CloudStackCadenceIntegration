using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListClusterDrsPlanRequest : APIListRequest
    {
        public ListClusterDrsPlanRequest() : base("listClusterDrsPlan") {}

        /// <summary>
        /// ID of the cluster
        /// </summary>
        public Guid? ClusterId {
            get { return GetParameterValue<Guid?>(nameof(ClusterId).ToLower()); }
            set { SetParameterValue(nameof(ClusterId).ToLower(), value); }
        }

        /// <summary>
        /// ID of the drs plan
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

    }
    /// <summary>
    /// List DRS plans for a clusters
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<ClusterDrsPlanResponse> ListClusterDrsPlan(ListClusterDrsPlanRequest request);
        Task<ListResponse<ClusterDrsPlanResponse>> ListClusterDrsPlanAsync(ListClusterDrsPlanRequest request);
        ListResponse<ClusterDrsPlanResponse> ListClusterDrsPlanAllPages(ListClusterDrsPlanRequest request);
        Task<ListResponse<ClusterDrsPlanResponse>> ListClusterDrsPlanAllPagesAsync(ListClusterDrsPlanRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<ClusterDrsPlanResponse> ListClusterDrsPlan(ListClusterDrsPlanRequest request) => Proxy.Request<ListResponse<ClusterDrsPlanResponse>>(request);
        public Task<ListResponse<ClusterDrsPlanResponse>> ListClusterDrsPlanAsync(ListClusterDrsPlanRequest request) => Proxy.RequestAsync<ListResponse<ClusterDrsPlanResponse>>(request);
        public ListResponse<ClusterDrsPlanResponse> ListClusterDrsPlanAllPages(ListClusterDrsPlanRequest request) => Proxy.RequestAllPages<ClusterDrsPlanResponse>(request);
        public Task<ListResponse<ClusterDrsPlanResponse>> ListClusterDrsPlanAllPagesAsync(ListClusterDrsPlanRequest request) => Proxy.RequestAllPagesAsync<ClusterDrsPlanResponse>(request);
    }
}
