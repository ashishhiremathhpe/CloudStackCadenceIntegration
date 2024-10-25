using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListGuestVlansRequest : APIListRequest
    {
        public ListGuestVlansRequest() : base("listGuestVlans") {}

        /// <summary>
        /// limits search results to allocated guest vlan. false by default.
        /// </summary>
        public bool? AllocatedOnly {
            get { return GetParameterValue<bool?>(nameof(AllocatedOnly).ToLower()); }
            set { SetParameterValue(nameof(AllocatedOnly).ToLower(), value); }
        }

        /// <summary>
        /// list guest vlan by id
        /// </summary>
        public long? Id {
            get { return GetParameterValue<long?>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// list guest vlan by physical network
        /// </summary>
        public Guid? PhysicalNetworkId {
            get { return GetParameterValue<Guid?>(nameof(PhysicalNetworkId).ToLower()); }
            set { SetParameterValue(nameof(PhysicalNetworkId).ToLower(), value); }
        }

        /// <summary>
        /// list guest vlan by vnet
        /// </summary>
        public string Vnet {
            get { return GetParameterValue<string>(nameof(Vnet).ToLower()); }
            set { SetParameterValue(nameof(Vnet).ToLower(), value); }
        }

        /// <summary>
        /// list guest vlan by zone
        /// </summary>
        public Guid? ZoneId {
            get { return GetParameterValue<Guid?>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists all guest vlans
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<GuestVlanResponse> ListGuestVlans(ListGuestVlansRequest request);
        Task<ListResponse<GuestVlanResponse>> ListGuestVlansAsync(ListGuestVlansRequest request);
        ListResponse<GuestVlanResponse> ListGuestVlansAllPages(ListGuestVlansRequest request);
        Task<ListResponse<GuestVlanResponse>> ListGuestVlansAllPagesAsync(ListGuestVlansRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<GuestVlanResponse> ListGuestVlans(ListGuestVlansRequest request) => Proxy.Request<ListResponse<GuestVlanResponse>>(request);
        public Task<ListResponse<GuestVlanResponse>> ListGuestVlansAsync(ListGuestVlansRequest request) => Proxy.RequestAsync<ListResponse<GuestVlanResponse>>(request);
        public ListResponse<GuestVlanResponse> ListGuestVlansAllPages(ListGuestVlansRequest request) => Proxy.RequestAllPages<GuestVlanResponse>(request);
        public Task<ListResponse<GuestVlanResponse>> ListGuestVlansAllPagesAsync(ListGuestVlansRequest request) => Proxy.RequestAllPagesAsync<GuestVlanResponse>(request);
    }
}
