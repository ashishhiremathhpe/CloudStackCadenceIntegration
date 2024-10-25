using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ScaleVirtualMachineRequest : APIRequest
    {
        public ScaleVirtualMachineRequest() : base("scaleVirtualMachine") {}

        /// <summary>
        /// The ID of the virtual machine
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the service offering for the virtual machine
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
    /// Scales the virtual machine to a new service offering. This command also considers the volume size in the service offering or disk offering linked to the new service offering and apply all characteristics to the root volume.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse ScaleVirtualMachine(ScaleVirtualMachineRequest request);
        Task<AsyncJobResponse> ScaleVirtualMachineAsync(ScaleVirtualMachineRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse ScaleVirtualMachine(ScaleVirtualMachineRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> ScaleVirtualMachineAsync(ScaleVirtualMachineRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
