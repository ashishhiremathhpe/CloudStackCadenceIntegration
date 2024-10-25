using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ChangeOutOfBandManagementPasswordRequest : APIRequest
    {
        public ChangeOutOfBandManagementPasswordRequest() : base("changeOutOfBandManagementPassword") {}

        /// <summary>
        /// the ID of the host
        /// </summary>
        public Guid HostId {
            get { return GetParameterValue<Guid>(nameof(HostId).ToLower()); }
            set { SetParameterValue(nameof(HostId).ToLower(), value); }
        }

        /// <summary>
        /// the new host management interface password of maximum length 16, if none is provided a random password would be used
        /// </summary>
        public string Password {
            get { return GetParameterValue<string>(nameof(Password).ToLower()); }
            set { SetParameterValue(nameof(Password).ToLower(), value); }
        }

    }
    /// <summary>
    /// Changes out-of-band management interface password on the host and updates the interface configuration in CloudStack if the operation succeeds, else reverts the old password
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse ChangeOutOfBandManagementPassword(ChangeOutOfBandManagementPasswordRequest request);
        Task<AsyncJobResponse> ChangeOutOfBandManagementPasswordAsync(ChangeOutOfBandManagementPasswordRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse ChangeOutOfBandManagementPassword(ChangeOutOfBandManagementPasswordRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> ChangeOutOfBandManagementPasswordAsync(ChangeOutOfBandManagementPasswordRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
