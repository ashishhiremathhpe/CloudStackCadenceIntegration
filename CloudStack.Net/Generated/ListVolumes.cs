using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListVolumesRequest : APIListRequest
    {
        public ListVolumesRequest() : base("listVolumes") {}

        /// <summary>
        /// list resources by account. Must be used with the domainId parameter.
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// the cluster id the disk volume belongs to
        /// </summary>
        public Guid? ClusterId {
            get { return GetParameterValue<Guid?>(nameof(ClusterId).ToLower()); }
            set { SetParameterValue(nameof(ClusterId).ToLower(), value); }
        }

        /// <summary>
        /// list volumes by disk offering
        /// </summary>
        public Guid? DiskOfferingId {
            get { return GetParameterValue<Guid?>(nameof(DiskOfferingId).ToLower()); }
            set { SetParameterValue(nameof(DiskOfferingId).ToLower(), value); }
        }

        /// <summary>
        /// list resources by display flag; only ROOT admin is eligible to pass this parameter
        /// </summary>
        public bool? Displayvolume {
            get { return GetParameterValue<bool?>(nameof(Displayvolume).ToLower()); }
            set { SetParameterValue(nameof(Displayvolume).ToLower(), value); }
        }

        /// <summary>
        /// list only resources belonging to the domain specified
        /// </summary>
        public Guid? DomainId {
            get { return GetParameterValue<Guid?>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// list volumes on specified host
        /// </summary>
        public Guid? HostId {
            get { return GetParameterValue<Guid?>(nameof(HostId).ToLower()); }
            set { SetParameterValue(nameof(HostId).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the disk volume
        /// </summary>
        public Guid? Id {
            get { return GetParameterValue<Guid?>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// the IDs of the volumes, mutually exclusive with id
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
        /// list system VMs; only ROOT admin is eligible to pass this parameter
        /// </summary>
        public bool? ListSystemVms {
            get { return GetParameterValue<bool?>(nameof(ListSystemVms).ToLower()); }
            set { SetParameterValue(nameof(ListSystemVms).ToLower(), value); }
        }

        /// <summary>
        /// the name of the disk volume
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// the pod id the disk volume belongs to
        /// </summary>
        public Guid? PodId {
            get { return GetParameterValue<Guid?>(nameof(PodId).ToLower()); }
            set { SetParameterValue(nameof(PodId).ToLower(), value); }
        }

        /// <summary>
        /// list objects by project; if projectid=-1 lists All VMs
        /// </summary>
        public Guid? ProjectId {
            get { return GetParameterValue<Guid?>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
        }

        /// <summary>
        /// makes the API's response contains only the resource count
        /// </summary>
        public bool? RetrieveOnlyResourceCount {
            get { return GetParameterValue<bool?>(nameof(RetrieveOnlyResourceCount).ToLower()); }
            set { SetParameterValue(nameof(RetrieveOnlyResourceCount).ToLower(), value); }
        }

        /// <summary>
        /// state of the volume. Possible values are: Ready, Allocated, Destroy, Expunging, Expunged.
        /// </summary>
        public string State {
            get { return GetParameterValue<string>(nameof(State).ToLower()); }
            set { SetParameterValue(nameof(State).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the storage pool, available to ROOT admin only
        /// </summary>
        public string StorageId {
            get { return GetParameterValue<string>(nameof(StorageId).ToLower()); }
            set { SetParameterValue(nameof(StorageId).ToLower(), value); }
        }

        /// <summary>
        /// List resources by tags (key/value pairs)
        /// </summary>
        public IList<IDictionary<string, object>> Tags {
            get { return GetList<IDictionary<string, object>>(nameof(Tags).ToLower()); }
            set { SetParameterValue(nameof(Tags).ToLower(), value); }
        }

        /// <summary>
        /// the type of disk volume
        /// </summary>
        public string Type {
            get { return GetParameterValue<string>(nameof(Type).ToLower()); }
            set { SetParameterValue(nameof(Type).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the virtual machine
        /// </summary>
        public Guid? VirtualMachineId {
            get { return GetParameterValue<Guid?>(nameof(VirtualMachineId).ToLower()); }
            set { SetParameterValue(nameof(VirtualMachineId).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the availability zone
        /// </summary>
        public Guid? ZoneId {
            get { return GetParameterValue<Guid?>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists all volumes.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<VolumeResponse> ListVolumes(ListVolumesRequest request);
        Task<ListResponse<VolumeResponse>> ListVolumesAsync(ListVolumesRequest request);
        ListResponse<VolumeResponse> ListVolumesAllPages(ListVolumesRequest request);
        Task<ListResponse<VolumeResponse>> ListVolumesAllPagesAsync(ListVolumesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<VolumeResponse> ListVolumes(ListVolumesRequest request) => Proxy.Request<ListResponse<VolumeResponse>>(request);
        public Task<ListResponse<VolumeResponse>> ListVolumesAsync(ListVolumesRequest request) => Proxy.RequestAsync<ListResponse<VolumeResponse>>(request);
        public ListResponse<VolumeResponse> ListVolumesAllPages(ListVolumesRequest request) => Proxy.RequestAllPages<VolumeResponse>(request);
        public Task<ListResponse<VolumeResponse>> ListVolumesAllPagesAsync(ListVolumesRequest request) => Proxy.RequestAllPagesAsync<VolumeResponse>(request);
    }
}
