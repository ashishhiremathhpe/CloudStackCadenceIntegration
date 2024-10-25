using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class RestoreVolumeFromBackupAndAttachToVMRequest : APIRequest
    {
        public RestoreVolumeFromBackupAndAttachToVMRequest() : base("restoreVolumeFromBackupAndAttachToVM") {}

        /// <summary>
        /// ID of the VM backup
        /// </summary>
        public Guid BackupId {
            get { return GetParameterValue<Guid>(nameof(BackupId).ToLower()); }
            set { SetParameterValue(nameof(BackupId).ToLower(), value); }
        }

        /// <summary>
        /// id of the VM where to attach the restored volume
        /// </summary>
        public Guid Virtualmachineid {
            get { return GetParameterValue<Guid>(nameof(Virtualmachineid).ToLower()); }
            set { SetParameterValue(nameof(Virtualmachineid).ToLower(), value); }
        }

        /// <summary>
        /// ID of the volume backed up
        /// </summary>
        public string Volumeid {
            get { return GetParameterValue<string>(nameof(Volumeid).ToLower()); }
            set { SetParameterValue(nameof(Volumeid).ToLower(), value); }
        }

    }
    /// <summary>
    /// Restore and attach a backed up volume to VM
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse RestoreVolumeFromBackupAndAttachToVM(RestoreVolumeFromBackupAndAttachToVMRequest request);
        Task<AsyncJobResponse> RestoreVolumeFromBackupAndAttachToVMAsync(RestoreVolumeFromBackupAndAttachToVMRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse RestoreVolumeFromBackupAndAttachToVM(RestoreVolumeFromBackupAndAttachToVMRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> RestoreVolumeFromBackupAndAttachToVMAsync(RestoreVolumeFromBackupAndAttachToVMRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
