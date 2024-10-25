using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListDiskOfferingsRequest : APIListRequest
    {
        public ListDiskOfferingsRequest() : base("listDiskOfferings") {}

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
        /// listed offerings support disk encryption
        /// </summary>
        public bool? Encrypt {
            get { return GetParameterValue<bool?>(nameof(Encrypt).ToLower()); }
            set { SetParameterValue(nameof(Encrypt).ToLower(), value); }
        }

        /// <summary>
        /// ID of the disk offering
        /// </summary>
        public Guid? Id {
            get { return GetParameterValue<Guid?>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
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
        /// name of the disk offering
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// list objects by project; if projectid=-1 lists All VMs
        /// </summary>
        public Guid? ProjectId {
            get { return GetParameterValue<Guid?>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
        }

        /// <summary>
        /// The ID of the storage pool, tags of the storage pool are used to filter the offerings
        /// </summary>
        public Guid? Storageid {
            get { return GetParameterValue<Guid?>(nameof(Storageid).ToLower()); }
            set { SetParameterValue(nameof(Storageid).ToLower(), value); }
        }

        /// <summary>
        /// the storage type of the service offering. Values are local and shared.
        /// </summary>
        public string StorageType {
            get { return GetParameterValue<string>(nameof(StorageType).ToLower()); }
            set { SetParameterValue(nameof(StorageType).ToLower(), value); }
        }

        /// <summary>
        /// The ID of the volume, tags of the volume are used to filter the offerings
        /// </summary>
        public Guid? VolumeId {
            get { return GetParameterValue<Guid?>(nameof(VolumeId).ToLower()); }
            set { SetParameterValue(nameof(VolumeId).ToLower(), value); }
        }

        /// <summary>
        /// id of zone disk offering is associated with
        /// </summary>
        public Guid? ZoneId {
            get { return GetParameterValue<Guid?>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists all available disk offerings.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<DiskOfferingResponse> ListDiskOfferings(ListDiskOfferingsRequest request);
        Task<ListResponse<DiskOfferingResponse>> ListDiskOfferingsAsync(ListDiskOfferingsRequest request);
        ListResponse<DiskOfferingResponse> ListDiskOfferingsAllPages(ListDiskOfferingsRequest request);
        Task<ListResponse<DiskOfferingResponse>> ListDiskOfferingsAllPagesAsync(ListDiskOfferingsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<DiskOfferingResponse> ListDiskOfferings(ListDiskOfferingsRequest request) => Proxy.Request<ListResponse<DiskOfferingResponse>>(request);
        public Task<ListResponse<DiskOfferingResponse>> ListDiskOfferingsAsync(ListDiskOfferingsRequest request) => Proxy.RequestAsync<ListResponse<DiskOfferingResponse>>(request);
        public ListResponse<DiskOfferingResponse> ListDiskOfferingsAllPages(ListDiskOfferingsRequest request) => Proxy.RequestAllPages<DiskOfferingResponse>(request);
        public Task<ListResponse<DiskOfferingResponse>> ListDiskOfferingsAllPagesAsync(ListDiskOfferingsRequest request) => Proxy.RequestAllPagesAsync<DiskOfferingResponse>(request);
    }
}
