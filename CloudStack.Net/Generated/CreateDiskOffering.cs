using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateDiskOfferingRequest : APIRequest
    {
        public CreateDiskOfferingRequest() : base("createDiskOffering") {}

        /// <summary>
        /// name of the disk offering
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// bytes read rate of the disk offering
        /// </summary>
        public long? BytesReadRate {
            get { return GetParameterValue<long?>(nameof(BytesReadRate).ToLower()); }
            set { SetParameterValue(nameof(BytesReadRate).ToLower(), value); }
        }

        /// <summary>
        /// burst bytes read rate of the disk offering
        /// </summary>
        public long? BytesReadRateMax {
            get { return GetParameterValue<long?>(nameof(BytesReadRateMax).ToLower()); }
            set { SetParameterValue(nameof(BytesReadRateMax).ToLower(), value); }
        }

        /// <summary>
        /// length (in seconds) of the burst
        /// </summary>
        public long? BytesReadRateMaxLength {
            get { return GetParameterValue<long?>(nameof(BytesReadRateMaxLength).ToLower()); }
            set { SetParameterValue(nameof(BytesReadRateMaxLength).ToLower(), value); }
        }

        /// <summary>
        /// bytes write rate of the disk offering
        /// </summary>
        public long? BytesWriteRate {
            get { return GetParameterValue<long?>(nameof(BytesWriteRate).ToLower()); }
            set { SetParameterValue(nameof(BytesWriteRate).ToLower(), value); }
        }

        /// <summary>
        /// burst bytes write rate of the disk offering
        /// </summary>
        public long? BytesWriteRateMax {
            get { return GetParameterValue<long?>(nameof(BytesWriteRateMax).ToLower()); }
            set { SetParameterValue(nameof(BytesWriteRateMax).ToLower(), value); }
        }

        /// <summary>
        /// length (in seconds) of the burst
        /// </summary>
        public long? BytesWriteRateMaxLength {
            get { return GetParameterValue<long?>(nameof(BytesWriteRateMaxLength).ToLower()); }
            set { SetParameterValue(nameof(BytesWriteRateMaxLength).ToLower(), value); }
        }

        /// <summary>
        /// the cache mode to use for this disk offering. none, writeback or writethrough
        /// </summary>
        public string CacheMode {
            get { return GetParameterValue<string>(nameof(CacheMode).ToLower()); }
            set { SetParameterValue(nameof(CacheMode).ToLower(), value); }
        }

        /// <summary>
        /// whether disk offering size is custom or not
        /// </summary>
        public bool? Customized {
            get { return GetParameterValue<bool?>(nameof(Customized).ToLower()); }
            set { SetParameterValue(nameof(Customized).ToLower(), value); }
        }

        /// <summary>
        /// whether disk offering iops is custom or not
        /// </summary>
        public bool? CustomizedIops {
            get { return GetParameterValue<bool?>(nameof(CustomizedIops).ToLower()); }
            set { SetParameterValue(nameof(CustomizedIops).ToLower(), value); }
        }

        /// <summary>
        /// details to specify disk offering parameters
        /// </summary>
        public IList<IDictionary<string, object>> Details {
            get { return GetList<IDictionary<string, object>>(nameof(Details).ToLower()); }
            set { SetParameterValue(nameof(Details).ToLower(), value); }
        }

        /// <summary>
        /// size of the disk offering in GB (1GB = 1,073,741,824 bytes)
        /// </summary>
        public long? DiskSize {
            get { return GetParameterValue<long?>(nameof(DiskSize).ToLower()); }
            set { SetParameterValue(nameof(DiskSize).ToLower(), value); }
        }

        /// <summary>
        /// To allow or disallow the resize operation on the disks created from this disk offering, if the flag is true then resize is not allowed
        /// </summary>
        public bool? DiskSizeStrictness {
            get { return GetParameterValue<bool?>(nameof(DiskSizeStrictness).ToLower()); }
            set { SetParameterValue(nameof(DiskSizeStrictness).ToLower(), value); }
        }

        /// <summary>
        /// an optional field, whether to display the offering to the end user or not.
        /// </summary>
        public bool? DisplayOffering {
            get { return GetParameterValue<bool?>(nameof(DisplayOffering).ToLower()); }
            set { SetParameterValue(nameof(DisplayOffering).ToLower(), value); }
        }

        /// <summary>
        /// An alternate display text of the disk offering, defaults to 'name'.
        /// </summary>
        public string DisplayText {
            get { return GetParameterValue<string>(nameof(DisplayText).ToLower()); }
            set { SetParameterValue(nameof(DisplayText).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the containing domain(s), null for public offerings
        /// </summary>
        public IList<Guid> Domainid {
            get { return GetList<Guid>(nameof(Domainid).ToLower()); }
            set { SetParameterValue(nameof(Domainid).ToLower(), value); }
        }

        /// <summary>
        /// Volumes using this offering should be encrypted
        /// </summary>
        public bool? Encrypt {
            get { return GetParameterValue<bool?>(nameof(Encrypt).ToLower()); }
            set { SetParameterValue(nameof(Encrypt).ToLower(), value); }
        }

        /// <summary>
        /// Hypervisor snapshot reserve space as a percent of a volume (for managed storage using Xen or VMware)
        /// </summary>
        public int? HypervisorSnapshotReserve {
            get { return GetParameterValue<int?>(nameof(HypervisorSnapshotReserve).ToLower()); }
            set { SetParameterValue(nameof(HypervisorSnapshotReserve).ToLower(), value); }
        }

        /// <summary>
        /// io requests read rate of the disk offering
        /// </summary>
        public long? IopsReadRate {
            get { return GetParameterValue<long?>(nameof(IopsReadRate).ToLower()); }
            set { SetParameterValue(nameof(IopsReadRate).ToLower(), value); }
        }

        /// <summary>
        /// burst requests read rate of the disk offering
        /// </summary>
        public long? IopsReadRateMax {
            get { return GetParameterValue<long?>(nameof(IopsReadRateMax).ToLower()); }
            set { SetParameterValue(nameof(IopsReadRateMax).ToLower(), value); }
        }

        /// <summary>
        /// length (in seconds) of the burst
        /// </summary>
        public long? IopsReadRateMaxLength {
            get { return GetParameterValue<long?>(nameof(IopsReadRateMaxLength).ToLower()); }
            set { SetParameterValue(nameof(IopsReadRateMaxLength).ToLower(), value); }
        }

        /// <summary>
        /// io requests write rate of the disk offering
        /// </summary>
        public long? IopsWriteRate {
            get { return GetParameterValue<long?>(nameof(IopsWriteRate).ToLower()); }
            set { SetParameterValue(nameof(IopsWriteRate).ToLower(), value); }
        }

        /// <summary>
        /// burst io requests write rate of the disk offering
        /// </summary>
        public long? IopsWriteRateMax {
            get { return GetParameterValue<long?>(nameof(IopsWriteRateMax).ToLower()); }
            set { SetParameterValue(nameof(IopsWriteRateMax).ToLower(), value); }
        }

        /// <summary>
        /// length (in seconds) of the burst
        /// </summary>
        public long? IopsWriteRateMaxLength {
            get { return GetParameterValue<long?>(nameof(IopsWriteRateMaxLength).ToLower()); }
            set { SetParameterValue(nameof(IopsWriteRateMaxLength).ToLower(), value); }
        }

        /// <summary>
        /// max iops of the disk offering
        /// </summary>
        public long? MaxIops {
            get { return GetParameterValue<long?>(nameof(MaxIops).ToLower()); }
            set { SetParameterValue(nameof(MaxIops).ToLower(), value); }
        }

        /// <summary>
        /// min iops of the disk offering
        /// </summary>
        public long? MinIops {
            get { return GetParameterValue<long?>(nameof(MinIops).ToLower()); }
            set { SetParameterValue(nameof(MinIops).ToLower(), value); }
        }

        /// <summary>
        /// provisioning type used to create volumes. Valid values are thin, sparse, fat.
        /// </summary>
        public string ProvisioningType {
            get { return GetParameterValue<string>(nameof(ProvisioningType).ToLower()); }
            set { SetParameterValue(nameof(ProvisioningType).ToLower(), value); }
        }

        /// <summary>
        /// Name of the storage policy defined at vCenter, this is applicable only for VMware
        /// </summary>
        public Guid? StoragePolicy {
            get { return GetParameterValue<Guid?>(nameof(StoragePolicy).ToLower()); }
            set { SetParameterValue(nameof(StoragePolicy).ToLower(), value); }
        }

        /// <summary>
        /// the storage type of the disk offering. Values are local and shared.
        /// </summary>
        public string StorageType {
            get { return GetParameterValue<string>(nameof(StorageType).ToLower()); }
            set { SetParameterValue(nameof(StorageType).ToLower(), value); }
        }

        /// <summary>
        /// tags for the disk offering
        /// </summary>
        public string Tags {
            get { return GetParameterValue<string>(nameof(Tags).ToLower()); }
            set { SetParameterValue(nameof(Tags).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the containing zone(s), null for public offerings
        /// </summary>
        public IList<Guid> Zoneid {
            get { return GetList<Guid>(nameof(Zoneid).ToLower()); }
            set { SetParameterValue(nameof(Zoneid).ToLower(), value); }
        }

    }
    /// <summary>
    /// Creates a disk offering.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        DiskOfferingResponse CreateDiskOffering(CreateDiskOfferingRequest request);
        Task<DiskOfferingResponse> CreateDiskOfferingAsync(CreateDiskOfferingRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public DiskOfferingResponse CreateDiskOffering(CreateDiskOfferingRequest request) => Proxy.Request<DiskOfferingResponse>(request);
        public Task<DiskOfferingResponse> CreateDiskOfferingAsync(CreateDiskOfferingRequest request) => Proxy.RequestAsync<DiskOfferingResponse>(request);
    }
}
