using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class MigrateSecondaryStorageDataRequest : APIRequest
    {
        public MigrateSecondaryStorageDataRequest() : base("migrateSecondaryStorageData") {}

        /// <summary>
        /// id(s) of the destination secondary storage pool(s) to which the templates are to be migrated
        /// </summary>
        public IList<Guid> Destpools {
            get { return GetList<Guid>(nameof(Destpools).ToLower()); }
            set { SetParameterValue(nameof(Destpools).ToLower(), value); }
        }

        /// <summary>
        /// id of the image store from where the data is to be migrated
        /// </summary>
        public Guid Srcpool {
            get { return GetParameterValue<Guid>(nameof(Srcpool).ToLower()); }
            set { SetParameterValue(nameof(Srcpool).ToLower(), value); }
        }

        /// <summary>
        /// Balance: if you want data to be distributed evenly among the destination stores, Complete: If you want to migrate the entire data from source image store to the destination store(s). Default: Complete
        /// </summary>
        public string MigrationType {
            get { return GetParameterValue<string>(nameof(MigrationType).ToLower()); }
            set { SetParameterValue(nameof(MigrationType).ToLower(), value); }
        }

    }
    /// <summary>
    /// migrates data objects from one secondary storage to destination image store(s)
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse MigrateSecondaryStorageData(MigrateSecondaryStorageDataRequest request);
        Task<AsyncJobResponse> MigrateSecondaryStorageDataAsync(MigrateSecondaryStorageDataRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse MigrateSecondaryStorageData(MigrateSecondaryStorageDataRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> MigrateSecondaryStorageDataAsync(MigrateSecondaryStorageDataRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
