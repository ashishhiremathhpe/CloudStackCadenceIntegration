using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class NicResponse
    {
        /// <summary>
        /// the ID of the nic
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Type of adapter if available
        /// </summary>
        public string AdapterType { get; set; }

        /// <summary>
        /// the broadcast uri of the nic
        /// </summary>
        public string BroadcastUri { get; set; }

        /// <summary>
        /// device id for the network when plugged into the virtual machine
        /// </summary>
        public string DeviceId { get; set; }

        /// <summary>
        /// the extra dhcp options on the nic
        /// </summary>
        public IList<NicExtraDhcpOptionResponse> Extradhcpoption { get; set; }

        /// <summary>
        /// the gateway of the nic
        /// </summary>
        public string Gateway { get; set; }

        /// <summary>
        /// the IPv6 address of network
        /// </summary>
        public string Ip6Address { get; set; }

        /// <summary>
        /// the cidr of IPv6 network
        /// </summary>
        public string Ip6Cidr { get; set; }

        /// <summary>
        /// the gateway of IPv6 network
        /// </summary>
        public string Ip6Gateway { get; set; }

        /// <summary>
        /// the ip address of the nic
        /// </summary>
        public string Ipaddress { get; set; }

        /// <summary>
        /// IP addresses associated with NIC found for unmanaged VM
        /// </summary>
        public IList<string> IpAddresses { get; set; }

        /// <summary>
        /// true if nic is default, false otherwise
        /// </summary>
        public bool IsDefault { get; set; }

        /// <summary>
        /// the isolated private VLAN if available
        /// </summary>
        public int? Isolatedpvlan { get; set; }

        /// <summary>
        /// the isolated private VLAN type if available
        /// </summary>
        public string IsolatedPvlanType { get; set; }

        /// <summary>
        /// the isolation uri of the nic
        /// </summary>
        public string IsolationUri { get; set; }

        /// <summary>
        /// true if nic is default, false otherwise
        /// </summary>
        public string MacAddress { get; set; }

        /// <summary>
        /// MTU configured on the NIC
        /// </summary>
        public int? Mtu { get; set; }

        /// <summary>
        /// the netmask of the nic
        /// </summary>
        public string Netmask { get; set; }

        /// <summary>
        /// the ID of the corresponding network
        /// </summary>
        public string NetworkId { get; set; }

        /// <summary>
        /// the name of the corresponding network
        /// </summary>
        public string NetworkName { get; set; }

        /// <summary>
        /// Id of the NSX Logical Switch (if NSX based), null otherwise
        /// </summary>
        public string NsxLogicalSwitch { get; set; }

        /// <summary>
        /// Id of the NSX Logical Switch Port (if NSX based), null otherwise
        /// </summary>
        public string NsxLogicalSwitchPort { get; set; }

        /// <summary>
        /// public IP address associated with this nic via Static nat rule
        /// </summary>
        public string PublicIp { get; set; }

        /// <summary>
        /// public IP address id associated with this nic via Static nat rule
        /// </summary>
        public string PublicIpId { get; set; }

        /// <summary>
        /// the Secondary ipv4 addr of nic
        /// </summary>
        public IList<NicSecondaryIpResponse> Secondaryip { get; set; }

        /// <summary>
        /// the traffic type of the nic
        /// </summary>
        public string TrafficType { get; set; }

        /// <summary>
        /// the type of the nic
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Id of the vm to which the nic belongs
        /// </summary>
        public string Virtualmachineid { get; set; }

        /// <summary>
        /// ID of the VLAN/VNI if available
        /// </summary>
        public int? VlanId { get; set; }

        /// <summary>
        /// Id of the vpc to which the nic belongs
        /// </summary>
        public string VpcId { get; set; }

        /// <summary>
        /// name of the vpc to which the nic belongs
        /// </summary>
        public string VpcName { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
