using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class MigrateSystemVmRequest : APIRequest
    {
        public MigrateSystemVmRequest() : base("migrateSystemVm") {}

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
        /// destination Host ID to migrate VM to
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
    /// Attempts Migration of a system virtual machine to the host specified.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse MigrateSystemVm(MigrateSystemVmRequest request);
        Task<AsyncJobResponse> MigrateSystemVmAsync(MigrateSystemVmRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse MigrateSystemVm(MigrateSystemVmRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> MigrateSystemVmAsync(MigrateSystemVmRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
