using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ApplyTungstenFabricPolicyRequest : APIRequest
    {
        public ApplyTungstenFabricPolicyRequest() : base("applyTungstenFabricPolicy") {}

        /// <summary>
        /// the major sequence of Tungsten-Fabric policy
        /// </summary>
        public int? MajorSequence {
            get { return GetParameterValue<int?>(nameof(MajorSequence).ToLower()); }
            set { SetParameterValue(nameof(MajorSequence).ToLower(), value); }
        }

        /// <summary>
        /// the minor sequence of Tungsten-Fabric policy
        /// </summary>
        public int? MinorSequence {
            get { return GetParameterValue<int?>(nameof(MinorSequence).ToLower()); }
            set { SetParameterValue(nameof(MinorSequence).ToLower(), value); }
        }

        /// <summary>
        /// the uuid of network
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
    /// apply Tungsten-Fabric policy
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse ApplyTungstenFabricPolicy(ApplyTungstenFabricPolicyRequest request);
        Task<AsyncJobResponse> ApplyTungstenFabricPolicyAsync(ApplyTungstenFabricPolicyRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse ApplyTungstenFabricPolicy(ApplyTungstenFabricPolicyRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> ApplyTungstenFabricPolicyAsync(ApplyTungstenFabricPolicyRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
