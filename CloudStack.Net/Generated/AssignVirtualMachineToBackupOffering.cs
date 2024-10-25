using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AssignVirtualMachineToBackupOfferingRequest : APIRequest
    {
        public AssignVirtualMachineToBackupOfferingRequest() : base("assignVirtualMachineToBackupOffering") {}

        /// <summary>
        /// ID of the backup offering
        /// </summary>
        public Guid Backupofferingid {
            get { return GetParameterValue<Guid>(nameof(Backupofferingid).ToLower()); }
            set { SetParameterValue(nameof(Backupofferingid).ToLower(), value); }
        }

        /// <summary>
        /// ID of the virtual machine
        /// </summary>
        public Guid Virtualmachineid {
            get { return GetParameterValue<Guid>(nameof(Virtualmachineid).ToLower()); }
            set { SetParameterValue(nameof(Virtualmachineid).ToLower(), value); }
        }

    }
    /// <summary>
    /// Assigns a VM to a backup offering
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse AssignVirtualMachineToBackupOffering(AssignVirtualMachineToBackupOfferingRequest request);
        Task<AsyncJobResponse> AssignVirtualMachineToBackupOfferingAsync(AssignVirtualMachineToBackupOfferingRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse AssignVirtualMachineToBackupOffering(AssignVirtualMachineToBackupOfferingRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> AssignVirtualMachineToBackupOfferingAsync(AssignVirtualMachineToBackupOfferingRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
