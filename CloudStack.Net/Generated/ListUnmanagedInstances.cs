using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListUnmanagedInstancesRequest : APIListRequest
    {
        public ListUnmanagedInstancesRequest() : base("listUnmanagedInstances") {}

        /// <summary>
        /// the cluster ID
        /// </summary>
        public Guid ClusterId {
            get { return GetParameterValue<Guid>(nameof(ClusterId).ToLower()); }
            set { SetParameterValue(nameof(ClusterId).ToLower(), value); }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// the hypervisor name of the instance
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists unmanaged virtual machines for a given cluster.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<UnmanagedInstanceResponse> ListUnmanagedInstances(ListUnmanagedInstancesRequest request);
        Task<ListResponse<UnmanagedInstanceResponse>> ListUnmanagedInstancesAsync(ListUnmanagedInstancesRequest request);
        ListResponse<UnmanagedInstanceResponse> ListUnmanagedInstancesAllPages(ListUnmanagedInstancesRequest request);
        Task<ListResponse<UnmanagedInstanceResponse>> ListUnmanagedInstancesAllPagesAsync(ListUnmanagedInstancesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<UnmanagedInstanceResponse> ListUnmanagedInstances(ListUnmanagedInstancesRequest request) => Proxy.Request<ListResponse<UnmanagedInstanceResponse>>(request);
        public Task<ListResponse<UnmanagedInstanceResponse>> ListUnmanagedInstancesAsync(ListUnmanagedInstancesRequest request) => Proxy.RequestAsync<ListResponse<UnmanagedInstanceResponse>>(request);
        public ListResponse<UnmanagedInstanceResponse> ListUnmanagedInstancesAllPages(ListUnmanagedInstancesRequest request) => Proxy.RequestAllPages<UnmanagedInstanceResponse>(request);
        public Task<ListResponse<UnmanagedInstanceResponse>> ListUnmanagedInstancesAllPagesAsync(ListUnmanagedInstancesRequest request) => Proxy.RequestAllPagesAsync<UnmanagedInstanceResponse>(request);
    }
}
