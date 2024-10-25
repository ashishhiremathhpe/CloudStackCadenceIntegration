using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class RemoveTungstenFabricPolicyRequest : APIRequest
    {
        public RemoveTungstenFabricPolicyRequest() : base("removeTungstenFabricPolicy") {}

        /// <summary>
        /// the uuid of Tungsten-Fabric network
        /// </summary>
        public string NetworkUuid {
            get { return GetParameterValue<string>(nameof(NetworkUuid).ToLower()); }
            set { SetParameterValue(nameof(NetworkUuid).ToLower(), value); }
        }

        /// <summary>
        /// the uuid of Tungsten-Fabric policy
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
    /// remove Tungsten-Fabric policy
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse RemoveTungstenFabricPolicy(RemoveTungstenFabricPolicyRequest request);
        Task<AsyncJobResponse> RemoveTungstenFabricPolicyAsync(RemoveTungstenFabricPolicyRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse RemoveTungstenFabricPolicy(RemoveTungstenFabricPolicyRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> RemoveTungstenFabricPolicyAsync(RemoveTungstenFabricPolicyRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
