using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteTungstenFabricApplicationPolicySetRequest : APIRequest
    {
        public DeleteTungstenFabricApplicationPolicySetRequest() : base("deleteTungstenFabricApplicationPolicySet") {}

        /// <summary>
        /// the uuid of Tungsten-Fabric application policy set
        /// </summary>
        public string ApplicationPolicySetUuid {
            get { return GetParameterValue<string>(nameof(ApplicationPolicySetUuid).ToLower()); }
            set { SetParameterValue(nameof(ApplicationPolicySetUuid).ToLower(), value); }
        }

        /// <summary>
        /// the ID of zone
        /// </summary>
        public Guid ZoneId {
            get { return GetParameterValue<Guid>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

    }
    /// <summary>
    /// delete Tungsten-Fabric application policy set
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeleteTungstenFabricApplicationPolicySet(DeleteTungstenFabricApplicationPolicySetRequest request);
        Task<AsyncJobResponse> DeleteTungstenFabricApplicationPolicySetAsync(DeleteTungstenFabricApplicationPolicySetRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteTungstenFabricApplicationPolicySet(DeleteTungstenFabricApplicationPolicySetRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DeleteTungstenFabricApplicationPolicySetAsync(DeleteTungstenFabricApplicationPolicySetRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
