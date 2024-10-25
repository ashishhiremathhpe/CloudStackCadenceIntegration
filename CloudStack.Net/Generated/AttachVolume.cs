using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AttachVolumeRequest : APIRequest
    {
        public AttachVolumeRequest() : base("attachVolume") {}

        /// <summary>
        /// the ID of the disk volume
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        ///     the ID of the virtual machine
        /// </summary>
        public Guid VirtualMachineId {
            get { return GetParameterValue<Guid>(nameof(VirtualMachineId).ToLower()); }
            set { SetParameterValue(nameof(VirtualMachineId).ToLower(), value); }
        }

        /// <summary>
        /// The ID of the device to map the volume to the guest OS. If no deviceID is informed, the next available deviceID will be chosen. Use 0 when volume needs to be attached as ROOT.<br>When using a linux operating system and the hypervisor XenServer, the devices IDs will be mapped as follows:<ul><li>0 maps to /dev/xvda;</li><li>1 maps to /dev/xvdb;</li><li>2 maps /dev/xvdc and so on.</li></ul>Please refer to the docs of your hypervisor for the correct mapping of the deviceID and the actual logical disk structure.
        /// </summary>
        public long? DeviceId {
            get { return GetParameterValue<long?>(nameof(DeviceId).ToLower()); }
            set { SetParameterValue(nameof(DeviceId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Attaches a disk volume to a virtual machine.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse AttachVolume(AttachVolumeRequest request);
        Task<AsyncJobResponse> AttachVolumeAsync(AttachVolumeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse AttachVolume(AttachVolumeRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> AttachVolumeAsync(AttachVolumeRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
