using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateTungstenFabricApplicationPolicySetRequest : APIRequest
    {
        public CreateTungstenFabricApplicationPolicySetRequest() : base("createTungstenFabricApplicationPolicySet") {}

        /// <summary>
        /// Tungsten-Fabric application policy set name
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
    /// create Tungsten-Fabric application policy set
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse CreateTungstenFabricApplicationPolicySet(CreateTungstenFabricApplicationPolicySetRequest request);
        Task<AsyncJobResponse> CreateTungstenFabricApplicationPolicySetAsync(CreateTungstenFabricApplicationPolicySetRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse CreateTungstenFabricApplicationPolicySet(CreateTungstenFabricApplicationPolicySetRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> CreateTungstenFabricApplicationPolicySetAsync(CreateTungstenFabricApplicationPolicySetRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
