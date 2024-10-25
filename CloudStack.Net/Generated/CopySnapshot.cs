using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CopySnapshotRequest : APIRequest
    {
        public CopySnapshotRequest() : base("copySnapshot") {}

        /// <summary>
        /// the ID of the snapshot.
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// The ID of the zone the snapshot is being copied to.
        /// </summary>
        public Guid? DestZoneId {
            get { return GetParameterValue<Guid?>(nameof(DestZoneId).ToLower()); }
            set { SetParameterValue(nameof(DestZoneId).ToLower(), value); }
        }

        /// <summary>
        /// A comma-separated list of IDs of the zones that the snapshot needs to be copied to. Specify this list if the snapshot needs to copied to multiple zones in one go. Do not specify destzoneid and destzoneids together, however one of them is required.
        /// </summary>
        public IList<Guid> DestZoneIds {
            get { return GetList<Guid>(nameof(DestZoneIds).ToLower()); }
            set { SetParameterValue(nameof(DestZoneIds).ToLower(), value); }
        }

        /// <summary>
        /// The ID of the zone in which the snapshot is currently present. If not specified then the zone of snapshot's volume will be used.
        /// </summary>
        public Guid? SourceZoneId {
            get { return GetParameterValue<Guid?>(nameof(SourceZoneId).ToLower()); }
            set { SetParameterValue(nameof(SourceZoneId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Copies a snapshot from one zone to another.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse CopySnapshot(CopySnapshotRequest request);
        Task<AsyncJobResponse> CopySnapshotAsync(CopySnapshotRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse CopySnapshot(CopySnapshotRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> CopySnapshotAsync(CopySnapshotRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
