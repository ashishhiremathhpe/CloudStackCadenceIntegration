using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ConfigureSimulatorRequest : APIRequest
    {
        public ConfigureSimulatorRequest() : base("configureSimulator") {}

        /// <summary>
        /// which command needs to be configured
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// configuration options for this command, which is separated by ;
        /// </summary>
        public string Value {
            get { return GetParameterValue<string>(nameof(Value).ToLower()); }
            set { SetParameterValue(nameof(Value).ToLower(), value); }
        }

        /// <summary>
        /// configure range: in a cluster
        /// </summary>
        public Guid? ClusterId {
            get { return GetParameterValue<Guid?>(nameof(ClusterId).ToLower()); }
            set { SetParameterValue(nameof(ClusterId).ToLower(), value); }
        }

        /// <summary>
        /// number of times the mock is active
        /// </summary>
        public int? Count {
            get { return GetParameterValue<int?>(nameof(Count).ToLower()); }
            set { SetParameterValue(nameof(Count).ToLower(), value); }
        }

        /// <summary>
        /// configure range: in a host
        /// </summary>
        public Guid? HostId {
            get { return GetParameterValue<Guid?>(nameof(HostId).ToLower()); }
            set { SetParameterValue(nameof(HostId).ToLower(), value); }
        }

        /// <summary>
        /// agent command response to be returned
        /// </summary>
        public string JsonResponse {
            get { return GetParameterValue<string>(nameof(JsonResponse).ToLower()); }
            set { SetParameterValue(nameof(JsonResponse).ToLower(), value); }
        }

        /// <summary>
        /// configure range: in a pod
        /// </summary>
        public Guid? PodId {
            get { return GetParameterValue<Guid?>(nameof(PodId).ToLower()); }
            set { SetParameterValue(nameof(PodId).ToLower(), value); }
        }

        /// <summary>
        /// configure range: in a zone
        /// </summary>
        public Guid? ZoneId {
            get { return GetParameterValue<Guid?>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

    }
    /// <summary>
    /// configure simulator
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        MockResponse ConfigureSimulator(ConfigureSimulatorRequest request);
        Task<MockResponse> ConfigureSimulatorAsync(ConfigureSimulatorRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public MockResponse ConfigureSimulator(ConfigureSimulatorRequest request) => Proxy.Request<MockResponse>(request);
        public Task<MockResponse> ConfigureSimulatorAsync(ConfigureSimulatorRequest request) => Proxy.RequestAsync<MockResponse>(request);
    }
}
