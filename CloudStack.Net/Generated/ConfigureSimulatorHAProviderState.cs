using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ConfigureSimulatorHAProviderStateRequest : APIRequest
    {
        public ConfigureSimulatorHAProviderStateRequest() : base("configureSimulatorHAProviderState") {}

        /// <summary>
        /// Set true is haprovider for simulator host should have activity
        /// </summary>
        public bool Activity {
            get { return GetParameterValue<bool>(nameof(Activity).ToLower()); }
            set { SetParameterValue(nameof(Activity).ToLower(), value); }
        }

        /// <summary>
        /// Set true is haprovider for simulator host should be fence-able
        /// </summary>
        public bool Fence {
            get { return GetParameterValue<bool>(nameof(Fence).ToLower()); }
            set { SetParameterValue(nameof(Fence).ToLower(), value); }
        }

        /// <summary>
        /// Set true is haprovider for simulator host should be healthy
        /// </summary>
        public bool Health {
            get { return GetParameterValue<bool>(nameof(Health).ToLower()); }
            set { SetParameterValue(nameof(Health).ToLower(), value); }
        }

        /// <summary>
        /// List by host ID
        /// </summary>
        public Guid HostId {
            get { return GetParameterValue<Guid>(nameof(HostId).ToLower()); }
            set { SetParameterValue(nameof(HostId).ToLower(), value); }
        }

        /// <summary>
        /// Set true is haprovider for simulator host should be recoverable
        /// </summary>
        public bool Recover {
            get { return GetParameterValue<bool>(nameof(Recover).ToLower()); }
            set { SetParameterValue(nameof(Recover).ToLower(), value); }
        }

    }
    /// <summary>
    /// configures simulator HA provider state for a host for probing and testing
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse ConfigureSimulatorHAProviderState(ConfigureSimulatorHAProviderStateRequest request);
        Task<SuccessResponse> ConfigureSimulatorHAProviderStateAsync(ConfigureSimulatorHAProviderStateRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse ConfigureSimulatorHAProviderState(ConfigureSimulatorHAProviderStateRequest request) => Proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> ConfigureSimulatorHAProviderStateAsync(ConfigureSimulatorHAProviderStateRequest request) => Proxy.RequestAsync<SuccessResponse>(request);
    }
}
