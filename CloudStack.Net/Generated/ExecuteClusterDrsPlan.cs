using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ExecuteClusterDrsPlanRequest : APIRequest
    {
        public ExecuteClusterDrsPlanRequest() : base("executeClusterDrsPlan") {}

        /// <summary>
        /// ID of cluster
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// Virtual Machine to destination host mapping. This parameter specifies the mapping between a vm and a host to migrate that VM. clusterid is required if this parameter is set.Format of this parameter: migrateto[vm-index].vm=<uuid>&migrateto[vm-index].host=<uuid> Where, [vm-index] indicates the index to identify the vm that you want to migrate, vm=<uuid> indicates the UUID of the vm that you want to migrate, and host=<uuid> indicates the UUID of the host where you want to migrate the vm. Example: migrateto[0].vm=<71f43cd6-69b0-4d3b-9fbc-67f50963d60b>&migrateto[0].host=<a382f181-3d2b-4413-b92d-b8931befa7e1>&migrateto[1].vm=<88de0173-55c0-4c1c-a269-83d0279eeedf>&migrateto[1].host=<95d6e97c-6766-4d67-9a30-c449c15011d1>&migrateto[2].vm=<1b331390-59f2-4796-9993-bf11c6e76225>&migrateto[2].host=<41fdb564-9d3b-447d-88ed-7628f7640cbc>
        /// </summary>
        public IList<IDictionary<string, object>> Migrateto {
            get { return GetList<IDictionary<string, object>>(nameof(Migrateto).ToLower()); }
            set { SetParameterValue(nameof(Migrateto).ToLower(), value); }
        }

    }
    /// <summary>
    /// Execute DRS for a cluster. If there is another plan in progress for the same cluster, this command will fail.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse ExecuteClusterDrsPlan(ExecuteClusterDrsPlanRequest request);
        Task<AsyncJobResponse> ExecuteClusterDrsPlanAsync(ExecuteClusterDrsPlanRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse ExecuteClusterDrsPlan(ExecuteClusterDrsPlanRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> ExecuteClusterDrsPlanAsync(ExecuteClusterDrsPlanRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
