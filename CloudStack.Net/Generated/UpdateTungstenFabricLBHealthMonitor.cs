using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateTungstenFabricLBHealthMonitorRequest : APIRequest
    {
        public UpdateTungstenFabricLBHealthMonitorRequest() : base("updateTungstenFabricLBHealthMonitor") {}

        /// <summary>
        /// loadbalancer health monitor interval
        /// </summary>
        public int? Interval {
            get { return GetParameterValue<int?>(nameof(Interval).ToLower()); }
            set { SetParameterValue(nameof(Interval).ToLower(), value); }
        }

        /// <summary>
        /// the ID of lb rule
        /// </summary>
        public Guid Lbruleid {
            get { return GetParameterValue<Guid>(nameof(Lbruleid).ToLower()); }
            set { SetParameterValue(nameof(Lbruleid).ToLower(), value); }
        }

        /// <summary>
        /// loadbalancer health monitor retry
        /// </summary>
        public int? Retry {
            get { return GetParameterValue<int?>(nameof(Retry).ToLower()); }
            set { SetParameterValue(nameof(Retry).ToLower(), value); }
        }

        /// <summary>
        /// loadbalancer health monitor timeout
        /// </summary>
        public int? Timeout {
            get { return GetParameterValue<int?>(nameof(Timeout).ToLower()); }
            set { SetParameterValue(nameof(Timeout).ToLower(), value); }
        }

        /// <summary>
        /// loadbalancer health monitor type
        /// </summary>
        public string Type {
            get { return GetParameterValue<string>(nameof(Type).ToLower()); }
            set { SetParameterValue(nameof(Type).ToLower(), value); }
        }

        /// <summary>
        /// loadbalancer health monitor expected code
        /// </summary>
        public string ExpectedCode {
            get { return GetParameterValue<string>(nameof(ExpectedCode).ToLower()); }
            set { SetParameterValue(nameof(ExpectedCode).ToLower(), value); }
        }

        /// <summary>
        /// loadbalancer health monitor http method
        /// </summary>
        public string Httpmethodtype {
            get { return GetParameterValue<string>(nameof(Httpmethodtype).ToLower()); }
            set { SetParameterValue(nameof(Httpmethodtype).ToLower(), value); }
        }

        /// <summary>
        /// loadbalancer health monitor url path
        /// </summary>
        public string UrlPath {
            get { return GetParameterValue<string>(nameof(UrlPath).ToLower()); }
            set { SetParameterValue(nameof(UrlPath).ToLower(), value); }
        }

    }
    /// <summary>
    /// update Tungsten-Fabric loadbalancer health monitor
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse UpdateTungstenFabricLBHealthMonitor(UpdateTungstenFabricLBHealthMonitorRequest request);
        Task<AsyncJobResponse> UpdateTungstenFabricLBHealthMonitorAsync(UpdateTungstenFabricLBHealthMonitorRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse UpdateTungstenFabricLBHealthMonitor(UpdateTungstenFabricLBHealthMonitorRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> UpdateTungstenFabricLBHealthMonitorAsync(UpdateTungstenFabricLBHealthMonitorRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
