using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListConfigurationsRequest : APIListRequest
    {
        public ListConfigurationsRequest() : base("listConfigurations") {}

        /// <summary>
        /// the ID of the Account to update the parameter value for corresponding account
        /// </summary>
        public Guid? AccountId {
            get { return GetParameterValue<Guid?>(nameof(AccountId).ToLower()); }
            set { SetParameterValue(nameof(AccountId).ToLower(), value); }
        }

        /// <summary>
        /// lists configurations by category
        /// </summary>
        public string Category {
            get { return GetParameterValue<string>(nameof(Category).ToLower()); }
            set { SetParameterValue(nameof(Category).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the Cluster to update the parameter value for corresponding cluster
        /// </summary>
        public Guid? ClusterId {
            get { return GetParameterValue<Guid?>(nameof(ClusterId).ToLower()); }
            set { SetParameterValue(nameof(ClusterId).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the Domain to update the parameter value for corresponding domain
        /// </summary>
        public Guid? DomainId {
            get { return GetParameterValue<Guid?>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// lists configuration by group name (primarily used for UI)
        /// </summary>
        public string Group {
            get { return GetParameterValue<string>(nameof(Group).ToLower()); }
            set { SetParameterValue(nameof(Group).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the Image Store to update the parameter value for corresponding image store
        /// </summary>
        public Guid? Imagestoreuuid {
            get { return GetParameterValue<Guid?>(nameof(Imagestoreuuid).ToLower()); }
            set { SetParameterValue(nameof(Imagestoreuuid).ToLower(), value); }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// lists configuration by name
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// lists configuration by parent name (primarily used for UI)
        /// </summary>
        public string Parent {
            get { return GetParameterValue<string>(nameof(Parent).ToLower()); }
            set { SetParameterValue(nameof(Parent).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the Storage pool to update the parameter value for corresponding storage pool
        /// </summary>
        public Guid? Storageid {
            get { return GetParameterValue<Guid?>(nameof(Storageid).ToLower()); }
            set { SetParameterValue(nameof(Storageid).ToLower(), value); }
        }

        /// <summary>
        /// lists configuration by subgroup name (primarily used for UI)
        /// </summary>
        public string Subgroup {
            get { return GetParameterValue<string>(nameof(Subgroup).ToLower()); }
            set { SetParameterValue(nameof(Subgroup).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the Zone to update the parameter value for corresponding zone
        /// </summary>
        public Guid? ZoneId {
            get { return GetParameterValue<Guid?>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists all configurations.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<ConfigurationResponse> ListConfigurations(ListConfigurationsRequest request);
        Task<ListResponse<ConfigurationResponse>> ListConfigurationsAsync(ListConfigurationsRequest request);
        ListResponse<ConfigurationResponse> ListConfigurationsAllPages(ListConfigurationsRequest request);
        Task<ListResponse<ConfigurationResponse>> ListConfigurationsAllPagesAsync(ListConfigurationsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<ConfigurationResponse> ListConfigurations(ListConfigurationsRequest request) => Proxy.Request<ListResponse<ConfigurationResponse>>(request);
        public Task<ListResponse<ConfigurationResponse>> ListConfigurationsAsync(ListConfigurationsRequest request) => Proxy.RequestAsync<ListResponse<ConfigurationResponse>>(request);
        public ListResponse<ConfigurationResponse> ListConfigurationsAllPages(ListConfigurationsRequest request) => Proxy.RequestAllPages<ConfigurationResponse>(request);
        public Task<ListResponse<ConfigurationResponse>> ListConfigurationsAllPagesAsync(ListConfigurationsRequest request) => Proxy.RequestAllPagesAsync<ConfigurationResponse>(request);
    }
}
