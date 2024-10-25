using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CancelHostAsDegradedRequest : APIRequest
    {
        public CancelHostAsDegradedRequest() : base("cancelHostAsDegraded") {}

        /// <summary>
        /// host ID
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Cancel host status from 'Degraded'. Host will transit back to status 'Enabled'.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse CancelHostAsDegraded(CancelHostAsDegradedRequest request);
        Task<AsyncJobResponse> CancelHostAsDegradedAsync(CancelHostAsDegradedRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse CancelHostAsDegraded(CancelHostAsDegradedRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> CancelHostAsDegradedAsync(CancelHostAsDegradedRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
