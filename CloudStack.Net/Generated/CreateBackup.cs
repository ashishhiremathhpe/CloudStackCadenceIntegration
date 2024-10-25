using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateBackupRequest : APIRequest
    {
        public CreateBackupRequest() : base("createBackup") {}

        /// <summary>
        /// ID of the VM
        /// </summary>
        public Guid Virtualmachineid {
            get { return GetParameterValue<Guid>(nameof(Virtualmachineid).ToLower()); }
            set { SetParameterValue(nameof(Virtualmachineid).ToLower(), value); }
        }

    }
    /// <summary>
    /// Create VM backup
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse CreateBackup(CreateBackupRequest request);
        Task<AsyncJobResponse> CreateBackupAsync(CreateBackupRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse CreateBackup(CreateBackupRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> CreateBackupAsync(CreateBackupRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
