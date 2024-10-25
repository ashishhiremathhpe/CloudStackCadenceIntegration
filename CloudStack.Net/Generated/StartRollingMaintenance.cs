using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class StartRollingMaintenanceRequest : APIRequest
    {
        public StartRollingMaintenanceRequest() : base("startRollingMaintenance") {}

        /// <summary>
        /// the IDs of the clusters to start maintenance on
        /// </summary>
        public IList<Guid> ClusterIds {
            get { return GetList<Guid>(nameof(ClusterIds).ToLower()); }
            set { SetParameterValue(nameof(ClusterIds).ToLower(), value); }
        }

        /// <summary>
        /// if rolling mechanism should continue in case of an error
        /// </summary>
        public bool? Forced {
            get { return GetParameterValue<bool?>(nameof(Forced).ToLower()); }
            set { SetParameterValue(nameof(Forced).ToLower(), value); }
        }

        /// <summary>
        /// the IDs of the hosts to start maintenance on
        /// </summary>
        public IList<Guid> HostIds {
            get { return GetList<Guid>(nameof(HostIds).ToLower()); }
            set { SetParameterValue(nameof(HostIds).ToLower(), value); }
        }

        /// <summary>
        /// the command to execute while hosts are on maintenance
        /// </summary>
        public string Payload {
            get { return GetParameterValue<string>(nameof(Payload).ToLower()); }
            set { SetParameterValue(nameof(Payload).ToLower(), value); }
        }

        /// <summary>
        /// the IDs of the pods to start maintenance on
        /// </summary>
        public IList<Guid> PodIds {
            get { return GetList<Guid>(nameof(PodIds).ToLower()); }
            set { SetParameterValue(nameof(PodIds).ToLower(), value); }
        }

        /// <summary>
        /// optional operation timeout (in seconds) that overrides the global timeout setting
        /// </summary>
        public int? Timeout {
            get { return GetParameterValue<int?>(nameof(Timeout).ToLower()); }
            set { SetParameterValue(nameof(Timeout).ToLower(), value); }
        }

        /// <summary>
        /// the IDs of the zones to start maintenance on
        /// </summary>
        public IList<Guid> ZoneIds {
            get { return GetList<Guid>(nameof(ZoneIds).ToLower()); }
            set { SetParameterValue(nameof(ZoneIds).ToLower(), value); }
        }

    }
    /// <summary>
    /// Start rolling maintenance
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse StartRollingMaintenance(StartRollingMaintenanceRequest request);
        Task<AsyncJobResponse> StartRollingMaintenanceAsync(StartRollingMaintenanceRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse StartRollingMaintenance(StartRollingMaintenanceRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> StartRollingMaintenanceAsync(StartRollingMaintenanceRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
