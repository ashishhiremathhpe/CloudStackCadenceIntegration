using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateSnapshotFromVMSnapshotRequest : APIRequest
    {
        public CreateSnapshotFromVMSnapshotRequest() : base("createSnapshotFromVMSnapshot") {}

        /// <summary>
        /// The ID of the VM snapshot
        /// </summary>
        public Guid VmSnapshotId {
            get { return GetParameterValue<Guid>(nameof(VmSnapshotId).ToLower()); }
            set { SetParameterValue(nameof(VmSnapshotId).ToLower(), value); }
        }

        /// <summary>
        /// The ID of the disk volume
        /// </summary>
        public Guid VolumeId {
            get { return GetParameterValue<Guid>(nameof(VolumeId).ToLower()); }
            set { SetParameterValue(nameof(VolumeId).ToLower(), value); }
        }

        /// <summary>
        /// the name of the snapshot
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

    }
    /// <summary>
    /// Creates an instant snapshot of a volume from existing vm snapshot.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse CreateSnapshotFromVMSnapshot(CreateSnapshotFromVMSnapshotRequest request);
        Task<AsyncJobResponse> CreateSnapshotFromVMSnapshotAsync(CreateSnapshotFromVMSnapshotRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse CreateSnapshotFromVMSnapshot(CreateSnapshotFromVMSnapshotRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> CreateSnapshotFromVMSnapshotAsync(CreateSnapshotFromVMSnapshotRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
