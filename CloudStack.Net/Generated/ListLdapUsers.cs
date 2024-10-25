using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListLdapUsersRequest : APIListRequest
    {
        public ListLdapUsersRequest() : base("listLdapUsers") {}

        /// <summary>
        /// linked domain
        /// </summary>
        public Guid? DomainId {
            get { return GetParameterValue<Guid?>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// Determines whether all ldap users are returned or just non-cloudstack users. This option is deprecated in favour for the more option rich 'userfilter' parameter
        /// </summary>
        public string ListType {
            get { return GetParameterValue<string>(nameof(ListType).ToLower()); }
            set { SetParameterValue(nameof(ListType).ToLower(), value); }
        }

        /// <summary>
        /// Determines what type of filter is applied on the list of users returned from LDAP.
        /// 	valid values are
        /// 	'NoFilter'	 no filtering is done,
        /// 	'LocalDomain'	users already in the current or requested domain will be filtered out of the result list,
        /// 	'AnyDomain'	users that already exist anywhere in cloudstack will be filtered out, and
        /// 	'PotentialImport'	all users that would be automatically imported from the listing will be shown, including those that are already in cloudstack, the later will be annotated with their userSource
        /// </summary>
        public string UserFilter {
            get { return GetParameterValue<string>(nameof(UserFilter).ToLower()); }
            set { SetParameterValue(nameof(UserFilter).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists LDAP Users according to the specifications from the user request.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<LdapUserResponse> ListLdapUsers(ListLdapUsersRequest request);
        Task<ListResponse<LdapUserResponse>> ListLdapUsersAsync(ListLdapUsersRequest request);
        ListResponse<LdapUserResponse> ListLdapUsersAllPages(ListLdapUsersRequest request);
        Task<ListResponse<LdapUserResponse>> ListLdapUsersAllPagesAsync(ListLdapUsersRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<LdapUserResponse> ListLdapUsers(ListLdapUsersRequest request) => Proxy.Request<ListResponse<LdapUserResponse>>(request);
        public Task<ListResponse<LdapUserResponse>> ListLdapUsersAsync(ListLdapUsersRequest request) => Proxy.RequestAsync<ListResponse<LdapUserResponse>>(request);
        public ListResponse<LdapUserResponse> ListLdapUsersAllPages(ListLdapUsersRequest request) => Proxy.RequestAllPages<LdapUserResponse>(request);
        public Task<ListResponse<LdapUserResponse>> ListLdapUsersAllPagesAsync(ListLdapUsersRequest request) => Proxy.RequestAllPagesAsync<LdapUserResponse>(request);
    }
}
