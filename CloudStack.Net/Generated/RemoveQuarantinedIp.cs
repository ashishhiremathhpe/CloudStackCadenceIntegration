using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class RemoveQuarantinedIpRequest : APIRequest
    {
        public RemoveQuarantinedIpRequest() : base("removeQuarantinedIp") {}

        /// <summary>
        /// The reason for removing the public IP address from quarantine prematurely.
        /// </summary>
        public string RemovalReason {
            get { return GetParameterValue<string>(nameof(RemovalReason).ToLower()); }
            set { SetParameterValue(nameof(RemovalReason).ToLower(), value); }
        }

        /// <summary>
        /// The ID of the public IP address in active quarantine. Either the IP address is informed, or the ID of the IP address in quarantine.
        /// </summary>
        public Guid? Id {
            get { return GetParameterValue<Guid?>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// The public IP address in active quarantine. Either the IP address is informed, or the ID of the IP address in quarantine.
        /// </summary>
        public string IpAddress {
            get { return GetParameterValue<string>(nameof(IpAddress).ToLower()); }
            set { SetParameterValue(nameof(IpAddress).ToLower(), value); }
        }

    }
    /// <summary>
    /// Removes a public IP address from quarantine. Only IPs in active quarantine can be removed.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        IpQuarantineResponse RemoveQuarantinedIp(RemoveQuarantinedIpRequest request);
        Task<IpQuarantineResponse> RemoveQuarantinedIpAsync(RemoveQuarantinedIpRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public IpQuarantineResponse RemoveQuarantinedIp(RemoveQuarantinedIpRequest request) => Proxy.Request<IpQuarantineResponse>(request);
        public Task<IpQuarantineResponse> RemoveQuarantinedIpAsync(RemoveQuarantinedIpRequest request) => Proxy.RequestAsync<IpQuarantineResponse>(request);
    }
}
