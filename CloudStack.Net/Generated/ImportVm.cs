using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ImportVmRequest : APIRequest
    {
        public ImportVmRequest() : base("importVm") {}

        /// <summary>
        /// the cluster ID
        /// </summary>
        public Guid ClusterId {
            get { return GetParameterValue<Guid>(nameof(ClusterId).ToLower()); }
            set { SetParameterValue(nameof(ClusterId).ToLower(), value); }
        }

        /// <summary>
        /// hypervisor type of the host
        /// </summary>
        public string Hypervisor {
            get { return GetParameterValue<string>(nameof(Hypervisor).ToLower()); }
            set { SetParameterValue(nameof(Hypervisor).ToLower(), value); }
        }

        /// <summary>
        /// Source location for Import
        /// </summary>
        public string ImportSource {
            get { return GetParameterValue<string>(nameof(ImportSource).ToLower()); }
            set { SetParameterValue(nameof(ImportSource).ToLower(), value); }
        }

        /// <summary>
        /// the name of the instance as it is known to the hypervisor
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// the service offering for the virtual machine
        /// </summary>
        public Guid ServiceOfferingId {
            get { return GetParameterValue<Guid>(nameof(ServiceOfferingId).ToLower()); }
            set { SetParameterValue(nameof(ServiceOfferingId).ToLower(), value); }
        }

        /// <summary>
        /// the zone ID
        /// </summary>
        public Guid ZoneId {
            get { return GetParameterValue<Guid>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

        /// <summary>
        /// an optional account for the virtual machine. Must be used with domainId.
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// (only for importing migrated VMs from Vmware to KVM) Name of VMware cluster.
        /// </summary>
        public string ClusterName {
            get { return GetParameterValue<string>(nameof(ClusterName).ToLower()); }
            set { SetParameterValue(nameof(ClusterName).ToLower(), value); }
        }

        /// <summary>
        /// (only for importing migrated VMs from Vmware to KVM) optional - the host to perform the virt-v2v migration from VMware to KVM.
        /// </summary>
        public Guid? ConvertInstanceHostId {
            get { return GetParameterValue<Guid?>(nameof(ConvertInstanceHostId).ToLower()); }
            set { SetParameterValue(nameof(ConvertInstanceHostId).ToLower(), value); }
        }

        /// <summary>
        /// (only for importing migrated VMs from Vmware to KVM) optional - the temporary storage pool to perform the virt-v2v migration from VMware to KVM.
        /// </summary>
        public Guid? Convertinstancepoolid {
            get { return GetParameterValue<Guid?>(nameof(Convertinstancepoolid).ToLower()); }
            set { SetParameterValue(nameof(Convertinstancepoolid).ToLower(), value); }
        }

        /// <summary>
        /// (only for importing migrated VMs from Vmware to KVM) Name of VMware datacenter.
        /// </summary>
        public string DatacenterName {
            get { return GetParameterValue<string>(nameof(DatacenterName).ToLower()); }
            set { SetParameterValue(nameof(DatacenterName).ToLower(), value); }
        }

        /// <summary>
        /// datadisk template to disk-offering mapping using keys disk and diskOffering
        /// </summary>
        public IList<IDictionary<string, object>> Datadiskofferinglist {
            get { return GetList<IDictionary<string, object>>(nameof(Datadiskofferinglist).ToLower()); }
            set { SetParameterValue(nameof(Datadiskofferinglist).ToLower(), value); }
        }

        /// <summary>
        /// used to specify the custom parameters.
        /// </summary>
        public IList<IDictionary<string, object>> Details {
            get { return GetList<IDictionary<string, object>>(nameof(Details).ToLower()); }
            set { SetParameterValue(nameof(Details).ToLower(), value); }
        }

        /// <summary>
        /// path of the disk image
        /// </summary>
        public string DiskPath {
            get { return GetParameterValue<string>(nameof(DiskPath).ToLower()); }
            set { SetParameterValue(nameof(DiskPath).ToLower(), value); }
        }

        /// <summary>
        /// the display name of the instance
        /// </summary>
        public string DisplayName {
            get { return GetParameterValue<string>(nameof(DisplayName).ToLower()); }
            set { SetParameterValue(nameof(DisplayName).ToLower(), value); }
        }

        /// <summary>
        /// import instance to the domain specified
        /// </summary>
        public Guid? DomainId {
            get { return GetParameterValue<Guid?>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// (only for importing migrated VMs from Vmware to KVM) UUID of a linked existing vCenter
        /// </summary>
        public Guid? ExistingVcenterId {
            get { return GetParameterValue<Guid?>(nameof(ExistingVcenterId).ToLower()); }
            set { SetParameterValue(nameof(ExistingVcenterId).ToLower(), value); }
        }

        /// <summary>
        /// VM is imported despite some of its NIC's MAC addresses are already present, in case the MAC address exists then a new MAC address is generated
        /// </summary>
        public bool? Forced {
            get { return GetParameterValue<bool?>(nameof(Forced).ToLower()); }
            set { SetParameterValue(nameof(Forced).ToLower(), value); }
        }

        /// <summary>
        /// the host name or IP address
        /// </summary>
        public string Host {
            get { return GetParameterValue<string>(nameof(Host).ToLower()); }
            set { SetParameterValue(nameof(Host).ToLower(), value); }
        }

        /// <summary>
        /// Host where local disk is located
        /// </summary>
        public Guid? HostId {
            get { return GetParameterValue<Guid?>(nameof(HostId).ToLower()); }
            set { SetParameterValue(nameof(HostId).ToLower(), value); }
        }

        /// <summary>
        /// (only for importing migrated VMs from Vmware to KVM) VMware ESXi host IP/Name.
        /// </summary>
        public string Hostip {
            get { return GetParameterValue<string>(nameof(Hostip).ToLower()); }
            set { SetParameterValue(nameof(Hostip).ToLower(), value); }
        }

        /// <summary>
        /// the host name of the instance
        /// </summary>
        public string HostName {
            get { return GetParameterValue<string>(nameof(HostName).ToLower()); }
            set { SetParameterValue(nameof(HostName).ToLower(), value); }
        }

        /// <summary>
        /// vm and its volumes are allowed to migrate to different host/pool when offerings passed are incompatible with current host/pool
        /// </summary>
        public bool? MigrateAllowed {
            get { return GetParameterValue<bool?>(nameof(MigrateAllowed).ToLower()); }
            set { SetParameterValue(nameof(MigrateAllowed).ToLower(), value); }
        }

        /// <summary>
        /// the network ID
        /// </summary>
        public Guid? NetworkId {
            get { return GetParameterValue<Guid?>(nameof(NetworkId).ToLower()); }
            set { SetParameterValue(nameof(NetworkId).ToLower(), value); }
        }

        /// <summary>
        /// VM nic to ip address mapping using keys nic, ip4Address
        /// </summary>
        public IList<IDictionary<string, object>> NicIpAddressList {
            get { return GetList<IDictionary<string, object>>(nameof(NicIpAddressList).ToLower()); }
            set { SetParameterValue(nameof(NicIpAddressList).ToLower(), value); }
        }

        /// <summary>
        /// VM nic to network id mapping using keys nic and network
        /// </summary>
        public IList<IDictionary<string, object>> NicNetworkList {
            get { return GetList<IDictionary<string, object>>(nameof(NicNetworkList).ToLower()); }
            set { SetParameterValue(nameof(NicNetworkList).ToLower(), value); }
        }

        /// <summary>
        /// the password for the host
        /// </summary>
        public string Password {
            get { return GetParameterValue<string>(nameof(Password).ToLower()); }
            set { SetParameterValue(nameof(Password).ToLower(), value); }
        }

        /// <summary>
        /// import instance for the project
        /// </summary>
        public Guid? ProjectId {
            get { return GetParameterValue<Guid?>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
        }

        /// <summary>
        /// Shared storage pool where disk is located
        /// </summary>
        public Guid? Storageid {
            get { return GetParameterValue<Guid?>(nameof(Storageid).ToLower()); }
            set { SetParameterValue(nameof(Storageid).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the template for the virtual machine
        /// </summary>
        public Guid? TemplateId {
            get { return GetParameterValue<Guid?>(nameof(TemplateId).ToLower()); }
            set { SetParameterValue(nameof(TemplateId).ToLower(), value); }
        }

        /// <summary>
        /// Temp Path on external host for disk image copy
        /// </summary>
        public string Temppath {
            get { return GetParameterValue<string>(nameof(Temppath).ToLower()); }
            set { SetParameterValue(nameof(Temppath).ToLower(), value); }
        }

        /// <summary>
        /// the username for the host
        /// </summary>
        public string Username {
            get { return GetParameterValue<string>(nameof(Username).ToLower()); }
            set { SetParameterValue(nameof(Username).ToLower(), value); }
        }

        /// <summary>
        /// (only for importing migrated VMs from Vmware to KVM) The name/ip of vCenter. Make sure it is IP address or full qualified domain name for host running vCenter server.
        /// </summary>
        public string Vcenter {
            get { return GetParameterValue<string>(nameof(Vcenter).ToLower()); }
            set { SetParameterValue(nameof(Vcenter).ToLower(), value); }
        }

    }
    /// <summary>
    /// Import virtual machine from a unmanaged host into CloudStack
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse ImportVm(ImportVmRequest request);
        Task<AsyncJobResponse> ImportVmAsync(ImportVmRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse ImportVm(ImportVmRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> ImportVmAsync(ImportVmRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
