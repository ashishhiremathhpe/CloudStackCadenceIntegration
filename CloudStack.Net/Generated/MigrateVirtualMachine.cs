using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class MigrateVirtualMachineRequest : APIRequest
    {
        public MigrateVirtualMachineRequest() : base("migrateVirtualMachine") {}

        /// <summary>
        /// the ID of the virtual machine
        /// </summary>
        public Guid VirtualMachineId {
            get { return GetParameterValue<Guid>(nameof(VirtualMachineId).ToLower()); }
            set { SetParameterValue(nameof(VirtualMachineId).ToLower(), value); }
        }

        /// <summary>
        /// Automatically select a destination host which do not require storage migration, if hostId and storageId are not specified. false by default
        /// </summary>
        public bool? AutoSelect {
            get { return GetParameterValue<bool?>(nameof(AutoSelect).ToLower()); }
            set { SetParameterValue(nameof(AutoSelect).ToLower(), value); }
        }

        /// <summary>
        /// Destination Host ID to migrate VM to.
        /// </summary>
        public Guid? HostId {
            get { return GetParameterValue<Guid?>(nameof(HostId).ToLower()); }
            set { SetParameterValue(nameof(HostId).ToLower(), value); }
        }

        /// <summary>
        /// Destination storage pool ID to migrate VM volumes to. Required for migrating the root disk volume
        /// </summary>
        public Guid? StorageId {
            get { return GetParameterValue<Guid?>(nameof(StorageId).ToLower()); }
            set { SetParameterValue(nameof(StorageId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Attempts Migration of a VM to a different host or Root volume of the vm to a different storage pool
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse MigrateVirtualMachine(MigrateVirtualMachineRequest request);
        Task<AsyncJobResponse> MigrateVirtualMachineAsync(MigrateVirtualMachineRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse MigrateVirtualMachine(MigrateVirtualMachineRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> MigrateVirtualMachineAsync(MigrateVirtualMachineRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
