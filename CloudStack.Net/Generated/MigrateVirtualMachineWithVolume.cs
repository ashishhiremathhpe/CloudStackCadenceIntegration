using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class MigrateVirtualMachineWithVolumeRequest : APIRequest
    {
        public MigrateVirtualMachineWithVolumeRequest() : base("migrateVirtualMachineWithVolume") {}

        /// <summary>
        /// the ID of the virtual machine
        /// </summary>
        public Guid VirtualMachineId {
            get { return GetParameterValue<Guid>(nameof(VirtualMachineId).ToLower()); }
            set { SetParameterValue(nameof(VirtualMachineId).ToLower(), value); }
        }

        /// <summary>
        /// Automatically select a destination host for a running instance, if hostId is not specified. false by default
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
        /// Storage to pool mapping. This parameter specifies the mapping between a volume and a pool where you want to migrate that volume. Format of this parameter: migrateto[volume-index].volume=<uuid>&migrateto[volume-index].pool=<uuid>Where, [volume-index] indicates the index to identify the volume that you want to migrate, volume=<uuid> indicates the UUID of the volume that you want to migrate, and pool=<uuid> indicates the UUID of the pool where you want to migrate the volume. Example: migrateto[0].volume=<71f43cd6-69b0-4d3b-9fbc-67f50963d60b>&migrateto[0].pool=<a382f181-3d2b-4413-b92d-b8931befa7e1>&migrateto[1].volume=<88de0173-55c0-4c1c-a269-83d0279eeedf>&migrateto[1].pool=<95d6e97c-6766-4d67-9a30-c449c15011d1>&migrateto[2].volume=<1b331390-59f2-4796-9993-bf11c6e76225>&migrateto[2].pool=<41fdb564-9d3b-447d-88ed-7628f7640cbc>
        /// </summary>
        public IList<IDictionary<string, object>> Migrateto {
            get { return GetList<IDictionary<string, object>>(nameof(Migrateto).ToLower()); }
            set { SetParameterValue(nameof(Migrateto).ToLower(), value); }
        }

    }
    /// <summary>
    /// Attempts Migration of a VM with its volumes to a different host
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse MigrateVirtualMachineWithVolume(MigrateVirtualMachineWithVolumeRequest request);
        Task<AsyncJobResponse> MigrateVirtualMachineWithVolumeAsync(MigrateVirtualMachineWithVolumeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse MigrateVirtualMachineWithVolume(MigrateVirtualMachineWithVolumeRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> MigrateVirtualMachineWithVolumeAsync(MigrateVirtualMachineWithVolumeRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
