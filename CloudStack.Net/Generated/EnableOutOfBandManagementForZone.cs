using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class EnableOutOfBandManagementForZoneRequest : APIRequest
    {
        public EnableOutOfBandManagementForZoneRequest() : base("enableOutOfBandManagementForZone") {}

        /// <summary>
        /// the ID of the zone
        /// </summary>
        public Guid ZoneId {
            get { return GetParameterValue<Guid>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Enables out-of-band management for a zone
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse EnableOutOfBandManagementForZone(EnableOutOfBandManagementForZoneRequest request);
        Task<AsyncJobResponse> EnableOutOfBandManagementForZoneAsync(EnableOutOfBandManagementForZoneRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse EnableOutOfBandManagementForZone(EnableOutOfBandManagementForZoneRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> EnableOutOfBandManagementForZoneAsync(EnableOutOfBandManagementForZoneRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
