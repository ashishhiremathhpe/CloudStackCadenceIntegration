using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListSimulatorHAStateTransitionsRequest : APIListRequest
    {
        public ListSimulatorHAStateTransitionsRequest() : base("listSimulatorHAStateTransitions") {}

        /// <summary>
        /// List by host ID
        /// </summary>
        public Guid HostId {
            get { return GetParameterValue<Guid>(nameof(HostId).ToLower()); }
            set { SetParameterValue(nameof(HostId).ToLower(), value); }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

    }
    /// <summary>
    /// list recent simulator HA state transitions for a host for probing and testing
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<SimulatorHAStateResponse> ListSimulatorHAStateTransitions(ListSimulatorHAStateTransitionsRequest request);
        Task<ListResponse<SimulatorHAStateResponse>> ListSimulatorHAStateTransitionsAsync(ListSimulatorHAStateTransitionsRequest request);
        ListResponse<SimulatorHAStateResponse> ListSimulatorHAStateTransitionsAllPages(ListSimulatorHAStateTransitionsRequest request);
        Task<ListResponse<SimulatorHAStateResponse>> ListSimulatorHAStateTransitionsAllPagesAsync(ListSimulatorHAStateTransitionsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<SimulatorHAStateResponse> ListSimulatorHAStateTransitions(ListSimulatorHAStateTransitionsRequest request) => Proxy.Request<ListResponse<SimulatorHAStateResponse>>(request);
        public Task<ListResponse<SimulatorHAStateResponse>> ListSimulatorHAStateTransitionsAsync(ListSimulatorHAStateTransitionsRequest request) => Proxy.RequestAsync<ListResponse<SimulatorHAStateResponse>>(request);
        public ListResponse<SimulatorHAStateResponse> ListSimulatorHAStateTransitionsAllPages(ListSimulatorHAStateTransitionsRequest request) => Proxy.RequestAllPages<SimulatorHAStateResponse>(request);
        public Task<ListResponse<SimulatorHAStateResponse>> ListSimulatorHAStateTransitionsAllPagesAsync(ListSimulatorHAStateTransitionsRequest request) => Proxy.RequestAllPagesAsync<SimulatorHAStateResponse>(request);
    }
}
