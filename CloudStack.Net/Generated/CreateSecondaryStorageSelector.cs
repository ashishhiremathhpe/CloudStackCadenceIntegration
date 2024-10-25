using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateSecondaryStorageSelectorRequest : APIRequest
    {
        public CreateSecondaryStorageSelectorRequest() : base("createSecondaryStorageSelector") {}

        /// <summary>
        /// The description of the heuristic rule.
        /// </summary>
        public string Description {
            get { return GetParameterValue<string>(nameof(Description).ToLower()); }
            set { SetParameterValue(nameof(Description).ToLower(), value); }
        }

        /// <summary>
        /// The heuristic rule, in JavaScript language. It is required that it returns the UUID of a secondary storage pool. An example of a rule is `if (snapshot.hypervisorType === 'KVM') { '7832f261-c602-4e8e-8580-2496ffbbc45d'; }` would allocate all snapshots with the KVM hypervisor to the specified secondary storage UUID.
        /// </summary>
        public string HeuristicRule {
            get { return GetParameterValue<string>(nameof(HeuristicRule).ToLower()); }
            set { SetParameterValue(nameof(HeuristicRule).ToLower(), value); }
        }

        /// <summary>
        /// The name identifying the heuristic rule.
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// The resource type directed to a specific secondary storage by the selector. Valid options are: ISO, SNAPSHOT, TEMPLATE and VOLUME.
        /// </summary>
        public string Type {
            get { return GetParameterValue<string>(nameof(Type).ToLower()); }
            set { SetParameterValue(nameof(Type).ToLower(), value); }
        }

        /// <summary>
        /// The zone in which the heuristic rule will be applied.
        /// </summary>
        public Guid ZoneId {
            get { return GetParameterValue<Guid>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Creates a secondary storage selector, described by the heuristic rule.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SecondaryStorageHeuristicsResponse CreateSecondaryStorageSelector(CreateSecondaryStorageSelectorRequest request);
        Task<SecondaryStorageHeuristicsResponse> CreateSecondaryStorageSelectorAsync(CreateSecondaryStorageSelectorRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SecondaryStorageHeuristicsResponse CreateSecondaryStorageSelector(CreateSecondaryStorageSelectorRequest request) => Proxy.Request<SecondaryStorageHeuristicsResponse>(request);
        public Task<SecondaryStorageHeuristicsResponse> CreateSecondaryStorageSelectorAsync(CreateSecondaryStorageSelectorRequest request) => Proxy.RequestAsync<SecondaryStorageHeuristicsResponse>(request);
    }
}
