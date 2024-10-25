using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListConfigurationGroupsRequest : APIListRequest
    {
        public ListConfigurationGroupsRequest() : base("listConfigurationGroups") {}

        /// <summary>
        /// lists configuration group by group name
        /// </summary>
        public string Group {
            get { return GetParameterValue<string>(nameof(Group).ToLower()); }
            set { SetParameterValue(nameof(Group).ToLower(), value); }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists all configuration groups (primarily used for UI).
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<ConfigurationGroupResponse> ListConfigurationGroups(ListConfigurationGroupsRequest request);
        Task<ListResponse<ConfigurationGroupResponse>> ListConfigurationGroupsAsync(ListConfigurationGroupsRequest request);
        ListResponse<ConfigurationGroupResponse> ListConfigurationGroupsAllPages(ListConfigurationGroupsRequest request);
        Task<ListResponse<ConfigurationGroupResponse>> ListConfigurationGroupsAllPagesAsync(ListConfigurationGroupsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<ConfigurationGroupResponse> ListConfigurationGroups(ListConfigurationGroupsRequest request) => Proxy.Request<ListResponse<ConfigurationGroupResponse>>(request);
        public Task<ListResponse<ConfigurationGroupResponse>> ListConfigurationGroupsAsync(ListConfigurationGroupsRequest request) => Proxy.RequestAsync<ListResponse<ConfigurationGroupResponse>>(request);
        public ListResponse<ConfigurationGroupResponse> ListConfigurationGroupsAllPages(ListConfigurationGroupsRequest request) => Proxy.RequestAllPages<ConfigurationGroupResponse>(request);
        public Task<ListResponse<ConfigurationGroupResponse>> ListConfigurationGroupsAllPagesAsync(ListConfigurationGroupsRequest request) => Proxy.RequestAllPagesAsync<ConfigurationGroupResponse>(request);
    }
}
