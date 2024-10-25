using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class NotifyBaremetalProvisionDoneRequest : APIRequest
    {
        public NotifyBaremetalProvisionDoneRequest() : base("notifyBaremetalProvisionDone") {}

        /// <summary>
        /// mac of the nic used for provision
        /// </summary>
        public String Mac {
            get { return GetParameterValue<String>(nameof(Mac).ToLower()); }
            set { SetParameterValue(nameof(Mac).ToLower(), value); }
        }

    }
    /// <summary>
    /// Notify provision has been done on a host. This api is for baremetal virtual router service, not for end user
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse NotifyBaremetalProvisionDone(NotifyBaremetalProvisionDoneRequest request);
        Task<AsyncJobResponse> NotifyBaremetalProvisionDoneAsync(NotifyBaremetalProvisionDoneRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse NotifyBaremetalProvisionDone(NotifyBaremetalProvisionDoneRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> NotifyBaremetalProvisionDoneAsync(NotifyBaremetalProvisionDoneRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
