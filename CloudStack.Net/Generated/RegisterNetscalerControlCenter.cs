using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class RegisterNetscalerControlCenterRequest : APIRequest
    {
        public RegisterNetscalerControlCenterRequest() : base("registerNetscalerControlCenter") {}

        /// <summary>
        /// URL of the netscaler controlcenter appliance.
        /// </summary>
        public string Ipaddress {
            get { return GetParameterValue<string>(nameof(Ipaddress).ToLower()); }
            set { SetParameterValue(nameof(Ipaddress).ToLower(), value); }
        }

        /// <summary>
        /// Credentials to reach netscaler controlcenter device
        /// </summary>
        public int? Numretries {
            get { return GetParameterValue<int?>(nameof(Numretries).ToLower()); }
            set { SetParameterValue(nameof(Numretries).ToLower(), value); }
        }

        /// <summary>
        /// Credentials to reach netscaler controlcenter  device
        /// </summary>
        public string Password {
            get { return GetParameterValue<string>(nameof(Password).ToLower()); }
            set { SetParameterValue(nameof(Password).ToLower(), value); }
        }

        /// <summary>
        /// Credentials to reach netscaler controlcenter device
        /// </summary>
        public string Username {
            get { return GetParameterValue<string>(nameof(Username).ToLower()); }
            set { SetParameterValue(nameof(Username).ToLower(), value); }
        }

    }
    /// <summary>
    /// Adds a netscaler control center device
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse RegisterNetscalerControlCenter(RegisterNetscalerControlCenterRequest request);
        Task<AsyncJobResponse> RegisterNetscalerControlCenterAsync(RegisterNetscalerControlCenterRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse RegisterNetscalerControlCenter(RegisterNetscalerControlCenterRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> RegisterNetscalerControlCenterAsync(RegisterNetscalerControlCenterRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
