using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class GenerateClusterDrsPlanRequest : APIRequest
    {
        public GenerateClusterDrsPlanRequest() : base("generateClusterDrsPlan") {}

        /// <summary>
        /// the ID of the Cluster
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// Maximum number of VMs to migrate for a DRS execution. Defaults to value of cluster's drs.vm.migrations setting
        /// </summary>
        public int? Migrations {
            get { return GetParameterValue<int?>(nameof(Migrations).ToLower()); }
            set { SetParameterValue(nameof(Migrations).ToLower(), value); }
        }

    }
    /// <summary>
    /// Generate DRS plan for a cluster
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ClusterDrsPlanResponse GenerateClusterDrsPlan(GenerateClusterDrsPlanRequest request);
        Task<ClusterDrsPlanResponse> GenerateClusterDrsPlanAsync(GenerateClusterDrsPlanRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ClusterDrsPlanResponse GenerateClusterDrsPlan(GenerateClusterDrsPlanRequest request) => Proxy.Request<ClusterDrsPlanResponse>(request);
        public Task<ClusterDrsPlanResponse> GenerateClusterDrsPlanAsync(GenerateClusterDrsPlanRequest request) => Proxy.RequestAsync<ClusterDrsPlanResponse>(request);
    }
}
