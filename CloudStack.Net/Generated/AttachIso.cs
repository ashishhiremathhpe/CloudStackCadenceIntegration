using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AttachIsoRequest : APIRequest
    {
        public AttachIsoRequest() : base("attachIso") {}

        /// <summary>
        /// the ID of the ISO file
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the virtual machine
        /// </summary>
        public Guid VirtualMachineId {
            get { return GetParameterValue<Guid>(nameof(VirtualMachineId).ToLower()); }
            set { SetParameterValue(nameof(VirtualMachineId).ToLower(), value); }
        }

        /// <summary>
        /// If true, ejects existing ISO before attaching on VMware. Default: false
        /// </summary>
        public bool? Forced {
            get { return GetParameterValue<bool?>(nameof(Forced).ToLower()); }
            set { SetParameterValue(nameof(Forced).ToLower(), value); }
        }

    }
    /// <summary>
    /// Attaches an ISO to a virtual machine.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse AttachIso(AttachIsoRequest request);
        Task<AsyncJobResponse> AttachIsoAsync(AttachIsoRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse AttachIso(AttachIsoRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> AttachIsoAsync(AttachIsoRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
