using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class PatchSystemVmRequest : APIRequest
    {
        public PatchSystemVmRequest() : base("patchSystemVm") {}

        /// <summary>
        /// If true, initiates copy of scripts and restart of the agent, even if the scripts version matches.To be used with ID parameter only
        /// </summary>
        public bool? Forced {
            get { return GetParameterValue<bool?>(nameof(Forced).ToLower()); }
            set { SetParameterValue(nameof(Forced).ToLower(), value); }
        }

        /// <summary>
        /// patches systemVM - CPVM/SSVM with the specified ID
        /// </summary>
        public Guid? Id {
            get { return GetParameterValue<Guid?>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Attempts to live patch systemVMs - CPVM, SSVM 
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse PatchSystemVm(PatchSystemVmRequest request);
        Task<AsyncJobResponse> PatchSystemVmAsync(PatchSystemVmRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse PatchSystemVm(PatchSystemVmRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> PatchSystemVmAsync(PatchSystemVmRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
