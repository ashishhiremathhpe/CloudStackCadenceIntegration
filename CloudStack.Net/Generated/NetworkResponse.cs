using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class NetworkResponse
    {
        /// <summary>
        /// the id of the network
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the owner of the network
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// ACL Id associated with the VPC network
        /// </summary>
        public string AclId { get; set; }

        /// <summary>
        /// ACL name associated with the VPC network
        /// </summary>
        public string AclName { get; set; }

        /// <summary>
        /// acl type - access type to the network
        /// </summary>
        public string AclType { get; set; }

        /// <summary>
        /// the name of the Network associated with this network
        /// </summary>
        public string Associatednetwork { get; set; }

        /// <summary>
        /// the ID of the Network associated with this network
        /// </summary>
        public string AssociatedNetworkId { get; set; }

        /// <summary>
        /// Broadcast domain type of the network
        /// </summary>
        public string BroadcastDomainType { get; set; }

        /// <summary>
        /// broadcast uri of the network. This parameter is visible to ROOT admins only
        /// </summary>
        public string BroadcastUri { get; set; }

        /// <summary>
        /// list networks available for vm deployment
        /// </summary>
        public bool CanUseForDeploy { get; set; }

        /// <summary>
        /// Cloudstack managed address space, all CloudStack managed VMs get IP address from CIDR
        /// </summary>
        public string Cidr { get; set; }

        /// <summary>
        /// the date this network was created
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// the details of the network
        /// </summary>
        public IDictionary<string, string> Details { get; set; }

        /// <summary>
        /// an optional field, whether to the display the network to the end user or not.
        /// </summary>
        public bool DisplayNetwork { get; set; }

        /// <summary>
        /// the displaytext of the network
        /// </summary>
        public string Displaytext { get; set; }

        /// <summary>
        /// the first IPv4 DNS for the network
        /// </summary>
        public string Dns1 { get; set; }

        /// <summary>
        /// the second IPv4 DNS for the network
        /// </summary>
        public string Dns2 { get; set; }

        /// <summary>
        /// the domain name of the network owner
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// the domain id of the network owner
        /// </summary>
        public string DomainId { get; set; }

        /// <summary>
        /// path of the Domain the network belongs to
        /// </summary>
        public string DomainPath { get; set; }

        /// <summary>
        /// true if guest network default egress policy is allow; false if default egress policy is deny
        /// </summary>
        public bool EgressDefaultPolicy { get; set; }

        /// <summary>
        /// The external id of the network
        /// </summary>
        public string ExternalId { get; set; }

        /// <summary>
        /// the network's gateway
        /// </summary>
        public string Gateway { get; set; }

        /// <summary>
        /// Base64 string representation of the resource icon
        /// </summary>
        public ResourceIconResponse Icon { get; set; }

        /// <summary>
        /// The internet protocol of network offering
        /// </summary>
        public string InternetProtocol { get; set; }

        /// <summary>
        /// the cidr of IPv6 network
        /// </summary>
        public string Ip6Cidr { get; set; }

        /// <summary>
        /// the first IPv6 DNS for the network
        /// </summary>
        public string Ip6dns1 { get; set; }

        /// <summary>
        /// the second IPv6 DNS for the network
        /// </summary>
        public string Ip6dns2 { get; set; }

        /// <summary>
        /// the gateway of IPv6 network
        /// </summary>
        public string Ip6Gateway { get; set; }

        /// <summary>
        /// The routes for the network to ease adding route in upstream router
        /// </summary>
        public IList<Ipv6RouteResponse> Ip6routes { get; set; }

        /// <summary>
        /// The routing mode of network offering
        /// </summary>
        public string Ip6routing { get; set; }

        /// <summary>
        /// true if network is default, false otherwise
        /// </summary>
        public bool IsDefault { get; set; }

        /// <summary>
        /// list networks that are persistent
        /// </summary>
        public bool IsPersistent { get; set; }

        /// <summary>
        /// true if network is system, false otherwise
        /// </summary>
        public bool IsSystem { get; set; }

        /// <summary>
        /// the name of the network
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// the network's netmask
        /// </summary>
        public string Netmask { get; set; }

        /// <summary>
        /// the network CIDR of the guest network configured with IP reservation. It is the summation of CIDR and RESERVED_IP_RANGE
        /// </summary>
        public string NetworkCidr { get; set; }

        /// <summary>
        /// the network domain
        /// </summary>
        public string NetworkDomain { get; set; }

        /// <summary>
        /// availability of the network offering the network is created from
        /// </summary>
        public string NetworkOfferingAvailability { get; set; }

        /// <summary>
        /// true if network offering is ip conserve mode enabled
        /// </summary>
        public bool NetworkOfferingConserveMode { get; set; }

        /// <summary>
        /// display text of the network offering the network is created from
        /// </summary>
        public string NetworkOfferingDisplayText { get; set; }

        /// <summary>
        /// network offering id the network is created from
        /// </summary>
        public string NetworkOfferingId { get; set; }

        /// <summary>
        /// name of the network offering the network is created from
        /// </summary>
        public string NetworkOfferingName { get; set; }

        /// <summary>
        /// the physical network id
        /// </summary>
        public string PhysicalNetworkId { get; set; }

        /// <summary>
        /// MTU configured on the network VR's private interfaces
        /// </summary>
        public int? PrivateMtu { get; set; }

        /// <summary>
        /// the project name of the address
        /// </summary>
        public string Project { get; set; }

        /// <summary>
        /// the project id of the ipaddress
        /// </summary>
        public string ProjectId { get; set; }

        /// <summary>
        /// MTU configured on the network VR's public facing interfaces
        /// </summary>
        public int? PublicMtu { get; set; }

        /// <summary>
        /// the total number of network traffic bytes received
        /// </summary>
        public long Receivedbytes { get; set; }

        /// <summary>
        /// If the network has redundant routers enabled
        /// </summary>
        public bool RedundantRouter { get; set; }

        /// <summary>
        /// related to what other network configuration
        /// </summary>
        public string Related { get; set; }

        /// <summary>
        /// the network's IP range not to be used by CloudStack guest VMs and can be used for non CloudStack purposes
        /// </summary>
        public string ReservedIpRange { get; set; }

        /// <summary>
        /// true network requires restart
        /// </summary>
        public bool RestartRequired { get; set; }

        /// <summary>
        /// the total number of network traffic bytes sent
        /// </summary>
        public long Sentbytes { get; set; }

        /// <summary>
        /// true if network supports specifying ip ranges, false otherwise
        /// </summary>
        public bool SpecifyIpRanges { get; set; }

        /// <summary>
        /// state of the network
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// true if network can span multiple zones
        /// </summary>
        public bool StrechedL2Subnet { get; set; }

        /// <summary>
        /// true if users from subdomains can access the domain level network
        /// </summary>
        public bool SubdomainAccess { get; set; }

        /// <summary>
        /// if network offering supports vm autoscaling feature
        /// </summary>
        public bool SupportsVmAutoScaling { get; set; }

        /// <summary>
        /// the traffic type of the network
        /// </summary>
        public string TrafficType { get; set; }

        /// <summary>
        /// Tungsten-Fabric virtual router the network belongs to
        /// </summary>
        public string TungstenVirtualRouterUuid { get; set; }

        /// <summary>
        /// the type of the network
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// The vlan of the network. This parameter is visible to ROOT admins only
        /// </summary>
        public string Vlan { get; set; }

        /// <summary>
        /// VPC the network belongs to
        /// </summary>
        public string VpcId { get; set; }

        /// <summary>
        /// Name of the VPC to which this network belongs
        /// </summary>
        public string VpcName { get; set; }

        /// <summary>
        /// zone id of the network
        /// </summary>
        public string ZoneId { get; set; }

        /// <summary>
        /// the name of the zone the network belongs to
        /// </summary>
        public string ZoneName { get; set; }

        /// <summary>
        /// If a network is enabled for 'streched l2 subnet' then represents zones on which network currently spans
        /// </summary>
        public IList<string> Zonesnetworkspans { get; set; }

        /// <summary>
        /// the list of services
        /// </summary>
        public IList<ServiceResponse> Service { get; set; }

        /// <summary>
        /// the list of resource tags associated with network
        /// </summary>
        public IList<ResourceTagResponse> Tags { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
