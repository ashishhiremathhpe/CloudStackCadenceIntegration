using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class RestoreBackupRequest : APIRequest
    {
        public RestoreBackupRequest() : base("restoreBackup") {}

        /// <summary>
        /// ID of the backup
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Restores an existing stopped or deleted VM using a VM backup
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse RestoreBackup(RestoreBackupRequest request);
        Task<AsyncJobResponse> RestoreBackupAsync(RestoreBackupRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse RestoreBackup(RestoreBackupRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> RestoreBackupAsync(RestoreBackupRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
