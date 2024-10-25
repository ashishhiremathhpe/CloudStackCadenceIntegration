using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListZonesMetricsRequest : APIListRequest
    {
        public ListZonesMetricsRequest() : base("listZonesMetrics") {}

        /// <summary>
        /// true if you want to retrieve all available Zones. False if you only want to return the Zones from which you have at least one VM. Default is false.
        /// </summary>
        public bool? Available {
            get { return GetParameterValue<bool?>(nameof(Available).ToLower()); }
            set { SetParameterValue(nameof(Available).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the domain associated with the zone
        /// </summary>
        public Guid? DomainId {
            get { return GetParameterValue<Guid?>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the zone
        /// </summary>
        public Guid? Id {
            get { return GetParameterValue<Guid?>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// the IDs of the zones, mutually exclusive with id
        /// </summary>
        public IList<Guid> Ids {
            get { return GetList<Guid>(nameof(Ids).ToLower()); }
            set { SetParameterValue(nameof(Ids).ToLower(), value); }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// the name of the zone
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// the network type of the zone that the virtual machine belongs to
        /// </summary>
        public string NetworkType {
            get { return GetParameterValue<string>(nameof(NetworkType).ToLower()); }
            set { SetParameterValue(nameof(NetworkType).ToLower(), value); }
        }

        /// <summary>
        /// flag to display the capacity of the zones
        /// </summary>
        public bool? ShowCapacities {
            get { return GetParameterValue<bool?>(nameof(ShowCapacities).ToLower()); }
            set { SetParameterValue(nameof(ShowCapacities).ToLower(), value); }
        }

        /// <summary>
        /// flag to display the resource image for the zones
        /// </summary>
        public bool? ShowIcon {
            get { return GetParameterValue<bool?>(nameof(ShowIcon).ToLower()); }
            set { SetParameterValue(nameof(ShowIcon).ToLower(), value); }
        }

        /// <summary>
        /// List zones by resource tags (key/value pairs)
        /// </summary>
        public IList<IDictionary<string, object>> Tags {
            get { return GetList<IDictionary<string, object>>(nameof(Tags).ToLower()); }
            set { SetParameterValue(nameof(Tags).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists zone metrics
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<ZoneMetricsResponse> ListZonesMetrics(ListZonesMetricsRequest request);
        Task<ListResponse<ZoneMetricsResponse>> ListZonesMetricsAsync(ListZonesMetricsRequest request);
        ListResponse<ZoneMetricsResponse> ListZonesMetricsAllPages(ListZonesMetricsRequest request);
        Task<ListResponse<ZoneMetricsResponse>> ListZonesMetricsAllPagesAsync(ListZonesMetricsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<ZoneMetricsResponse> ListZonesMetrics(ListZonesMetricsRequest request) => Proxy.Request<ListResponse<ZoneMetricsResponse>>(request);
        public Task<ListResponse<ZoneMetricsResponse>> ListZonesMetricsAsync(ListZonesMetricsRequest request) => Proxy.RequestAsync<ListResponse<ZoneMetricsResponse>>(request);
        public ListResponse<ZoneMetricsResponse> ListZonesMetricsAllPages(ListZonesMetricsRequest request) => Proxy.RequestAllPages<ZoneMetricsResponse>(request);
        public Task<ListResponse<ZoneMetricsResponse>> ListZonesMetricsAllPagesAsync(ListZonesMetricsRequest request) => Proxy.RequestAllPagesAsync<ZoneMetricsResponse>(request);
    }
}
