using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListServiceOfferingsRequest : APIListRequest
    {
        public ListServiceOfferingsRequest() : base("listServiceOfferings") {}

        /// <summary>
        /// list resources by account. Must be used with the domainId parameter.
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// the CPU number that listed offerings must support
        /// </summary>
        public int? CpuNumber {
            get { return GetParameterValue<int?>(nameof(CpuNumber).ToLower()); }
            set { SetParameterValue(nameof(CpuNumber).ToLower(), value); }
        }

        /// <summary>
        /// the CPU speed that listed offerings must support
        /// </summary>
        public int? CpuSpeed {
            get { return GetParameterValue<int?>(nameof(CpuSpeed).ToLower()); }
            set { SetParameterValue(nameof(CpuSpeed).ToLower(), value); }
        }

        /// <summary>
        /// list only resources belonging to the domain specified
        /// </summary>
        public Guid? DomainId {
            get { return GetParameterValue<Guid?>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// listed offerings support root disk encryption
        /// </summary>
        public bool? EncryptRoot {
            get { return GetParameterValue<bool?>(nameof(EncryptRoot).ToLower()); }
            set { SetParameterValue(nameof(EncryptRoot).ToLower(), value); }
        }

        /// <summary>
        /// ID of the service offering
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
        /// is this a system vm offering
        /// </summary>
        public bool? IsSystem {
            get { return GetParameterValue<bool?>(nameof(IsSystem).ToLower()); }
            set { SetParameterValue(nameof(IsSystem).ToLower(), value); }
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
        /// the RAM memory that listed offering must support
        /// </summary>
        public int? Memory {
            get { return GetParameterValue<int?>(nameof(Memory).ToLower()); }
            set { SetParameterValue(nameof(Memory).ToLower(), value); }
        }

        /// <summary>
        /// name of the service offering
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
        /// the storage type of the service offering. Values are local and shared.
        /// </summary>
        public string StorageType {
            get { return GetParameterValue<string>(nameof(StorageType).ToLower()); }
            set { SetParameterValue(nameof(StorageType).ToLower(), value); }
        }

        /// <summary>
        /// the system VM type. Possible types are "consoleproxy", "secondarystoragevm" or "domainrouter".
        /// </summary>
        public string SystemVmType {
            get { return GetParameterValue<string>(nameof(SystemVmType).ToLower()); }
            set { SetParameterValue(nameof(SystemVmType).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the virtual machine. Pass this in if you want to see the available service offering that a virtual machine can be changed to.
        /// </summary>
        public Guid? VirtualMachineId {
            get { return GetParameterValue<Guid?>(nameof(VirtualMachineId).ToLower()); }
            set { SetParameterValue(nameof(VirtualMachineId).ToLower(), value); }
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
    /// Lists all available service offerings.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<ServiceOfferingResponse> ListServiceOfferings(ListServiceOfferingsRequest request);
        Task<ListResponse<ServiceOfferingResponse>> ListServiceOfferingsAsync(ListServiceOfferingsRequest request);
        ListResponse<ServiceOfferingResponse> ListServiceOfferingsAllPages(ListServiceOfferingsRequest request);
        Task<ListResponse<ServiceOfferingResponse>> ListServiceOfferingsAllPagesAsync(ListServiceOfferingsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<ServiceOfferingResponse> ListServiceOfferings(ListServiceOfferingsRequest request) => Proxy.Request<ListResponse<ServiceOfferingResponse>>(request);
        public Task<ListResponse<ServiceOfferingResponse>> ListServiceOfferingsAsync(ListServiceOfferingsRequest request) => Proxy.RequestAsync<ListResponse<ServiceOfferingResponse>>(request);
        public ListResponse<ServiceOfferingResponse> ListServiceOfferingsAllPages(ListServiceOfferingsRequest request) => Proxy.RequestAllPages<ServiceOfferingResponse>(request);
        public Task<ListResponse<ServiceOfferingResponse>> ListServiceOfferingsAllPagesAsync(ListServiceOfferingsRequest request) => Proxy.RequestAllPagesAsync<ServiceOfferingResponse>(request);
    }
}
