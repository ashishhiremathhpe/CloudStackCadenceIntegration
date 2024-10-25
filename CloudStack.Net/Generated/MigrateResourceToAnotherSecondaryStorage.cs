using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class MigrateResourceToAnotherSecondaryStorageRequest : APIRequest
    {
        public MigrateResourceToAnotherSecondaryStorageRequest() : base("migrateResourceToAnotherSecondaryStorage") {}

        /// <summary>
        /// id of the destination secondary storage pool to which the resources are to be migrated
        /// </summary>
        public Guid Destpool {
            get { return GetParameterValue<Guid>(nameof(Destpool).ToLower()); }
            set { SetParameterValue(nameof(Destpool).ToLower(), value); }
        }

        /// <summary>
        /// id of the image store from where the data is to be migrated
        /// </summary>
        public Guid Srcpool {
            get { return GetParameterValue<Guid>(nameof(Srcpool).ToLower()); }
            set { SetParameterValue(nameof(Srcpool).ToLower(), value); }
        }

        /// <summary>
        /// id(s) of the snapshots to be migrated
        /// </summary>
        public IList<Guid> Snapshots {
            get { return GetList<Guid>(nameof(Snapshots).ToLower()); }
            set { SetParameterValue(nameof(Snapshots).ToLower(), value); }
        }

        /// <summary>
        /// id(s) of the templates to be migrated
        /// </summary>
        public IList<Guid> Templates {
            get { return GetList<Guid>(nameof(Templates).ToLower()); }
            set { SetParameterValue(nameof(Templates).ToLower(), value); }
        }

    }
    /// <summary>
    /// migrates resources from one secondary storage to destination image store
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse MigrateResourceToAnotherSecondaryStorage(MigrateResourceToAnotherSecondaryStorageRequest request);
        Task<AsyncJobResponse> MigrateResourceToAnotherSecondaryStorageAsync(MigrateResourceToAnotherSecondaryStorageRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse MigrateResourceToAnotherSecondaryStorage(MigrateResourceToAnotherSecondaryStorageRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> MigrateResourceToAnotherSecondaryStorageAsync(MigrateResourceToAnotherSecondaryStorageRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
