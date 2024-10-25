using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ServiceOfferingResponse
    {
        /// <summary>
        /// the id of the service offering
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the cache mode to use for this disk offering. none, writeback or writethrough
        /// </summary>
        public string CacheMode { get; set; }

        /// <summary>
        /// the number of CPU
        /// </summary>
        public int? CpuNumber { get; set; }

        /// <summary>
        /// the clock rate CPU speed in Mhz
        /// </summary>
        public int? CpuSpeed { get; set; }

        /// <summary>
        /// the date this service offering was created
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// is this a  default system vm offering
        /// </summary>
        public bool DefaultUse { get; set; }

        /// <summary>
        /// deployment strategy used to deploy VM.
        /// </summary>
        public string DeploymentPlanner { get; set; }

        /// <summary>
        /// bytes read rate of the service offering
        /// </summary>
        public long DiskBytesReadRate { get; set; }

        /// <summary>
        /// burst bytes read rate of the disk offering
        /// </summary>
        public long DiskBytesReadRateMax { get; set; }

        /// <summary>
        /// length (in seconds) of the burst
        /// </summary>
        public long DiskBytesReadRateMaxLength { get; set; }

        /// <summary>
        /// bytes write rate of the service offering
        /// </summary>
        public long DiskBytesWriteRate { get; set; }

        /// <summary>
        /// burst bytes write rate of the disk offering
        /// </summary>
        public long DiskBytesWriteRateMax { get; set; }

        /// <summary>
        /// length (in seconds) of the burst
        /// </summary>
        public long DiskBytesWriteRateMaxLength { get; set; }

        /// <summary>
        /// io requests read rate of the service offering
        /// </summary>
        public long DiskIopsReadRate { get; set; }

        /// <summary>
        /// burst io requests read rate of the disk offering
        /// </summary>
        public long DiskIopsReadRateMax { get; set; }

        /// <summary>
        /// length (in second) of the burst
        /// </summary>
        public long DiskIopsReadRateMaxLength { get; set; }

        /// <summary>
        /// io requests write rate of the service offering
        /// </summary>
        public long DiskIopsWriteRate { get; set; }

        /// <summary>
        /// burst io requests write rate of the disk offering
        /// </summary>
        public long DiskIopsWriteRateMax { get; set; }

        /// <summary>
        /// length (in seconds) of the burst
        /// </summary>
        public long DiskIopsWriteRateMaxLength { get; set; }

        /// <summary>
        /// the display text of the disk offering
        /// </summary>
        public string DiskOfferingDisplayText { get; set; }

        /// <summary>
        /// the ID of the disk offering to which service offering is linked
        /// </summary>
        public string DiskOfferingId { get; set; }

        /// <summary>
        /// name of the disk offering
        /// </summary>
        public string DiskOfferingName { get; set; }

        /// <summary>
        /// True/False to indicate the strictness of the disk offering association with the compute offering. When set to true, override of disk offering is not allowed when VM is deployed and change disk offering is not allowed for the ROOT disk after the VM is deployed
        /// </summary>
        public bool DiskOfferingStrictness { get; set; }

        /// <summary>
        /// an alternate display text of the service offering.
        /// </summary>
        public string DisplayText { get; set; }

        /// <summary>
        /// the domain name(s) this disk offering belongs to. Ignore this information as it is not currently applicable.
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// the domain ID(s) this disk offering belongs to. Ignore this information as it is not currently applicable.
        /// </summary>
        public string DomainId { get; set; }

        /// <summary>
        /// true if virtual machine needs to be dynamically scalable of cpu or memory
        /// </summary>
        public bool DynamicScalingEnabled { get; set; }

        /// <summary>
        /// true if virtual machine root disk will be encrypted on storage
        /// </summary>
        public bool EncryptRoot { get; set; }

        /// <summary>
        /// the host tag for the service offering
        /// </summary>
        public string Hosttags { get; set; }

        /// <summary>
        /// Hypervisor snapshot reserve space as a percent of a volume (for managed storage using Xen or VMware)
        /// </summary>
        public int? HypervisorSnapshotReserve { get; set; }

        /// <summary>
        /// is true if the offering is customized
        /// </summary>
        public bool IsCustomized { get; set; }

        /// <summary>
        /// true if disk offering uses custom iops, false otherwise
        /// </summary>
        public bool Iscustomizediops { get; set; }

        /// <summary>
        /// is this a system vm offering
        /// </summary>
        public bool IsSystem { get; set; }

        /// <summary>
        /// true if the vm needs to be volatile, i.e., on every reboot of vm from API root disk is discarded and creates a new root disk
        /// </summary>
        public bool IsVolatile { get; set; }

        /// <summary>
        /// restrict the CPU usage to committed service offering
        /// </summary>
        public bool LimitCpuUse { get; set; }

        /// <summary>
        /// the max iops of the disk offering
        /// </summary>
        public long MaxIops { get; set; }

        /// <summary>
        /// the memory in MB
        /// </summary>
        public int? Memory { get; set; }

        /// <summary>
        /// the min iops of the disk offering
        /// </summary>
        public long MinIops { get; set; }

        /// <summary>
        /// the name of the service offering
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// data transfer rate in megabits per second allowed.
        /// </summary>
        public int? NetworkRate { get; set; }

        /// <summary>
        /// the ha support in the service offering
        /// </summary>
        public bool OfferHa { get; set; }

        /// <summary>
        /// provisioning type used to create volumes. Valid values are thin, sparse, fat.
        /// </summary>
        public string ProvisioningType { get; set; }

        /// <summary>
        /// Root disk size in GB
        /// </summary>
        public long RootDiskSize { get; set; }

        /// <summary>
        /// additional key/value details tied with this service offering
        /// </summary>
        public IDictionary<string, string> Serviceofferingdetails { get; set; }

        /// <summary>
        /// the tags for the service offering
        /// </summary>
        public string Storagetags { get; set; }

        /// <summary>
        /// the storage type for this service offering
        /// </summary>
        public string StorageType { get; set; }

        /// <summary>
        /// is this a the systemvm type for system vm offering
        /// </summary>
        public string Systemvmtype { get; set; }

        /// <summary>
        /// the vsphere storage policy tagged to the service offering in case of VMware
        /// </summary>
        public string VsphereStoragePolicy { get; set; }

        /// <summary>
        /// the zone name(s) this disk offering belongs to. Ignore this information as it is not currently applicable.
        /// </summary>
        public string Zone { get; set; }

        /// <summary>
        /// the zone ID(s) this disk offering belongs to. Ignore this information as it is not currently applicable.
        /// </summary>
        public string ZoneId { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
