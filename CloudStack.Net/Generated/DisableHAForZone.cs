using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DisableHAForZoneRequest : APIRequest
    {
        public DisableHAForZoneRequest() : base("disableHAForZone") {}

        /// <summary>
        /// ID of the zone
        /// </summary>
        public Guid ZoneId {
            get { return GetParameterValue<Guid>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Disables HA for a zone
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DisableHAForZone(DisableHAForZoneRequest request);
        Task<AsyncJobResponse> DisableHAForZoneAsync(DisableHAForZoneRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DisableHAForZone(DisableHAForZoneRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DisableHAForZoneAsync(DisableHAForZoneRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
