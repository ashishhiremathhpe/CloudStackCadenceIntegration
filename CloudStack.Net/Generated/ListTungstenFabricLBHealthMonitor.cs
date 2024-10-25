using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListTungstenFabricLBHealthMonitorRequest : APIListRequest
    {
        public ListTungstenFabricLBHealthMonitorRequest() : base("listTungstenFabricLBHealthMonitor") {}

        /// <summary>
        /// the ID of lb rule
        /// </summary>
        public Guid Lbruleid {
            get { return GetParameterValue<Guid>(nameof(Lbruleid).ToLower()); }
            set { SetParameterValue(nameof(Lbruleid).ToLower(), value); }
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
    /// list Tungsten-Fabric LB health monitor
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<TungstenFabricLBHealthMonitorResponse> ListTungstenFabricLBHealthMonitor(ListTungstenFabricLBHealthMonitorRequest request);
        Task<ListResponse<TungstenFabricLBHealthMonitorResponse>> ListTungstenFabricLBHealthMonitorAsync(ListTungstenFabricLBHealthMonitorRequest request);
        ListResponse<TungstenFabricLBHealthMonitorResponse> ListTungstenFabricLBHealthMonitorAllPages(ListTungstenFabricLBHealthMonitorRequest request);
        Task<ListResponse<TungstenFabricLBHealthMonitorResponse>> ListTungstenFabricLBHealthMonitorAllPagesAsync(ListTungstenFabricLBHealthMonitorRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<TungstenFabricLBHealthMonitorResponse> ListTungstenFabricLBHealthMonitor(ListTungstenFabricLBHealthMonitorRequest request) => Proxy.Request<ListResponse<TungstenFabricLBHealthMonitorResponse>>(request);
        public Task<ListResponse<TungstenFabricLBHealthMonitorResponse>> ListTungstenFabricLBHealthMonitorAsync(ListTungstenFabricLBHealthMonitorRequest request) => Proxy.RequestAsync<ListResponse<TungstenFabricLBHealthMonitorResponse>>(request);
        public ListResponse<TungstenFabricLBHealthMonitorResponse> ListTungstenFabricLBHealthMonitorAllPages(ListTungstenFabricLBHealthMonitorRequest request) => Proxy.RequestAllPages<TungstenFabricLBHealthMonitorResponse>(request);
        public Task<ListResponse<TungstenFabricLBHealthMonitorResponse>> ListTungstenFabricLBHealthMonitorAllPagesAsync(ListTungstenFabricLBHealthMonitorRequest request) => Proxy.RequestAllPagesAsync<TungstenFabricLBHealthMonitorResponse>(request);
    }
}
