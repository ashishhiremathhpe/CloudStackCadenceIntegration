using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateNetworkRequest : APIRequest
    {
        public CreateNetworkRequest() : base("createNetwork") {}

        /// <summary>
        /// the name of the network
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// the network offering ID
        /// </summary>
        public Guid NetworkOfferingId {
            get { return GetParameterValue<Guid>(nameof(NetworkOfferingId).ToLower()); }
            set { SetParameterValue(nameof(NetworkOfferingId).ToLower(), value); }
        }

        /// <summary>
        /// the zone ID for the network
        /// </summary>
        public Guid ZoneId {
            get { return GetParameterValue<Guid>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

        /// <summary>
        /// Account that will own the network. Account should be under the selected domain
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// Network ACL ID associated for the network
        /// </summary>
        public Guid? AclId {
            get { return GetParameterValue<Guid?>(nameof(AclId).ToLower()); }
            set { SetParameterValue(nameof(AclId).ToLower(), value); }
        }

        /// <summary>
        /// Access control type; supported values are account and domain. In 3.0 all shared networks should have aclType=Domain, and all isolated networks - Account. Account means that only the account owner can use the network, domain - all accounts in the domain can use the network
        /// </summary>
        public string AclType {
            get { return GetParameterValue<string>(nameof(AclType).ToLower()); }
            set { SetParameterValue(nameof(AclType).ToLower(), value); }
        }

        /// <summary>
        /// The network this network is associated to. only available if create a Shared network
        /// </summary>
        public Guid? AssociatedNetworkId {
            get { return GetParameterValue<Guid?>(nameof(AssociatedNetworkId).ToLower()); }
            set { SetParameterValue(nameof(AssociatedNetworkId).ToLower(), value); }
        }

        /// <summary>
        /// when true bypasses VLAN id/range overlap check during network creation for shared and L2 networks
        /// </summary>
        public bool? BypassVlanOverlapCheck {
            get { return GetParameterValue<bool?>(nameof(BypassVlanOverlapCheck).ToLower()); }
            set { SetParameterValue(nameof(BypassVlanOverlapCheck).ToLower(), value); }
        }

        /// <summary>
        /// an optional field, whether to the display the network to the end user or not.
        /// </summary>
        public bool? DisplayNetwork {
            get { return GetParameterValue<bool?>(nameof(DisplayNetwork).ToLower()); }
            set { SetParameterValue(nameof(DisplayNetwork).ToLower(), value); }
        }

        /// <summary>
        /// the display text of the network
        /// </summary>
        public string DisplayText {
            get { return GetParameterValue<string>(nameof(DisplayText).ToLower()); }
            set { SetParameterValue(nameof(DisplayText).ToLower(), value); }
        }

        /// <summary>
        /// the first IPv4 DNS for the network
        /// </summary>
        public string Dns1 {
            get { return GetParameterValue<string>(nameof(Dns1).ToLower()); }
            set { SetParameterValue(nameof(Dns1).ToLower(), value); }
        }

        /// <summary>
        /// the second IPv4 DNS for the network
        /// </summary>
        public string Dns2 {
            get { return GetParameterValue<string>(nameof(Dns2).ToLower()); }
            set { SetParameterValue(nameof(Dns2).ToLower(), value); }
        }

        /// <summary>
        /// domain ID of the account owning a network. If the account is not specified, but the acltype is Account or not specified, the network will be automatically assigned to the caller account and domain. To create a network under the domain without linking it to any account, make sure to include acltype=Domain parameter in the api call. If account is not specified, but acltype is Domain, the network will be created for the specified domain.
        /// </summary>
        public Guid? DomainId {
            get { return GetParameterValue<Guid?>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// the ending IP address in the network IP range. If not specified, will be defaulted to startIP
        /// </summary>
        public string EndIp {
            get { return GetParameterValue<string>(nameof(EndIp).ToLower()); }
            set { SetParameterValue(nameof(EndIp).ToLower(), value); }
        }

        /// <summary>
        /// the ending IPv6 address in the IPv6 network range
        /// </summary>
        public string EndIpv6 {
            get { return GetParameterValue<string>(nameof(EndIpv6).ToLower()); }
            set { SetParameterValue(nameof(EndIpv6).ToLower(), value); }
        }

        /// <summary>
        /// ID of the network in an external system.
        /// </summary>
        public string ExternalId {
            get { return GetParameterValue<string>(nameof(ExternalId).ToLower()); }
            set { SetParameterValue(nameof(ExternalId).ToLower(), value); }
        }

        /// <summary>
        /// the gateway of the network. Required for shared networks and isolated networks when it belongs to VPC
        /// </summary>
        public string Gateway {
            get { return GetParameterValue<string>(nameof(Gateway).ToLower()); }
            set { SetParameterValue(nameof(Gateway).ToLower(), value); }
        }

        /// <summary>
        /// when true ip address usage for the network will not be exported by the listUsageRecords API
        /// </summary>
        public bool? HideIpAddressUsage {
            get { return GetParameterValue<bool?>(nameof(HideIpAddressUsage).ToLower()); }
            set { SetParameterValue(nameof(HideIpAddressUsage).ToLower(), value); }
        }

        /// <summary>
        /// the CIDR of IPv6 network, must be at least /64
        /// </summary>
        public string Ip6Cidr {
            get { return GetParameterValue<string>(nameof(Ip6Cidr).ToLower()); }
            set { SetParameterValue(nameof(Ip6Cidr).ToLower(), value); }
        }

        /// <summary>
        /// the first IPv6 DNS for the network
        /// </summary>
        public string Ip6Dns1 {
            get { return GetParameterValue<string>(nameof(Ip6Dns1).ToLower()); }
            set { SetParameterValue(nameof(Ip6Dns1).ToLower(), value); }
        }

        /// <summary>
        /// the second IPv6 DNS for the network
        /// </summary>
        public string Ip6Dns2 {
            get { return GetParameterValue<string>(nameof(Ip6Dns2).ToLower()); }
            set { SetParameterValue(nameof(Ip6Dns2).ToLower(), value); }
        }

        /// <summary>
        /// the gateway of the IPv6 network. Required for Shared networks
        /// </summary>
        public string Ip6Gateway {
            get { return GetParameterValue<string>(nameof(Ip6Gateway).ToLower()); }
            set { SetParameterValue(nameof(Ip6Gateway).ToLower(), value); }
        }

        /// <summary>
        /// the isolated private VLAN for this network
        /// </summary>
        public string IsolatedPvlan {
            get { return GetParameterValue<string>(nameof(IsolatedPvlan).ToLower()); }
            set { SetParameterValue(nameof(IsolatedPvlan).ToLower(), value); }
        }

        /// <summary>
        /// the isolated private VLAN type for this network
        /// </summary>
        public string IsolatedPvlanType {
            get { return GetParameterValue<string>(nameof(IsolatedPvlanType).ToLower()); }
            set { SetParameterValue(nameof(IsolatedPvlanType).ToLower(), value); }
        }

        /// <summary>
        /// the netmask of the network. Required for shared networks and isolated networks when it belongs to VPC
        /// </summary>
        public string Netmask {
            get { return GetParameterValue<string>(nameof(Netmask).ToLower()); }
            set { SetParameterValue(nameof(Netmask).ToLower(), value); }
        }

        /// <summary>
        /// network domain
        /// </summary>
        public string NetworkDomain {
            get { return GetParameterValue<string>(nameof(NetworkDomain).ToLower()); }
            set { SetParameterValue(nameof(NetworkDomain).ToLower(), value); }
        }

        /// <summary>
        /// the physical network ID the network belongs to
        /// </summary>
        public Guid? PhysicalNetworkId {
            get { return GetParameterValue<Guid?>(nameof(PhysicalNetworkId).ToLower()); }
            set { SetParameterValue(nameof(PhysicalNetworkId).ToLower(), value); }
        }

        /// <summary>
        /// MTU to be configured on the network VR's private interface(s)
        /// </summary>
        public int? PrivateMtu {
            get { return GetParameterValue<int?>(nameof(PrivateMtu).ToLower()); }
            set { SetParameterValue(nameof(PrivateMtu).ToLower(), value); }
        }

        /// <summary>
        /// an optional project for the network
        /// </summary>
        public Guid? ProjectId {
            get { return GetParameterValue<Guid?>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
        }

        /// <summary>
        /// MTU to be configured on the network VR's public facing interfaces
        /// </summary>
        public int? PublicMtu {
            get { return GetParameterValue<int?>(nameof(PublicMtu).ToLower()); }
            set { SetParameterValue(nameof(PublicMtu).ToLower(), value); }
        }

        /// <summary>
        /// IPV4 address to be assigned to a router in a shared network
        /// </summary>
        public string RouterIp {
            get { return GetParameterValue<string>(nameof(RouterIp).ToLower()); }
            set { SetParameterValue(nameof(RouterIp).ToLower(), value); }
        }

        /// <summary>
        /// IPV6 address to be assigned to a router in a shared network
        /// </summary>
        public string RouterIpv6 {
            get { return GetParameterValue<string>(nameof(RouterIpv6).ToLower()); }
            set { SetParameterValue(nameof(RouterIpv6).ToLower(), value); }
        }

        /// <summary>
        /// IPV4 address to be assigned to the public interface of the network router. This address will be used as source NAT address for the network. 
        /// If an address is given and it cannot be acquired, an error will be returned and the network won´t be implemented,
        /// </summary>
        public string Sourcenatipaddress {
            get { return GetParameterValue<string>(nameof(Sourcenatipaddress).ToLower()); }
            set { SetParameterValue(nameof(Sourcenatipaddress).ToLower(), value); }
        }

        /// <summary>
        /// the beginning IP address in the network IP range
        /// </summary>
        public string StartIp {
            get { return GetParameterValue<string>(nameof(StartIp).ToLower()); }
            set { SetParameterValue(nameof(StartIp).ToLower(), value); }
        }

        /// <summary>
        /// the beginning IPv6 address in the IPv6 network range
        /// </summary>
        public string StartIpv6 {
            get { return GetParameterValue<string>(nameof(StartIpv6).ToLower()); }
            set { SetParameterValue(nameof(StartIpv6).ToLower(), value); }
        }

        /// <summary>
        /// Defines whether to allow subdomains to use networks dedicated to their parent domain(s). Should be used with aclType=Domain, defaulted to allow.subdomain.network.access global config if not specified
        /// </summary>
        public bool? SubdomainAccess {
            get { return GetParameterValue<bool?>(nameof(SubdomainAccess).ToLower()); }
            set { SetParameterValue(nameof(SubdomainAccess).ToLower(), value); }
        }

        /// <summary>
        /// Tungsten-Fabric virtual router the network belongs to
        /// </summary>
        public string TungstenVirtualRouterUuid {
            get { return GetParameterValue<string>(nameof(TungstenVirtualRouterUuid).ToLower()); }
            set { SetParameterValue(nameof(TungstenVirtualRouterUuid).ToLower(), value); }
        }

        /// <summary>
        /// the ID or VID of the network
        /// </summary>
        public string Vlan {
            get { return GetParameterValue<string>(nameof(Vlan).ToLower()); }
            set { SetParameterValue(nameof(Vlan).ToLower(), value); }
        }

        /// <summary>
        /// the VPC network belongs to
        /// </summary>
        public Guid? VpcId {
            get { return GetParameterValue<Guid?>(nameof(VpcId).ToLower()); }
            set { SetParameterValue(nameof(VpcId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Creates a network
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        NetworkResponse CreateNetwork(CreateNetworkRequest request);
        Task<NetworkResponse> CreateNetworkAsync(CreateNetworkRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public NetworkResponse CreateNetwork(CreateNetworkRequest request) => Proxy.Request<NetworkResponse>(request);
        public Task<NetworkResponse> CreateNetworkAsync(CreateNetworkRequest request) => Proxy.RequestAsync<NetworkResponse>(request);
    }
}
