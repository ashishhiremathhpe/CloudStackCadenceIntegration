using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class SearchLdapRequest : APIListRequest
    {
        public SearchLdapRequest() : base("searchLdap") {}

        /// <summary>
        /// query to search using
        /// </summary>
        public string Query {
            get { return GetParameterValue<string>(nameof(Query).ToLower()); }
            set { SetParameterValue(nameof(Query).ToLower(), value); }
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
    /// Searches LDAP based on the username attribute
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<LdapUserResponse> SearchLdap(SearchLdapRequest request);
        Task<ListResponse<LdapUserResponse>> SearchLdapAsync(SearchLdapRequest request);
        ListResponse<LdapUserResponse> SearchLdapAllPages(SearchLdapRequest request);
        Task<ListResponse<LdapUserResponse>> SearchLdapAllPagesAsync(SearchLdapRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<LdapUserResponse> SearchLdap(SearchLdapRequest request) => Proxy.Request<ListResponse<LdapUserResponse>>(request);
        public Task<ListResponse<LdapUserResponse>> SearchLdapAsync(SearchLdapRequest request) => Proxy.RequestAsync<ListResponse<LdapUserResponse>>(request);
        public ListResponse<LdapUserResponse> SearchLdapAllPages(SearchLdapRequest request) => Proxy.RequestAllPages<LdapUserResponse>(request);
        public Task<ListResponse<LdapUserResponse>> SearchLdapAllPagesAsync(SearchLdapRequest request) => Proxy.RequestAllPagesAsync<LdapUserResponse>(request);
    }
}
