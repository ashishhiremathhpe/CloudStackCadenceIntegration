using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateBucketRequest : APIRequest
    {
        public UpdateBucketRequest() : base("updateBucket") {}

        /// <summary>
        /// The ID of the Bucket
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// Enable/Disable Bucket encryption
        /// </summary>
        public bool? Encryption {
            get { return GetParameterValue<bool?>(nameof(Encryption).ToLower()); }
            set { SetParameterValue(nameof(Encryption).ToLower(), value); }
        }

        /// <summary>
        /// Bucket Access Policy
        /// </summary>
        public string Policy {
            get { return GetParameterValue<string>(nameof(Policy).ToLower()); }
            set { SetParameterValue(nameof(Policy).ToLower(), value); }
        }

        /// <summary>
        /// Bucket Quota in GB
        /// </summary>
        public int? Quota {
            get { return GetParameterValue<int?>(nameof(Quota).ToLower()); }
            set { SetParameterValue(nameof(Quota).ToLower(), value); }
        }

        /// <summary>
        /// Enable/Disable Bucket Versioning
        /// </summary>
        public bool? Versioning {
            get { return GetParameterValue<bool?>(nameof(Versioning).ToLower()); }
            set { SetParameterValue(nameof(Versioning).ToLower(), value); }
        }

    }
    /// <summary>
    /// Updates Bucket properties
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse UpdateBucket(UpdateBucketRequest request);
        Task<SuccessResponse> UpdateBucketAsync(UpdateBucketRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse UpdateBucket(UpdateBucketRequest request) => Proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> UpdateBucketAsync(UpdateBucketRequest request) => Proxy.RequestAsync<SuccessResponse>(request);
    }
}
