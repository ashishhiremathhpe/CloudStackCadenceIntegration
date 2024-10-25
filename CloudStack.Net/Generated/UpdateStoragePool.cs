using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateStoragePoolRequest : APIRequest
    {
        public UpdateStoragePoolRequest() : base("updateStoragePool") {}

        /// <summary>
        /// the Id of the storage pool
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// bytes CloudStack can provision from this storage pool
        /// </summary>
        public long? CapacityBytes {
            get { return GetParameterValue<long?>(nameof(CapacityBytes).ToLower()); }
            set { SetParameterValue(nameof(CapacityBytes).ToLower(), value); }
        }

        /// <summary>
        /// IOPS CloudStack can provision from this storage pool
        /// </summary>
        public long? CapacityIops {
            get { return GetParameterValue<long?>(nameof(CapacityIops).ToLower()); }
            set { SetParameterValue(nameof(CapacityIops).ToLower(), value); }
        }

        /// <summary>
        /// the details for the storage pool
        /// </summary>
        public IList<IDictionary<string, object>> Details {
            get { return GetList<IDictionary<string, object>>(nameof(Details).ToLower()); }
            set { SetParameterValue(nameof(Details).ToLower(), value); }
        }

        /// <summary>
        /// false to disable the pool for allocation of new volumes, true to enable it back.
        /// </summary>
        public bool? Enabled {
            get { return GetParameterValue<bool?>(nameof(Enabled).ToLower()); }
            set { SetParameterValue(nameof(Enabled).ToLower(), value); }
        }

        /// <summary>
        /// Whether the informed tag is a JS interpretable rule or not.
        /// </summary>
        public bool? IsTagARule {
            get { return GetParameterValue<bool?>(nameof(IsTagARule).ToLower()); }
            set { SetParameterValue(nameof(IsTagARule).ToLower(), value); }
        }

        /// <summary>
        /// Change the name of the storage pool
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// comma-separated list of tags for the storage pool
        /// </summary>
        public IList<string> Tags {
            get { return GetList<string>(nameof(Tags).ToLower()); }
            set { SetParameterValue(nameof(Tags).ToLower(), value); }
        }

        /// <summary>
        /// the URL of the storage pool
        /// </summary>
        public string Url {
            get { return GetParameterValue<string>(nameof(Url).ToLower()); }
            set { SetParameterValue(nameof(Url).ToLower(), value); }
        }

    }
    /// <summary>
    /// Updates a storage pool.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        StoragePoolResponse UpdateStoragePool(UpdateStoragePoolRequest request);
        Task<StoragePoolResponse> UpdateStoragePoolAsync(UpdateStoragePoolRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public StoragePoolResponse UpdateStoragePool(UpdateStoragePoolRequest request) => Proxy.Request<StoragePoolResponse>(request);
        public Task<StoragePoolResponse> UpdateStoragePoolAsync(UpdateStoragePoolRequest request) => Proxy.RequestAsync<StoragePoolResponse>(request);
    }
}
