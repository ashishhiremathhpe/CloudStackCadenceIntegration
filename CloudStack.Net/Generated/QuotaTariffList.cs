using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class QuotaTariffListRequest : APIListRequest
    {
        public QuotaTariffListRequest() : base("quotaTariffList") {}

        /// <summary>
        /// The end date of the quota tariff. Use yyyy-MM-dd as the date format, e.g. endDate=2021-11-03.
        /// </summary>
        public DateTime? EndDate {
            get { return GetParameterValue<DateTime?>(nameof(EndDate).ToLower()); }
            set { SetParameterValue(nameof(EndDate).ToLower(), value); }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// False will list only not removed quota tariffs. If set to True, we will list all, including the removed ones. The default is false.
        /// </summary>
        public bool? ListAll {
            get { return GetParameterValue<bool?>(nameof(ListAll).ToLower()); }
            set { SetParameterValue(nameof(ListAll).ToLower(), value); }
        }

        /// <summary>
        /// The name of the quota tariff.
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// The start date of the quota tariff. Use yyyy-MM-dd as the date format, e.g. startDate=2009-06-03.
        /// </summary>
        public DateTime? Startdate {
            get { return GetParameterValue<DateTime?>(nameof(Startdate).ToLower()); }
            set { SetParameterValue(nameof(Startdate).ToLower(), value); }
        }

        /// <summary>
        /// Usage type of the resource
        /// </summary>
        public int? UsageType {
            get { return GetParameterValue<int?>(nameof(UsageType).ToLower()); }
            set { SetParameterValue(nameof(UsageType).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists all quota tariff plans
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<QuotaTariffResponse> QuotaTariffList(QuotaTariffListRequest request);
        Task<ListResponse<QuotaTariffResponse>> QuotaTariffListAsync(QuotaTariffListRequest request);
        ListResponse<QuotaTariffResponse> QuotaTariffListAllPages(QuotaTariffListRequest request);
        Task<ListResponse<QuotaTariffResponse>> QuotaTariffListAllPagesAsync(QuotaTariffListRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<QuotaTariffResponse> QuotaTariffList(QuotaTariffListRequest request) => Proxy.Request<ListResponse<QuotaTariffResponse>>(request);
        public Task<ListResponse<QuotaTariffResponse>> QuotaTariffListAsync(QuotaTariffListRequest request) => Proxy.RequestAsync<ListResponse<QuotaTariffResponse>>(request);
        public ListResponse<QuotaTariffResponse> QuotaTariffListAllPages(QuotaTariffListRequest request) => Proxy.RequestAllPages<QuotaTariffResponse>(request);
        public Task<ListResponse<QuotaTariffResponse>> QuotaTariffListAllPagesAsync(QuotaTariffListRequest request) => Proxy.RequestAllPagesAsync<QuotaTariffResponse>(request);
    }
}
