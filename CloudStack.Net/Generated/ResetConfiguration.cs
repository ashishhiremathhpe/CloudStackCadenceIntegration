using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ResetConfigurationRequest : APIRequest
    {
        public ResetConfigurationRequest() : base("resetConfiguration") {}

        /// <summary>
        /// the name of the configuration
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the Account to reset the parameter value for corresponding account
        /// </summary>
        public Guid? AccountId {
            get { return GetParameterValue<Guid?>(nameof(AccountId).ToLower()); }
            set { SetParameterValue(nameof(AccountId).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the Cluster to reset the parameter value for corresponding cluster
        /// </summary>
        public Guid? ClusterId {
            get { return GetParameterValue<Guid?>(nameof(ClusterId).ToLower()); }
            set { SetParameterValue(nameof(ClusterId).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the Domain to reset the parameter value for corresponding domain
        /// </summary>
        public Guid? DomainId {
            get { return GetParameterValue<Guid?>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the Image Store to reset the parameter value for corresponding image store
        /// </summary>
        public Guid? ImageStoreId {
            get { return GetParameterValue<Guid?>(nameof(ImageStoreId).ToLower()); }
            set { SetParameterValue(nameof(ImageStoreId).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the Storage pool to reset the parameter value for corresponding storage pool
        /// </summary>
        public Guid? Storageid {
            get { return GetParameterValue<Guid?>(nameof(Storageid).ToLower()); }
            set { SetParameterValue(nameof(Storageid).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the Zone to reset the parameter value for corresponding zone
        /// </summary>
        public Guid? ZoneId {
            get { return GetParameterValue<Guid?>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Resets a configuration. The configuration will be set to default value for global setting, and removed from account_details or domain_details for Account/Domain settings
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ConfigurationResponse ResetConfiguration(ResetConfigurationRequest request);
        Task<ConfigurationResponse> ResetConfigurationAsync(ResetConfigurationRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ConfigurationResponse ResetConfiguration(ResetConfigurationRequest request) => Proxy.Request<ConfigurationResponse>(request);
        public Task<ConfigurationResponse> ResetConfigurationAsync(ResetConfigurationRequest request) => Proxy.RequestAsync<ConfigurationResponse>(request);
    }
}
