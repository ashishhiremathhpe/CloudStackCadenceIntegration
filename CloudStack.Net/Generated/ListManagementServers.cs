using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListManagementServersRequest : APIListRequest
    {
        public ListManagementServersRequest() : base("listManagementServers") {}

        /// <summary>
        /// the id of the management server
        /// </summary>
        public Guid? Id {
            get { return GetParameterValue<Guid?>(nameof(Id).ToLower()); }
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
        /// the name of the management server
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists management servers.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<ManagementServerResponse> ListManagementServers(ListManagementServersRequest request);
        Task<ListResponse<ManagementServerResponse>> ListManagementServersAsync(ListManagementServersRequest request);
        ListResponse<ManagementServerResponse> ListManagementServersAllPages(ListManagementServersRequest request);
        Task<ListResponse<ManagementServerResponse>> ListManagementServersAllPagesAsync(ListManagementServersRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<ManagementServerResponse> ListManagementServers(ListManagementServersRequest request) => Proxy.Request<ListResponse<ManagementServerResponse>>(request);
        public Task<ListResponse<ManagementServerResponse>> ListManagementServersAsync(ListManagementServersRequest request) => Proxy.RequestAsync<ListResponse<ManagementServerResponse>>(request);
        public ListResponse<ManagementServerResponse> ListManagementServersAllPages(ListManagementServersRequest request) => Proxy.RequestAllPages<ManagementServerResponse>(request);
        public Task<ListResponse<ManagementServerResponse>> ListManagementServersAllPagesAsync(ListManagementServersRequest request) => Proxy.RequestAllPagesAsync<ManagementServerResponse>(request);
    }
}
