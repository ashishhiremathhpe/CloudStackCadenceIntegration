using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ResetApiLimitRequest : APIRequest
    {
        public ResetApiLimitRequest() : base("resetApiLimit") {}

        /// <summary>
        /// the ID of the account whose limit to be reset
        /// </summary>
        public Guid? Account {
            get { return GetParameterValue<Guid?>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

    }
    /// <summary>
    /// Reset api count
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse ResetApiLimit(ResetApiLimitRequest request);
        Task<SuccessResponse> ResetApiLimitAsync(ResetApiLimitRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse ResetApiLimit(ResetApiLimitRequest request) => Proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> ResetApiLimitAsync(ResetApiLimitRequest request) => Proxy.RequestAsync<SuccessResponse>(request);
    }
}
