using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeclareHostAsDegradedRequest : APIRequest
    {
        public DeclareHostAsDegradedRequest() : base("declareHostAsDegraded") {}

        /// <summary>
        /// host ID
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Declare host as 'Degraded'. Host must be on 'Disconnected' or 'Alert' state. The ADMIN must be sure that there are no VMs running on the respective host otherwise this command might corrupted VMs that were running on the 'Degraded' host.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeclareHostAsDegraded(DeclareHostAsDegradedRequest request);
        Task<AsyncJobResponse> DeclareHostAsDegradedAsync(DeclareHostAsDegradedRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeclareHostAsDegraded(DeclareHostAsDegradedRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DeclareHostAsDegradedAsync(DeclareHostAsDegradedRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
