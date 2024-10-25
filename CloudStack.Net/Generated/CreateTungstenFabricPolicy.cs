using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateTungstenFabricPolicyRequest : APIRequest
    {
        public CreateTungstenFabricPolicyRequest() : base("createTungstenFabricPolicy") {}

        /// <summary>
        /// Tungsten-Fabric policy name
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
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
    /// create Tungsten-Fabric policy
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse CreateTungstenFabricPolicy(CreateTungstenFabricPolicyRequest request);
        Task<AsyncJobResponse> CreateTungstenFabricPolicyAsync(CreateTungstenFabricPolicyRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse CreateTungstenFabricPolicy(CreateTungstenFabricPolicyRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> CreateTungstenFabricPolicyAsync(CreateTungstenFabricPolicyRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
