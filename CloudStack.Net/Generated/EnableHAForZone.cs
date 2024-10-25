using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class EnableHAForZoneRequest : APIRequest
    {
        public EnableHAForZoneRequest() : base("enableHAForZone") {}

        /// <summary>
        /// ID of the zone
        /// </summary>
        public Guid ZoneId {
            get { return GetParameterValue<Guid>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Enables HA for a zone
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse EnableHAForZone(EnableHAForZoneRequest request);
        Task<AsyncJobResponse> EnableHAForZoneAsync(EnableHAForZoneRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse EnableHAForZone(EnableHAForZoneRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> EnableHAForZoneAsync(EnableHAForZoneRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
