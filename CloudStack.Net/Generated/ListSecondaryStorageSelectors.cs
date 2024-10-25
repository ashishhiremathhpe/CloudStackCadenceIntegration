using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListSecondaryStorageSelectorsRequest : APIListRequest
    {
        public ListSecondaryStorageSelectorsRequest() : base("listSecondaryStorageSelectors") {}

        /// <summary>
        /// The zone ID to be used in the search filter.
        /// </summary>
        public Guid ZoneId {
            get { return GetParameterValue<Guid>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// Show removed heuristics.
        /// </summary>
        public bool? ShowRemoved {
            get { return GetParameterValue<bool?>(nameof(ShowRemoved).ToLower()); }
            set { SetParameterValue(nameof(ShowRemoved).ToLower(), value); }
        }

        /// <summary>
        /// Whether to filter the selectors by type and, if so, which one. Valid options are: ISO, SNAPSHOT, TEMPLATE and VOLUME.
        /// </summary>
        public string Type {
            get { return GetParameterValue<string>(nameof(Type).ToLower()); }
            set { SetParameterValue(nameof(Type).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists the secondary storage selectors and their rules.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<SecondaryStorageHeuristicsResponse> ListSecondaryStorageSelectors(ListSecondaryStorageSelectorsRequest request);
        Task<ListResponse<SecondaryStorageHeuristicsResponse>> ListSecondaryStorageSelectorsAsync(ListSecondaryStorageSelectorsRequest request);
        ListResponse<SecondaryStorageHeuristicsResponse> ListSecondaryStorageSelectorsAllPages(ListSecondaryStorageSelectorsRequest request);
        Task<ListResponse<SecondaryStorageHeuristicsResponse>> ListSecondaryStorageSelectorsAllPagesAsync(ListSecondaryStorageSelectorsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<SecondaryStorageHeuristicsResponse> ListSecondaryStorageSelectors(ListSecondaryStorageSelectorsRequest request) => Proxy.Request<ListResponse<SecondaryStorageHeuristicsResponse>>(request);
        public Task<ListResponse<SecondaryStorageHeuristicsResponse>> ListSecondaryStorageSelectorsAsync(ListSecondaryStorageSelectorsRequest request) => Proxy.RequestAsync<ListResponse<SecondaryStorageHeuristicsResponse>>(request);
        public ListResponse<SecondaryStorageHeuristicsResponse> ListSecondaryStorageSelectorsAllPages(ListSecondaryStorageSelectorsRequest request) => Proxy.RequestAllPages<SecondaryStorageHeuristicsResponse>(request);
        public Task<ListResponse<SecondaryStorageHeuristicsResponse>> ListSecondaryStorageSelectorsAllPagesAsync(ListSecondaryStorageSelectorsRequest request) => Proxy.RequestAllPagesAsync<SecondaryStorageHeuristicsResponse>(request);
    }
}
