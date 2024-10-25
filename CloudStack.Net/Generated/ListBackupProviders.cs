using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListBackupProvidersRequest : APIRequest
    {
        public ListBackupProvidersRequest() : base("listBackupProviders") {}

        /// <summary>
        /// List Backup and Recovery provider by name
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists Backup and Recovery providers
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        BackupProviderResponse ListBackupProviders(ListBackupProvidersRequest request);
        Task<BackupProviderResponse> ListBackupProvidersAsync(ListBackupProvidersRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public BackupProviderResponse ListBackupProviders(ListBackupProvidersRequest request) => Proxy.Request<BackupProviderResponse>(request);
        public Task<BackupProviderResponse> ListBackupProvidersAsync(ListBackupProvidersRequest request) => Proxy.RequestAsync<BackupProviderResponse>(request);
    }
}
