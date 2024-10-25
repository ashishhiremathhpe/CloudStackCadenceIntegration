using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ChangeServiceForVirtualMachineRequest : APIRequest
    {
        public ChangeServiceForVirtualMachineRequest() : base("changeServiceForVirtualMachine") {}

        /// <summary>
        /// The ID of the virtual machine
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// the service offering ID to apply to the virtual machine
        /// </summary>
        public Guid ServiceOfferingId {
            get { return GetParameterValue<Guid>(nameof(ServiceOfferingId).ToLower()); }
            set { SetParameterValue(nameof(ServiceOfferingId).ToLower(), value); }
        }

        /// <summary>
        /// Flag for automatic migration of the root volume with new compute offering whenever migration is required to apply the offering
        /// </summary>
        public bool? AutoMigrate {
            get { return GetParameterValue<bool?>(nameof(AutoMigrate).ToLower()); }
            set { SetParameterValue(nameof(AutoMigrate).ToLower(), value); }
        }

        /// <summary>
        /// name value pairs of custom parameters for cpuspeed, memory and cpunumber. example details[i].name=value
        /// </summary>
        public IList<IDictionary<string, object>> Details {
            get { return GetList<IDictionary<string, object>>(nameof(Details).ToLower()); }
            set { SetParameterValue(nameof(Details).ToLower(), value); }
        }

        /// <summary>
        /// New maximum number of IOPS for the custom disk offering
        /// </summary>
        public long? MaxIops {
            get { return GetParameterValue<long?>(nameof(MaxIops).ToLower()); }
            set { SetParameterValue(nameof(MaxIops).ToLower(), value); }
        }

        /// <summary>
        /// New minimum number of IOPS for the custom disk offering
        /// </summary>
        public long? MinIops {
            get { return GetParameterValue<long?>(nameof(MinIops).ToLower()); }
            set { SetParameterValue(nameof(MinIops).ToLower(), value); }
        }

        /// <summary>
        /// Verify OK to Shrink
        /// </summary>
        public bool? ShrinkOk {
            get { return GetParameterValue<bool?>(nameof(ShrinkOk).ToLower()); }
            set { SetParameterValue(nameof(ShrinkOk).ToLower(), value); }
        }

    }
    /// <summary>
    /// (This API is deprecated, use scaleVirtualMachine API)Changes the service offering for a virtual machine. The virtual machine must be in a "Stopped" state for this command to take effect.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        UserVmResponse ChangeServiceForVirtualMachine(ChangeServiceForVirtualMachineRequest request);
        Task<UserVmResponse> ChangeServiceForVirtualMachineAsync(ChangeServiceForVirtualMachineRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public UserVmResponse ChangeServiceForVirtualMachine(ChangeServiceForVirtualMachineRequest request) => Proxy.Request<UserVmResponse>(request);
        public Task<UserVmResponse> ChangeServiceForVirtualMachineAsync(ChangeServiceForVirtualMachineRequest request) => Proxy.RequestAsync<UserVmResponse>(request);
    }
}
