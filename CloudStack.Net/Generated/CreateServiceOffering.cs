using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateServiceOfferingRequest : APIRequest
    {
        public CreateServiceOfferingRequest() : base("createServiceOffering") {}

        /// <summary>
        /// the name of the service offering
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
        /// the CPU number of the service offering
        /// </summary>
        public int? CpuNumber {
            get { return GetParameterValue<int?>(nameof(CpuNumber).ToLower()); }
            set { SetParameterValue(nameof(CpuNumber).ToLower(), value); }
        }

        /// <summary>
        /// the CPU speed of the service offering in MHz.
        /// </summary>
        public int? CpuSpeed {
            get { return GetParameterValue<int?>(nameof(CpuSpeed).ToLower()); }
            set { SetParameterValue(nameof(CpuSpeed).ToLower(), value); }
        }

        /// <summary>
        /// Whether service offering size is custom or not
        /// </summary>
        public bool? Customized {
            get { return GetParameterValue<bool?>(nameof(Customized).ToLower()); }
            set { SetParameterValue(nameof(Customized).ToLower(), value); }
        }

        /// <summary>
        /// whether compute offering iops is custom or not
        /// </summary>
        public bool? CustomizedIops {
            get { return GetParameterValue<bool?>(nameof(CustomizedIops).ToLower()); }
            set { SetParameterValue(nameof(CustomizedIops).ToLower(), value); }
        }

        /// <summary>
        /// The deployment planner heuristics used to deploy a VM of this offering. If null, value of global config vm.deployment.planner is used
        /// </summary>
        public string DeploymentPlanner {
            get { return GetParameterValue<string>(nameof(DeploymentPlanner).ToLower()); }
            set { SetParameterValue(nameof(DeploymentPlanner).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the disk offering to which service offering should be mapped
        /// </summary>
        public Guid? DiskOfferingId {
            get { return GetParameterValue<Guid?>(nameof(DiskOfferingId).ToLower()); }
            set { SetParameterValue(nameof(DiskOfferingId).ToLower(), value); }
        }

        /// <summary>
        /// True/False to indicate the strictness of the disk offering association with the compute offering. When set to true, override of disk offering is not allowed when VM is deployed and change disk offering is not allowed for the ROOT disk after the VM is deployed
        /// </summary>
        public bool? DiskOfferingStrictness {
            get { return GetParameterValue<bool?>(nameof(DiskOfferingStrictness).ToLower()); }
            set { SetParameterValue(nameof(DiskOfferingStrictness).ToLower(), value); }
        }

        /// <summary>
        /// The display text of the service offering, defaults to 'name'.
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
        /// true if virtual machine needs to be dynamically scalable of cpu or memory
        /// </summary>
        public bool? Dynamicscalingenabled {
            get { return GetParameterValue<bool?>(nameof(Dynamicscalingenabled).ToLower()); }
            set { SetParameterValue(nameof(Dynamicscalingenabled).ToLower(), value); }
        }

        /// <summary>
        /// VMs using this offering require root volume encryption
        /// </summary>
        public bool? EncryptRoot {
            get { return GetParameterValue<bool?>(nameof(EncryptRoot).ToLower()); }
            set { SetParameterValue(nameof(EncryptRoot).ToLower(), value); }
        }

        /// <summary>
        /// the host tag for this service offering.
        /// </summary>
        public string Hosttags {
            get { return GetParameterValue<string>(nameof(Hosttags).ToLower()); }
            set { SetParameterValue(nameof(Hosttags).ToLower(), value); }
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
        /// is this a system vm offering
        /// </summary>
        public bool? IsSystem {
            get { return GetParameterValue<bool?>(nameof(IsSystem).ToLower()); }
            set { SetParameterValue(nameof(IsSystem).ToLower(), value); }
        }

        /// <summary>
        /// true if the virtual machine needs to be volatile so that on every reboot of VM, original root disk is dettached then destroyed and a fresh root disk is created and attached to VM
        /// </summary>
        public bool? IsVolatile {
            get { return GetParameterValue<bool?>(nameof(IsVolatile).ToLower()); }
            set { SetParameterValue(nameof(IsVolatile).ToLower(), value); }
        }

        /// <summary>
        /// restrict the CPU usage to committed service offering
        /// </summary>
        public bool? LimitCpuUse {
            get { return GetParameterValue<bool?>(nameof(LimitCpuUse).ToLower()); }
            set { SetParameterValue(nameof(LimitCpuUse).ToLower(), value); }
        }

        /// <summary>
        /// The maximum number of CPUs to be set with Custom Computer Offering
        /// </summary>
        public int? Maxcpunumber {
            get { return GetParameterValue<int?>(nameof(Maxcpunumber).ToLower()); }
            set { SetParameterValue(nameof(Maxcpunumber).ToLower(), value); }
        }

        /// <summary>
        /// max iops of the compute offering
        /// </summary>
        public long? MaxIops {
            get { return GetParameterValue<long?>(nameof(MaxIops).ToLower()); }
            set { SetParameterValue(nameof(MaxIops).ToLower(), value); }
        }

        /// <summary>
        /// The maximum memory size of the custom service offering in MB
        /// </summary>
        public int? MaxMemory {
            get { return GetParameterValue<int?>(nameof(MaxMemory).ToLower()); }
            set { SetParameterValue(nameof(MaxMemory).ToLower(), value); }
        }

        /// <summary>
        /// the total memory of the service offering in MB
        /// </summary>
        public int? Memory {
            get { return GetParameterValue<int?>(nameof(Memory).ToLower()); }
            set { SetParameterValue(nameof(Memory).ToLower(), value); }
        }

        /// <summary>
        /// The minimum number of CPUs to be set with Custom Computer Offering
        /// </summary>
        public int? Mincpunumber {
            get { return GetParameterValue<int?>(nameof(Mincpunumber).ToLower()); }
            set { SetParameterValue(nameof(Mincpunumber).ToLower(), value); }
        }

        /// <summary>
        /// min iops of the compute offering
        /// </summary>
        public long? MinIops {
            get { return GetParameterValue<long?>(nameof(MinIops).ToLower()); }
            set { SetParameterValue(nameof(MinIops).ToLower(), value); }
        }

        /// <summary>
        /// The minimum memory size of the custom service offering in MB
        /// </summary>
        public int? MinMemory {
            get { return GetParameterValue<int?>(nameof(MinMemory).ToLower()); }
            set { SetParameterValue(nameof(MinMemory).ToLower(), value); }
        }

        /// <summary>
        /// data transfer rate in megabits per second allowed. Supported only for non-System offering and system offerings having "domainrouter" systemvmtype
        /// </summary>
        public int? NetworkRate {
            get { return GetParameterValue<int?>(nameof(NetworkRate).ToLower()); }
            set { SetParameterValue(nameof(NetworkRate).ToLower(), value); }
        }

        /// <summary>
        /// the HA for the service offering
        /// </summary>
        public bool? OfferHa {
            get { return GetParameterValue<bool?>(nameof(OfferHa).ToLower()); }
            set { SetParameterValue(nameof(OfferHa).ToLower(), value); }
        }

        /// <summary>
        /// provisioning type used to create volumes. Valid values are thin, sparse, fat.
        /// </summary>
        public string ProvisioningType {
            get { return GetParameterValue<string>(nameof(ProvisioningType).ToLower()); }
            set { SetParameterValue(nameof(ProvisioningType).ToLower(), value); }
        }

        /// <summary>
        /// the Root disk size in GB.
        /// </summary>
        public long? RootDiskSize {
            get { return GetParameterValue<long?>(nameof(RootDiskSize).ToLower()); }
            set { SetParameterValue(nameof(RootDiskSize).ToLower(), value); }
        }

        /// <summary>
        /// details for planner, used to store specific parameters
        /// </summary>
        public IList<IDictionary<string, object>> Serviceofferingdetails {
            get { return GetList<IDictionary<string, object>>(nameof(Serviceofferingdetails).ToLower()); }
            set { SetParameterValue(nameof(Serviceofferingdetails).ToLower(), value); }
        }

        /// <summary>
        /// Name of the storage policy defined at vCenter, this is applicable only for VMware
        /// </summary>
        public Guid? StoragePolicy {
            get { return GetParameterValue<Guid?>(nameof(StoragePolicy).ToLower()); }
            set { SetParameterValue(nameof(StoragePolicy).ToLower(), value); }
        }

        /// <summary>
        /// the storage type of the service offering. Values are local and shared.
        /// </summary>
        public string StorageType {
            get { return GetParameterValue<string>(nameof(StorageType).ToLower()); }
            set { SetParameterValue(nameof(StorageType).ToLower(), value); }
        }

        /// <summary>
        /// the system VM type. Possible types are "domainrouter", "consoleproxy" and "secondarystoragevm".
        /// </summary>
        public string SystemVmType {
            get { return GetParameterValue<string>(nameof(SystemVmType).ToLower()); }
            set { SetParameterValue(nameof(SystemVmType).ToLower(), value); }
        }

        /// <summary>
        /// the tags for this service offering.
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
    /// Creates a service offering.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ServiceOfferingResponse CreateServiceOffering(CreateServiceOfferingRequest request);
        Task<ServiceOfferingResponse> CreateServiceOfferingAsync(CreateServiceOfferingRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ServiceOfferingResponse CreateServiceOffering(CreateServiceOfferingRequest request) => Proxy.Request<ServiceOfferingResponse>(request);
        public Task<ServiceOfferingResponse> CreateServiceOfferingAsync(CreateServiceOfferingRequest request) => Proxy.RequestAsync<ServiceOfferingResponse>(request);
    }
}
