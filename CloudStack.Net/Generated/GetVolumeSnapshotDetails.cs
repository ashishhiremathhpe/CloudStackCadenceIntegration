using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class GetVolumeSnapshotDetailsRequest : APIRequest
    {
        public GetVolumeSnapshotDetailsRequest() : base("getVolumeSnapshotDetails") {}

        /// <summary>
        /// CloudStack Snapshot UUID
        /// </summary>
        public string Snapshotid {
            get { return GetParameterValue<string>(nameof(Snapshotid).ToLower()); }
            set { SetParameterValue(nameof(Snapshotid).ToLower(), value); }
        }

    }
    /// <summary>
    /// Get Volume Snapshot Details
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ApiVolumeiScsiNameResponse GetVolumeSnapshotDetails(GetVolumeSnapshotDetailsRequest request);
        Task<ApiVolumeiScsiNameResponse> GetVolumeSnapshotDetailsAsync(GetVolumeSnapshotDetailsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ApiVolumeiScsiNameResponse GetVolumeSnapshotDetails(GetVolumeSnapshotDetailsRequest request) => Proxy.Request<ApiVolumeiScsiNameResponse>(request);
        public Task<ApiVolumeiScsiNameResponse> GetVolumeSnapshotDetailsAsync(GetVolumeSnapshotDetailsRequest request) => Proxy.RequestAsync<ApiVolumeiScsiNameResponse>(request);
    }
}
