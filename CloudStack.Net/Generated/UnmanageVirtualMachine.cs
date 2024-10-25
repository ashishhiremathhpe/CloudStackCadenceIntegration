using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UnmanageVirtualMachineRequest : APIRequest
    {
        public UnmanageVirtualMachineRequest() : base("unmanageVirtualMachine") {}

        /// <summary>
        /// The ID of the virtual machine to unmanage
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Unmanage a guest virtual machine.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse UnmanageVirtualMachine(UnmanageVirtualMachineRequest request);
        Task<AsyncJobResponse> UnmanageVirtualMachineAsync(UnmanageVirtualMachineRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse UnmanageVirtualMachine(UnmanageVirtualMachineRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> UnmanageVirtualMachineAsync(UnmanageVirtualMachineRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
