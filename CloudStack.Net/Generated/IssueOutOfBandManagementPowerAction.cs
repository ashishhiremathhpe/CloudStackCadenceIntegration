using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class IssueOutOfBandManagementPowerActionRequest : APIRequest
    {
        public IssueOutOfBandManagementPowerActionRequest() : base("issueOutOfBandManagementPowerAction") {}

        /// <summary>
        /// out-of-band management power actions, valid actions are: ON, OFF, CYCLE, RESET, SOFT, STATUS
        /// </summary>
        public string Action {
            get { return GetParameterValue<string>(nameof(Action).ToLower()); }
            set { SetParameterValue(nameof(Action).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the host
        /// </summary>
        public Guid HostId {
            get { return GetParameterValue<Guid>(nameof(HostId).ToLower()); }
            set { SetParameterValue(nameof(HostId).ToLower(), value); }
        }

        /// <summary>
        /// optional operation timeout in seconds that overrides the global or cluster-level out-of-band management timeout setting
        /// </summary>
        public long? Timeout {
            get { return GetParameterValue<long?>(nameof(Timeout).ToLower()); }
            set { SetParameterValue(nameof(Timeout).ToLower(), value); }
        }

    }
    /// <summary>
    /// Initiates the specified power action to the host's out-of-band management interface
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse IssueOutOfBandManagementPowerAction(IssueOutOfBandManagementPowerActionRequest request);
        Task<AsyncJobResponse> IssueOutOfBandManagementPowerActionAsync(IssueOutOfBandManagementPowerActionRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse IssueOutOfBandManagementPowerAction(IssueOutOfBandManagementPowerActionRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> IssueOutOfBandManagementPowerActionAsync(IssueOutOfBandManagementPowerActionRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
