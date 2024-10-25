using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ConfigureOutOfBandManagementRequest : APIRequest
    {
        public ConfigureOutOfBandManagementRequest() : base("configureOutOfBandManagement") {}

        /// <summary>
        /// the host management interface IP address
        /// </summary>
        public string Address {
            get { return GetParameterValue<string>(nameof(Address).ToLower()); }
            set { SetParameterValue(nameof(Address).ToLower(), value); }
        }

        /// <summary>
        /// the host management interface driver, for example: ipmitool
        /// </summary>
        public string Driver {
            get { return GetParameterValue<string>(nameof(Driver).ToLower()); }
            set { SetParameterValue(nameof(Driver).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the host
        /// </summary>
        public Guid HostId {
            get { return GetParameterValue<Guid>(nameof(HostId).ToLower()); }
            set { SetParameterValue(nameof(HostId).ToLower(), value); }
        }

        /// <summary>
        /// the host management interface password
        /// </summary>
        public string Password {
            get { return GetParameterValue<string>(nameof(Password).ToLower()); }
            set { SetParameterValue(nameof(Password).ToLower(), value); }
        }

        /// <summary>
        /// the host management interface port
        /// </summary>
        public string Port {
            get { return GetParameterValue<string>(nameof(Port).ToLower()); }
            set { SetParameterValue(nameof(Port).ToLower(), value); }
        }

        /// <summary>
        /// the host management interface user
        /// </summary>
        public string Username {
            get { return GetParameterValue<string>(nameof(Username).ToLower()); }
            set { SetParameterValue(nameof(Username).ToLower(), value); }
        }

    }
    /// <summary>
    /// Configures a host's out-of-band management interface
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        OutOfBandManagementResponse ConfigureOutOfBandManagement(ConfigureOutOfBandManagementRequest request);
        Task<OutOfBandManagementResponse> ConfigureOutOfBandManagementAsync(ConfigureOutOfBandManagementRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public OutOfBandManagementResponse ConfigureOutOfBandManagement(ConfigureOutOfBandManagementRequest request) => Proxy.Request<OutOfBandManagementResponse>(request);
        public Task<OutOfBandManagementResponse> ConfigureOutOfBandManagementAsync(ConfigureOutOfBandManagementRequest request) => Proxy.RequestAsync<OutOfBandManagementResponse>(request);
    }
}
