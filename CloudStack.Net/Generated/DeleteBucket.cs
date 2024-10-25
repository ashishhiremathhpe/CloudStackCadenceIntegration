using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteBucketRequest : APIRequest
    {
        public DeleteBucketRequest() : base("deleteBucket") {}

        /// <summary>
        /// The ID of the Bucket
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Deletes an empty Bucket.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteBucket(DeleteBucketRequest request);
        Task<SuccessResponse> DeleteBucketAsync(DeleteBucketRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteBucket(DeleteBucketRequest request) => Proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> DeleteBucketAsync(DeleteBucketRequest request) => Proxy.RequestAsync<SuccessResponse>(request);
    }
}
