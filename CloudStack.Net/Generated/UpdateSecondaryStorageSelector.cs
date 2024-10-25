using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateSecondaryStorageSelectorRequest : APIRequest
    {
        public UpdateSecondaryStorageSelectorRequest() : base("updateSecondaryStorageSelector") {}

        /// <summary>
        /// The unique identifier of the secondary storage selector.
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// The heuristic rule, in JavaScript language. It is required that it returns the UUID of a secondary storage pool. An example of a rule is `if (snapshot.hypervisorType === 'KVM') { '7832f261-c602-4e8e-8580-2496ffbbc45d'; }` would allocate all snapshots with the KVM hypervisor to the specified secondary storage UUID.
        /// </summary>
        public string HeuristicRule {
            get { return GetParameterValue<string>(nameof(HeuristicRule).ToLower()); }
            set { SetParameterValue(nameof(HeuristicRule).ToLower(), value); }
        }

    }
    /// <summary>
    /// Updates an existing secondary storage selector.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SecondaryStorageHeuristicsResponse UpdateSecondaryStorageSelector(UpdateSecondaryStorageSelectorRequest request);
        Task<SecondaryStorageHeuristicsResponse> UpdateSecondaryStorageSelectorAsync(UpdateSecondaryStorageSelectorRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SecondaryStorageHeuristicsResponse UpdateSecondaryStorageSelector(UpdateSecondaryStorageSelectorRequest request) => Proxy.Request<SecondaryStorageHeuristicsResponse>(request);
        public Task<SecondaryStorageHeuristicsResponse> UpdateSecondaryStorageSelectorAsync(UpdateSecondaryStorageSelectorRequest request) => Proxy.RequestAsync<SecondaryStorageHeuristicsResponse>(request);
    }
}
