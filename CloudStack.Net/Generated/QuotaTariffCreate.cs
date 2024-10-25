using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class QuotaTariffCreateRequest : APIRequest
    {
        public QuotaTariffCreateRequest() : base("quotaTariffCreate") {}

        /// <summary>
        /// Quota tariff's name
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// Integer value for the usage type of the resource.
        /// </summary>
        public int? UsageType {
            get { return GetParameterValue<int?>(nameof(UsageType).ToLower()); }
            set { SetParameterValue(nameof(UsageType).ToLower(), value); }
        }

        /// <summary>
        /// The quota tariff value of the resource as per the default unit.
        /// </summary>
        public Double Value {
            get { return GetParameterValue<Double>(nameof(Value).ToLower()); }
            set { SetParameterValue(nameof(Value).ToLower(), value); }
        }

        /// <summary>
        /// Quota tariff's activation rule. It can receive a JS script that results in either a boolean or a numeric value: if it results in a boolean value, the tariff value will be applied according to the result; if it results in a numeric value, the numeric value will be applied; if the result is neither a boolean nor a numeric value, the tariff will not be applied. If the rule is not informed, the tariff value will be applied.
        /// </summary>
        public string ActivationRule {
            get { return GetParameterValue<string>(nameof(ActivationRule).ToLower()); }
            set { SetParameterValue(nameof(ActivationRule).ToLower(), value); }
        }

        /// <summary>
        /// Quota tariff's description.
        /// </summary>
        public string Description {
            get { return GetParameterValue<string>(nameof(Description).ToLower()); }
            set { SetParameterValue(nameof(Description).ToLower(), value); }
        }

        /// <summary>
        /// The end date of the quota tariff. Use yyyy-MM-dd as the date format, e.g. endDate=2009-06-03.
        /// </summary>
        public DateTime? EndDate {
            get { return GetParameterValue<DateTime?>(nameof(EndDate).ToLower()); }
            set { SetParameterValue(nameof(EndDate).ToLower(), value); }
        }

        /// <summary>
        /// The effective start date on/after which the quota tariff is effective. Use yyyy-MM-dd as the date format, e.g. startDate=2009-06-03. Inform null to use the current date.
        /// </summary>
        public DateTime? StartDate {
            get { return GetParameterValue<DateTime?>(nameof(StartDate).ToLower()); }
            set { SetParameterValue(nameof(StartDate).ToLower(), value); }
        }

    }
    /// <summary>
    /// Creates a quota tariff for a resource.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        QuotaTariffResponse QuotaTariffCreate(QuotaTariffCreateRequest request);
        Task<QuotaTariffResponse> QuotaTariffCreateAsync(QuotaTariffCreateRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public QuotaTariffResponse QuotaTariffCreate(QuotaTariffCreateRequest request) => Proxy.Request<QuotaTariffResponse>(request);
        public Task<QuotaTariffResponse> QuotaTariffCreateAsync(QuotaTariffCreateRequest request) => Proxy.RequestAsync<QuotaTariffResponse>(request);
    }
}
