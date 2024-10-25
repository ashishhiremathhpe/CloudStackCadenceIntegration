using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class SyncStoragePoolRequest : APIRequest
    {
        public SyncStoragePoolRequest() : base("syncStoragePool") {}

        /// <summary>
        /// Storage pool id
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Sync storage pool with management server (currently supported for Datastore Cluster in VMware and syncs the datastores in it)
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse SyncStoragePool(SyncStoragePoolRequest request);
        Task<AsyncJobResponse> SyncStoragePoolAsync(SyncStoragePoolRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse SyncStoragePool(SyncStoragePoolRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> SyncStoragePoolAsync(SyncStoragePoolRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
