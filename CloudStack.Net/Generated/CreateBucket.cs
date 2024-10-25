using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateBucketRequest : APIRequest
    {
        public CreateBucketRequest() : base("createBucket") {}

        /// <summary>
        /// the name of the bucket
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// Id of the Object Storage Pool where bucket is created
        /// </summary>
        public Guid Objectstorageid {
            get { return GetParameterValue<Guid>(nameof(Objectstorageid).ToLower()); }
            set { SetParameterValue(nameof(Objectstorageid).ToLower(), value); }
        }

        /// <summary>
        /// the account associated with the bucket. Must be used with the domainId parameter.
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// the domain ID associated with the bucket. If used with the account parameter returns the bucket associated with the account for the specified domain.
        /// </summary>
        public Guid? DomainId {
            get { return GetParameterValue<Guid?>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// Enable bucket encryption
        /// </summary>
        public bool? Encryption {
            get { return GetParameterValue<bool?>(nameof(Encryption).ToLower()); }
            set { SetParameterValue(nameof(Encryption).ToLower(), value); }
        }

        /// <summary>
        /// Enable object locking in bucket
        /// </summary>
        public bool? ObjectLocking {
            get { return GetParameterValue<bool?>(nameof(ObjectLocking).ToLower()); }
            set { SetParameterValue(nameof(ObjectLocking).ToLower(), value); }
        }

        /// <summary>
        /// The Bucket access policy
        /// </summary>
        public string Policy {
            get { return GetParameterValue<string>(nameof(Policy).ToLower()); }
            set { SetParameterValue(nameof(Policy).ToLower(), value); }
        }

        /// <summary>
        /// the project associated with the bucket. Mutually exclusive with account parameter
        /// </summary>
        public Guid? ProjectId {
            get { return GetParameterValue<Guid?>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
        }

        /// <summary>
        /// Bucket Quota in GB
        /// </summary>
        public int? Quota {
            get { return GetParameterValue<int?>(nameof(Quota).ToLower()); }
            set { SetParameterValue(nameof(Quota).ToLower(), value); }
        }

        /// <summary>
        /// Enable bucket versioning
        /// </summary>
        public bool? Versioning {
            get { return GetParameterValue<bool?>(nameof(Versioning).ToLower()); }
            set { SetParameterValue(nameof(Versioning).ToLower(), value); }
        }

    }
    /// <summary>
    /// Creates a bucket in the specified object storage pool. 
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse CreateBucket(CreateBucketRequest request);
        Task<AsyncJobResponse> CreateBucketAsync(CreateBucketRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse CreateBucket(CreateBucketRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> CreateBucketAsync(CreateBucketRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
