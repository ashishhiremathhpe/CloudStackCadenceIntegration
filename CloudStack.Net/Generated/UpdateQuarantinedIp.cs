using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateQuarantinedIpRequest : APIRequest
    {
        public UpdateQuarantinedIpRequest() : base("updateQuarantinedIp") {}

        /// <summary>
        /// The date when the quarantine will no longer be active.
        /// </summary>
        public DateTime EndDate {
            get { return GetParameterValue<DateTime>(nameof(EndDate).ToLower()); }
            set { SetParameterValue(nameof(EndDate).ToLower(), value); }
        }

        /// <summary>
        /// The ID of the public IP address in active quarantine.
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
    /// Updates the quarantine end date for the given public IP address.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        IpQuarantineResponse UpdateQuarantinedIp(UpdateQuarantinedIpRequest request);
        Task<IpQuarantineResponse> UpdateQuarantinedIpAsync(UpdateQuarantinedIpRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public IpQuarantineResponse UpdateQuarantinedIp(UpdateQuarantinedIpRequest request) => Proxy.Request<IpQuarantineResponse>(request);
        public Task<IpQuarantineResponse> UpdateQuarantinedIpAsync(UpdateQuarantinedIpRequest request) => Proxy.RequestAsync<IpQuarantineResponse>(request);
    }
}
