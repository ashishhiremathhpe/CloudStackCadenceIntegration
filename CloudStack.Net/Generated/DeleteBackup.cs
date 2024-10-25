using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteBackupRequest : APIRequest
    {
        public DeleteBackupRequest() : base("deleteBackup") {}

        /// <summary>
        /// id of the VM backup
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// force the deletion of backup which removes the entire backup chain but keep VM in Backup Offering
        /// </summary>
        public bool? Forced {
            get { return GetParameterValue<bool?>(nameof(Forced).ToLower()); }
            set { SetParameterValue(nameof(Forced).ToLower(), value); }
        }

    }
    /// <summary>
    /// Delete VM backup
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeleteBackup(DeleteBackupRequest request);
        Task<AsyncJobResponse> DeleteBackupAsync(DeleteBackupRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteBackup(DeleteBackupRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DeleteBackupAsync(DeleteBackupRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
