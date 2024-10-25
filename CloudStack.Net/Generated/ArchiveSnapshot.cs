using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ArchiveSnapshotRequest : APIRequest
    {
        public ArchiveSnapshotRequest() : base("archiveSnapshot") {}

        /// <summary>
        /// The ID of the snapshot
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Archives (moves) a snapshot on primary storage to secondary storage
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse ArchiveSnapshot(ArchiveSnapshotRequest request);
        Task<AsyncJobResponse> ArchiveSnapshotAsync(ArchiveSnapshotRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse ArchiveSnapshot(ArchiveSnapshotRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> ArchiveSnapshotAsync(ArchiveSnapshotRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
