using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteObjectStoragePoolRequest : APIRequest
    {
        public DeleteObjectStoragePoolRequest() : base("deleteObjectStoragePool") {}

        /// <summary>
        /// The Object Storage ID.
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Deletes an Object Storage Pool
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteObjectStoragePool(DeleteObjectStoragePoolRequest request);
        Task<SuccessResponse> DeleteObjectStoragePoolAsync(DeleteObjectStoragePoolRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteObjectStoragePool(DeleteObjectStoragePoolRequest request) => Proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> DeleteObjectStoragePoolAsync(DeleteObjectStoragePoolRequest request) => Proxy.RequestAsync<SuccessResponse>(request);
    }
}
