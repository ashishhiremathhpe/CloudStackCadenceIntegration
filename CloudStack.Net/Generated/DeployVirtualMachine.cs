using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeployVirtualMachineRequest : APIRequest
    {
        public DeployVirtualMachineRequest() : base("deployVirtualMachine") {}

        /// <summary>
        /// the ID of the service offering for the virtual machine
        /// </summary>
        public Guid ServiceOfferingId {
            get { return GetParameterValue<Guid>(nameof(ServiceOfferingId).ToLower()); }
            set { SetParameterValue(nameof(ServiceOfferingId).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the template for the virtual machine
        /// </summary>
        public Guid TemplateId {
            get { return GetParameterValue<Guid>(nameof(TemplateId).ToLower()); }
            set { SetParameterValue(nameof(TemplateId).ToLower(), value); }
        }

        /// <summary>
        /// availability zone for the virtual machine
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
        /// comma separated list of affinity groups id that are going to be applied to the virtual machine. Mutually exclusive with affinitygroupnames parameter
        /// </summary>
        public IList<Guid> Affinitygroupids {
            get { return GetList<Guid>(nameof(Affinitygroupids).ToLower()); }
            set { SetParameterValue(nameof(Affinitygroupids).ToLower(), value); }
        }

        /// <summary>
        /// comma separated list of affinity groups names that are going to be applied to the virtual machine.Mutually exclusive with affinitygroupids parameter
        /// </summary>
        public IList<string> Affinitygroupnames {
            get { return GetList<string>(nameof(Affinitygroupnames).ToLower()); }
            set { SetParameterValue(nameof(Affinitygroupnames).ToLower(), value); }
        }

        /// <summary>
        /// Boot into hardware setup or not (ignored if startVm = false, only valid for vmware)
        /// </summary>
        public bool? BootIntoSetup {
            get { return GetParameterValue<bool?>(nameof(BootIntoSetup).ToLower()); }
            set { SetParameterValue(nameof(BootIntoSetup).ToLower(), value); }
        }

        /// <summary>
        /// Boot Mode [Legacy] or [Secure] Applicable when Boot Type Selected is UEFI, otherwise Legacy only for BIOS. Not applicable with VMware if the template is marked as deploy-as-is, as we honour what is defined in the template.
        /// </summary>
        public string BootMode {
            get { return GetParameterValue<string>(nameof(BootMode).ToLower()); }
            set { SetParameterValue(nameof(BootMode).ToLower(), value); }
        }

        /// <summary>
        /// Guest VM Boot option either custom[UEFI] or default boot [BIOS]. Not applicable with VMware if the template is marked as deploy-as-is, as we honour what is defined in the template.
        /// </summary>
        public string BootType {
            get { return GetParameterValue<string>(nameof(BootType).ToLower()); }
            set { SetParameterValue(nameof(BootType).ToLower(), value); }
        }

        /// <summary>
        /// destination Cluster ID to deploy the VM to - parameter available for root admin only
        /// </summary>
        public Guid? ClusterId {
            get { return GetParameterValue<Guid?>(nameof(ClusterId).ToLower()); }
            set { SetParameterValue(nameof(ClusterId).ToLower(), value); }
        }

        /// <summary>
        /// if true the image tags (if any) will be copied to the VM, default value is false
        /// </summary>
        public bool? CopyImageTags {
            get { return GetParameterValue<bool?>(nameof(CopyImageTags).ToLower()); }
            set { SetParameterValue(nameof(CopyImageTags).ToLower(), value); }
        }

        /// <summary>
        /// an optional field, in case you want to set a custom id to the resource. Allowed to Root Admins only
        /// </summary>
        public string CustomId {
            get { return GetParameterValue<string>(nameof(CustomId).ToLower()); }
            set { SetParameterValue(nameof(CustomId).ToLower(), value); }
        }

        /// <summary>
        /// datadisk template to disk-offering mapping; an optional parameter used to create additional data disks from datadisk templates; can't be specified with diskOfferingId parameter
        /// </summary>
        public IList<IDictionary<string, object>> Datadiskofferinglist {
            get { return GetList<IDictionary<string, object>>(nameof(Datadiskofferinglist).ToLower()); }
            set { SetParameterValue(nameof(Datadiskofferinglist).ToLower(), value); }
        }

        /// <summary>
        /// Deployment planner to use for vm allocation. Available to ROOT admin only
        /// </summary>
        public string DeploymentPlanner {
            get { return GetParameterValue<string>(nameof(DeploymentPlanner).ToLower()); }
            set { SetParameterValue(nameof(DeploymentPlanner).ToLower(), value); }
        }

        /// <summary>
        /// used to specify the custom parameters. 'extraconfig' is not allowed to be passed in details
        /// </summary>
        public IList<IDictionary<string, object>> Details {
            get { return GetList<IDictionary<string, object>>(nameof(Details).ToLower()); }
            set { SetParameterValue(nameof(Details).ToLower(), value); }
        }

        /// <summary>
        /// DHCP options which are passed to the VM on start up Example: dhcpoptionsnetworklist[0].dhcp:114=url&dhcpoptionsetworklist[0].networkid=networkid&dhcpoptionsetworklist[0].dhcp:66=www.test.com
        /// </summary>
        public IList<IDictionary<string, object>> DhcpOptionsNetworkList {
            get { return GetList<IDictionary<string, object>>(nameof(DhcpOptionsNetworkList).ToLower()); }
            set { SetParameterValue(nameof(DhcpOptionsNetworkList).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the disk offering for the virtual machine. If the template is of ISO format, the diskOfferingId is for the root disk volume. Otherwise this parameter is used to indicate the offering for the data disk volume. If the templateId parameter passed is from a Template object, the diskOfferingId refers to a DATA Disk Volume created. If the templateId parameter passed is from an ISO object, the diskOfferingId refers to a ROOT Disk Volume created.
        /// </summary>
        public Guid? DiskOfferingId {
            get { return GetParameterValue<Guid?>(nameof(DiskOfferingId).ToLower()); }
            set { SetParameterValue(nameof(DiskOfferingId).ToLower(), value); }
        }

        /// <summary>
        /// an optional user generated name for the virtual machine
        /// </summary>
        public string DisplayName {
            get { return GetParameterValue<string>(nameof(DisplayName).ToLower()); }
            set { SetParameterValue(nameof(DisplayName).ToLower(), value); }
        }

        /// <summary>
        /// an optional field, whether to the display the vm to the end user or not.
        /// </summary>
        public bool? DisplayVm {
            get { return GetParameterValue<bool?>(nameof(DisplayVm).ToLower()); }
            set { SetParameterValue(nameof(DisplayVm).ToLower(), value); }
        }

        /// <summary>
        /// an optional domainId for the virtual machine. If the account parameter is used, domainId must also be used. If account is NOT provided then virtual machine will be assigned to the caller account and domain.
        /// </summary>
        public Guid? DomainId {
            get { return GetParameterValue<Guid?>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// true if virtual machine needs to be dynamically scalable
        /// </summary>
        public bool? DynamicScalingEnabled {
            get { return GetParameterValue<bool?>(nameof(DynamicScalingEnabled).ToLower()); }
            set { SetParameterValue(nameof(DynamicScalingEnabled).ToLower(), value); }
        }

        /// <summary>
        /// an optional URL encoded string that can be passed to the virtual machine upon successful deployment
        /// </summary>
        public string ExtraConfig {
            get { return GetParameterValue<string>(nameof(ExtraConfig).ToLower()); }
            set { SetParameterValue(nameof(ExtraConfig).ToLower(), value); }
        }

        /// <summary>
        /// an optional group for the virtual machine
        /// </summary>
        public string Group {
            get { return GetParameterValue<string>(nameof(Group).ToLower()); }
            set { SetParameterValue(nameof(Group).ToLower(), value); }
        }

        /// <summary>
        /// destination Host ID to deploy the VM to - parameter available for root admin only
        /// </summary>
        public Guid? HostId {
            get { return GetParameterValue<Guid?>(nameof(HostId).ToLower()); }
            set { SetParameterValue(nameof(HostId).ToLower(), value); }
        }

        /// <summary>
        /// the hypervisor on which to deploy the virtual machine. The parameter is required and respected only when hypervisor info is not set on the ISO/Template passed to the call
        /// </summary>
        public string Hypervisor {
            get { return GetParameterValue<string>(nameof(Hypervisor).ToLower()); }
            set { SetParameterValue(nameof(Hypervisor).ToLower(), value); }
        }

        /// <summary>
        /// Controls specific policies on IO
        /// </summary>
        public string IoDriverPolicy {
            get { return GetParameterValue<string>(nameof(IoDriverPolicy).ToLower()); }
            set { SetParameterValue(nameof(IoDriverPolicy).ToLower(), value); }
        }

        /// <summary>
        /// IOThreads are dedicated event loop threads for supported disk devices to perform block I/O requests in order to improve scalability especially on an SMP host/guest with many LUNs.
        /// </summary>
        public bool? IothreadsEnabled {
            get { return GetParameterValue<bool?>(nameof(IothreadsEnabled).ToLower()); }
            set { SetParameterValue(nameof(IothreadsEnabled).ToLower(), value); }
        }

        /// <summary>
        /// the ipv6 address for default vm's network
        /// </summary>
        public string Ip6Address {
            get { return GetParameterValue<string>(nameof(Ip6Address).ToLower()); }
            set { SetParameterValue(nameof(Ip6Address).ToLower(), value); }
        }

        /// <summary>
        /// the ip address for default vm's network
        /// </summary>
        public string IpAddress {
            get { return GetParameterValue<string>(nameof(IpAddress).ToLower()); }
            set { SetParameterValue(nameof(IpAddress).ToLower(), value); }
        }

        /// <summary>
        /// ip to network mapping. Can't be specified with networkIds parameter. Example: iptonetworklist[0].ip=10.10.10.11&iptonetworklist[0].ipv6=fc00:1234:5678::abcd&iptonetworklist[0].networkid=uuid&iptonetworklist[0].mac=aa:bb:cc:dd:ee::ff - requests to use ip 10.10.10.11 in network id=uuid
        /// </summary>
        public IList<IDictionary<string, object>> IpToNetworkList {
            get { return GetList<IDictionary<string, object>>(nameof(IpToNetworkList).ToLower()); }
            set { SetParameterValue(nameof(IpToNetworkList).ToLower(), value); }
        }

        /// <summary>
        /// an optional keyboard device type for the virtual machine. valid value can be one of de,de-ch,es,fi,fr,fr-be,fr-ch,is,it,jp,nl-be,no,pt,uk,us
        /// </summary>
        public string Keyboard {
            get { return GetParameterValue<string>(nameof(Keyboard).ToLower()); }
            set { SetParameterValue(nameof(Keyboard).ToLower(), value); }
        }

        /// <summary>
        /// name of the ssh key pair used to login to the virtual machine
        /// </summary>
        public string Keypair {
            get { return GetParameterValue<string>(nameof(Keypair).ToLower()); }
            set { SetParameterValue(nameof(Keypair).ToLower(), value); }
        }

        /// <summary>
        /// names of the ssh key pairs used to login to the virtual machine
        /// </summary>
        public IList<string> Keypairs {
            get { return GetList<string>(nameof(Keypairs).ToLower()); }
            set { SetParameterValue(nameof(Keypairs).ToLower(), value); }
        }

        /// <summary>
        /// the mac address for default vm's network
        /// </summary>
        public string MacAddress {
            get { return GetParameterValue<string>(nameof(MacAddress).ToLower()); }
            set { SetParameterValue(nameof(MacAddress).ToLower(), value); }
        }

        /// <summary>
        /// host name for the virtual machine
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// list of network ids used by virtual machine. Can't be specified with ipToNetworkList parameter
        /// </summary>
        public IList<Guid> NetworkIds {
            get { return GetList<Guid>(nameof(NetworkIds).ToLower()); }
            set { SetParameterValue(nameof(NetworkIds).ToLower(), value); }
        }

        /// <summary>
        /// The number of queues for multiqueue NICs.
        /// </summary>
        public int? NicMultiqueueNumber {
            get { return GetParameterValue<int?>(nameof(NicMultiqueueNumber).ToLower()); }
            set { SetParameterValue(nameof(NicMultiqueueNumber).ToLower(), value); }
        }

        /// <summary>
        /// VMware only: used to specify network mapping of a vApp VMware template registered "as-is". Example nicnetworklist[0].ip=Nic-101&nicnetworklist[0].network=uuid
        /// </summary>
        public IList<IDictionary<string, object>> Nicnetworklist {
            get { return GetList<IDictionary<string, object>>(nameof(Nicnetworklist).ToLower()); }
            set { SetParameterValue(nameof(Nicnetworklist).ToLower(), value); }
        }

        /// <summary>
        /// Enable packed virtqueues or not.
        /// </summary>
        public bool? Nicpackedvirtqueuesenabled {
            get { return GetParameterValue<bool?>(nameof(Nicpackedvirtqueuesenabled).ToLower()); }
            set { SetParameterValue(nameof(Nicpackedvirtqueuesenabled).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the disk offering for the virtual machine to be used for root volume instead of the disk offering mapped in service offering.In case of virtual machine deploying from ISO, then the diskofferingid specified for root volume is ignored and uses this override disk offering id
        /// </summary>
        public Guid? OverrideDiskOfferingId {
            get { return GetParameterValue<Guid?>(nameof(OverrideDiskOfferingId).ToLower()); }
            set { SetParameterValue(nameof(OverrideDiskOfferingId).ToLower(), value); }
        }

        /// <summary>
        /// The password of the virtual machine. If null, a random password will be generated for the VM.
        /// </summary>
        public string Password {
            get { return GetParameterValue<string>(nameof(Password).ToLower()); }
            set { SetParameterValue(nameof(Password).ToLower(), value); }
        }

        /// <summary>
        /// destination Pod ID to deploy the VM to - parameter available for root admin only
        /// </summary>
        public Guid? PodId {
            get { return GetParameterValue<Guid?>(nameof(PodId).ToLower()); }
            set { SetParameterValue(nameof(PodId).ToLower(), value); }
        }

        /// <summary>
        /// Deploy vm for the project
        /// </summary>
        public Guid? ProjectId {
            get { return GetParameterValue<Guid?>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
        }

        /// <summary>
        /// used to specify the vApp properties.
        /// </summary>
        public IList<IDictionary<string, object>> Properties {
            get { return GetList<IDictionary<string, object>>(nameof(Properties).ToLower()); }
            set { SetParameterValue(nameof(Properties).ToLower(), value); }
        }

        /// <summary>
        /// Optional field to resize root disk on deploy. Value is in GB. Only applies to template-based deployments. Analogous to details[0].rootdisksize, which takes precedence over this parameter if both are provided
        /// </summary>
        public long? Rootdisksize {
            get { return GetParameterValue<long?>(nameof(Rootdisksize).ToLower()); }
            set { SetParameterValue(nameof(Rootdisksize).ToLower(), value); }
        }

        /// <summary>
        /// comma separated list of security groups id that going to be applied to the virtual machine. Should be passed only when vm is created from a zone with Basic Network support. Mutually exclusive with securitygroupnames parameter
        /// </summary>
        public IList<Guid> Securitygroupids {
            get { return GetList<Guid>(nameof(Securitygroupids).ToLower()); }
            set { SetParameterValue(nameof(Securitygroupids).ToLower(), value); }
        }

        /// <summary>
        /// comma separated list of security groups names that going to be applied to the virtual machine. Should be passed only when vm is created from a zone with Basic Network support. Mutually exclusive with securitygroupids parameter
        /// </summary>
        public IList<string> Securitygroupnames {
            get { return GetList<string>(nameof(Securitygroupnames).ToLower()); }
            set { SetParameterValue(nameof(Securitygroupnames).ToLower(), value); }
        }

        /// <summary>
        /// the arbitrary size for the DATADISK volume. Mutually exclusive with diskOfferingId
        /// </summary>
        public long? Size {
            get { return GetParameterValue<long?>(nameof(Size).ToLower()); }
            set { SetParameterValue(nameof(Size).ToLower(), value); }
        }

        /// <summary>
        /// true if start vm after creating; defaulted to true if not specified
        /// </summary>
        public bool? StartVm {
            get { return GetParameterValue<bool?>(nameof(StartVm).ToLower()); }
            set { SetParameterValue(nameof(StartVm).ToLower(), value); }
        }

        /// <summary>
        /// an optional binary data that can be sent to the virtual machine upon a successful deployment. This binary data must be base64 encoded before adding it to the request. Using HTTP GET (via querystring), you can send up to 4KB of data after base64 encoding. Using HTTP POST(via POST body), you can send up to 1MB of data after base64 encoding.
        /// </summary>
        public string UserData {
            get { return GetParameterValue<string>(nameof(UserData).ToLower()); }
            set { SetParameterValue(nameof(UserData).ToLower(), value); }
        }

        /// <summary>
        /// used to specify the parameters values for the variables in userdata.
        /// </summary>
        public IList<IDictionary<string, object>> UserdataDetails {
            get { return GetList<IDictionary<string, object>>(nameof(UserdataDetails).ToLower()); }
            set { SetParameterValue(nameof(UserdataDetails).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the Userdata
        /// </summary>
        public Guid? UserdataId {
            get { return GetParameterValue<Guid?>(nameof(UserdataId).ToLower()); }
            set { SetParameterValue(nameof(UserdataId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Creates and automatically starts a virtual machine based on a service offering, disk offering, and template.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeployVirtualMachine(DeployVirtualMachineRequest request);
        Task<AsyncJobResponse> DeployVirtualMachineAsync(DeployVirtualMachineRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeployVirtualMachine(DeployVirtualMachineRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DeployVirtualMachineAsync(DeployVirtualMachineRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
