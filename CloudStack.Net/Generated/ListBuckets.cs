using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListBucketsRequest : APIListRequest
    {
        public ListBucketsRequest() : base("listBuckets") {}

        /// <summary>
        /// list resources by account. Must be used with the domainId parameter.
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// list only resources belonging to the domain specified
        /// </summary>
        public Guid? DomainId {
            get { return GetParameterValue<Guid?>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the bucket
        /// </summary>
        public Guid? Id {
            get { return GetParameterValue<Guid?>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// the IDs of the Buckets, mutually exclusive with id
        /// </summary>
        public IList<Guid> Ids {
            get { return GetList<Guid>(nameof(Ids).ToLower()); }
            set { SetParameterValue(nameof(Ids).ToLower(), value); }
        }

        /// <summary>
        /// defaults to false, but if true, lists all resources from the parent specified by the domainId till leaves.
        /// </summary>
        public bool? Isrecursive {
            get { return GetParameterValue<bool?>(nameof(Isrecursive).ToLower()); }
            set { SetParameterValue(nameof(Isrecursive).ToLower(), value); }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// If set to false, list only resources belonging to the command's caller; if set to true - list resources that the caller is authorized to see. Default value is false. Resources dedicated to a project are listed only if using the projectid parameter.
        /// </summary>
        public bool? ListAll {
            get { return GetParameterValue<bool?>(nameof(ListAll).ToLower()); }
            set { SetParameterValue(nameof(ListAll).ToLower(), value); }
        }

        /// <summary>
        /// the name of the bucket
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the object storage pool, available to ROOT admin only
        /// </summary>
        public Guid? ObjectStorageId {
            get { return GetParameterValue<Guid?>(nameof(ObjectStorageId).ToLower()); }
            set { SetParameterValue(nameof(ObjectStorageId).ToLower(), value); }
        }

        /// <summary>
        /// list objects by project; if projectid=-1 lists All VMs
        /// </summary>
        public Guid? ProjectId {
            get { return GetParameterValue<Guid?>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
        }

        /// <summary>
        /// List resources by tags (key/value pairs)
        /// </summary>
        public IList<IDictionary<string, object>> Tags {
            get { return GetList<IDictionary<string, object>>(nameof(Tags).ToLower()); }
            set { SetParameterValue(nameof(Tags).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists all Buckets.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<BucketResponse> ListBuckets(ListBucketsRequest request);
        Task<ListResponse<BucketResponse>> ListBucketsAsync(ListBucketsRequest request);
        ListResponse<BucketResponse> ListBucketsAllPages(ListBucketsRequest request);
        Task<ListResponse<BucketResponse>> ListBucketsAllPagesAsync(ListBucketsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<BucketResponse> ListBuckets(ListBucketsRequest request) => Proxy.Request<ListResponse<BucketResponse>>(request);
        public Task<ListResponse<BucketResponse>> ListBucketsAsync(ListBucketsRequest request) => Proxy.RequestAsync<ListResponse<BucketResponse>>(request);
        public ListResponse<BucketResponse> ListBucketsAllPages(ListBucketsRequest request) => Proxy.RequestAllPages<BucketResponse>(request);
        public Task<ListResponse<BucketResponse>> ListBucketsAllPagesAsync(ListBucketsRequest request) => Proxy.RequestAllPagesAsync<BucketResponse>(request);
    }
}
