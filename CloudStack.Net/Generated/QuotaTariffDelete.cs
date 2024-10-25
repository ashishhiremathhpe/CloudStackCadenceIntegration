using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class QuotaTariffDeleteRequest : APIRequest
    {
        public QuotaTariffDeleteRequest() : base("quotaTariffDelete") {}

        /// <summary>
        /// ID of the quota tariff
        /// </summary>
        public string Id {
            get { return GetParameterValue<string>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Marks a quota tariff as removed.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse QuotaTariffDelete(QuotaTariffDeleteRequest request);
        Task<SuccessResponse> QuotaTariffDeleteAsync(QuotaTariffDeleteRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse QuotaTariffDelete(QuotaTariffDeleteRequest request) => Proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> QuotaTariffDeleteAsync(QuotaTariffDeleteRequest request) => Proxy.RequestAsync<SuccessResponse>(request);
    }
}
