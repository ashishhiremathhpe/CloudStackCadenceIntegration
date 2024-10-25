using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListTungstenFabricNetworkRequest : APIListRequest
    {
        public ListTungstenFabricNetworkRequest() : base("listTungstenFabricNetwork") {}

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// If set to false, list only resources belonging to the command's caller; if set to true - list resources that include public network. Default value is false
        /// </summary>
        public bool? ListAll {
            get { return GetParameterValue<bool?>(nameof(ListAll).ToLower()); }
            set { SetParameterValue(nameof(ListAll).ToLower(), value); }
        }

        /// <summary>
        /// the uuid of Tungsten-Fabric network
        /// </summary>
        public string NetworkUuid {
            get { return GetParameterValue<string>(nameof(NetworkUuid).ToLower()); }
            set { SetParameterValue(nameof(NetworkUuid).ToLower(), value); }
        }

        /// <summary>
        /// the ID of zone
        /// </summary>
        public Guid? ZoneId {
            get { return GetParameterValue<Guid?>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

    }
    /// <summary>
    /// list Tungsten-Fabric network
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<TungstenFabricNetworkResponse> ListTungstenFabricNetwork(ListTungstenFabricNetworkRequest request);
        Task<ListResponse<TungstenFabricNetworkResponse>> ListTungstenFabricNetworkAsync(ListTungstenFabricNetworkRequest request);
        ListResponse<TungstenFabricNetworkResponse> ListTungstenFabricNetworkAllPages(ListTungstenFabricNetworkRequest request);
        Task<ListResponse<TungstenFabricNetworkResponse>> ListTungstenFabricNetworkAllPagesAsync(ListTungstenFabricNetworkRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<TungstenFabricNetworkResponse> ListTungstenFabricNetwork(ListTungstenFabricNetworkRequest request) => Proxy.Request<ListResponse<TungstenFabricNetworkResponse>>(request);
        public Task<ListResponse<TungstenFabricNetworkResponse>> ListTungstenFabricNetworkAsync(ListTungstenFabricNetworkRequest request) => Proxy.RequestAsync<ListResponse<TungstenFabricNetworkResponse>>(request);
        public ListResponse<TungstenFabricNetworkResponse> ListTungstenFabricNetworkAllPages(ListTungstenFabricNetworkRequest request) => Proxy.RequestAllPages<TungstenFabricNetworkResponse>(request);
        public Task<ListResponse<TungstenFabricNetworkResponse>> ListTungstenFabricNetworkAllPagesAsync(ListTungstenFabricNetworkRequest request) => Proxy.RequestAllPagesAsync<TungstenFabricNetworkResponse>(request);
    }
}
