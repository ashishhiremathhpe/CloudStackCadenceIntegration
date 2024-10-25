using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ConfigureHAForHostRequest : APIRequest
    {
        public ConfigureHAForHostRequest() : base("configureHAForHost") {}

        /// <summary>
        /// ID of the host
        /// </summary>
        public Guid HostId {
            get { return GetParameterValue<Guid>(nameof(HostId).ToLower()); }
            set { SetParameterValue(nameof(HostId).ToLower(), value); }
        }

        /// <summary>
        /// HA provider
        /// </summary>
        public string Provider {
            get { return GetParameterValue<string>(nameof(Provider).ToLower()); }
            set { SetParameterValue(nameof(Provider).ToLower(), value); }
        }

    }
    /// <summary>
    /// Configures HA for a host
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse ConfigureHAForHost(ConfigureHAForHostRequest request);
        Task<AsyncJobResponse> ConfigureHAForHostAsync(ConfigureHAForHostRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse ConfigureHAForHost(ConfigureHAForHostRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> ConfigureHAForHostAsync(ConfigureHAForHostRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
