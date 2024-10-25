using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteTungstenFabricPolicyRequest : APIRequest
    {
        public DeleteTungstenFabricPolicyRequest() : base("deleteTungstenFabricPolicy") {}

        /// <summary>
        /// the Uuid of Tungsten-Fabric tag type
        /// </summary>
        public string PolicyUuid {
            get { return GetParameterValue<string>(nameof(PolicyUuid).ToLower()); }
            set { SetParameterValue(nameof(PolicyUuid).ToLower(), value); }
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
    /// delete Tungsten-Fabric policy
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeleteTungstenFabricPolicy(DeleteTungstenFabricPolicyRequest request);
        Task<AsyncJobResponse> DeleteTungstenFabricPolicyAsync(DeleteTungstenFabricPolicyRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteTungstenFabricPolicy(DeleteTungstenFabricPolicyRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DeleteTungstenFabricPolicyAsync(DeleteTungstenFabricPolicyRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
