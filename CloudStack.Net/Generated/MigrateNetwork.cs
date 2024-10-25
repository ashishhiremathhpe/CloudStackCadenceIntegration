using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class MigrateNetworkRequest : APIRequest
    {
        public MigrateNetworkRequest() : base("migrateNetwork") {}

        /// <summary>
        /// the ID of the network
        /// </summary>
        public Guid Networkid {
            get { return GetParameterValue<Guid>(nameof(Networkid).ToLower()); }
            set { SetParameterValue(nameof(Networkid).ToLower(), value); }
        }

        /// <summary>
        /// network offering ID
        /// </summary>
        public Guid NetworkOfferingId {
            get { return GetParameterValue<Guid>(nameof(NetworkOfferingId).ToLower()); }
            set { SetParameterValue(nameof(NetworkOfferingId).ToLower(), value); }
        }

        /// <summary>
        /// true if previous network migration cmd failed
        /// </summary>
        public bool? Resume {
            get { return GetParameterValue<bool?>(nameof(Resume).ToLower()); }
            set { SetParameterValue(nameof(Resume).ToLower(), value); }
        }

    }
    /// <summary>
    /// moves a network to another physical network
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse MigrateNetwork(MigrateNetworkRequest request);
        Task<AsyncJobResponse> MigrateNetworkAsync(MigrateNetworkRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse MigrateNetwork(MigrateNetworkRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> MigrateNetworkAsync(MigrateNetworkRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
