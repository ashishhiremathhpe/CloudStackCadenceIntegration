using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DisableOutOfBandManagementForZoneRequest : APIRequest
    {
        public DisableOutOfBandManagementForZoneRequest() : base("disableOutOfBandManagementForZone") {}

        /// <summary>
        /// the ID of the zone
        /// </summary>
        public Guid ZoneId {
            get { return GetParameterValue<Guid>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Disables out-of-band management for a zone
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DisableOutOfBandManagementForZone(DisableOutOfBandManagementForZoneRequest request);
        Task<AsyncJobResponse> DisableOutOfBandManagementForZoneAsync(DisableOutOfBandManagementForZoneRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DisableOutOfBandManagementForZone(DisableOutOfBandManagementForZoneRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DisableOutOfBandManagementForZoneAsync(DisableOutOfBandManagementForZoneRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
