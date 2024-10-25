using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class RemoveVirtualMachineFromBackupOfferingRequest : APIRequest
    {
        public RemoveVirtualMachineFromBackupOfferingRequest() : base("removeVirtualMachineFromBackupOffering") {}

        /// <summary>
        /// ID of the virtual machine
        /// </summary>
        public Guid Virtualmachineid {
            get { return GetParameterValue<Guid>(nameof(Virtualmachineid).ToLower()); }
            set { SetParameterValue(nameof(Virtualmachineid).ToLower(), value); }
        }

        /// <summary>
        /// Whether to force remove VM from the backup offering that may also delete VM backups.
        /// </summary>
        public bool? Forced {
            get { return GetParameterValue<bool?>(nameof(Forced).ToLower()); }
            set { SetParameterValue(nameof(Forced).ToLower(), value); }
        }

    }
    /// <summary>
    /// Removes a VM from any existing backup offering
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse RemoveVirtualMachineFromBackupOffering(RemoveVirtualMachineFromBackupOfferingRequest request);
        Task<AsyncJobResponse> RemoveVirtualMachineFromBackupOfferingAsync(RemoveVirtualMachineFromBackupOfferingRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse RemoveVirtualMachineFromBackupOffering(RemoveVirtualMachineFromBackupOfferingRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> RemoveVirtualMachineFromBackupOfferingAsync(RemoveVirtualMachineFromBackupOfferingRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
