using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class VpcResponse
    {
        /// <summary>
        /// the id of the VPC
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the owner of the VPC
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// the cidr the VPC
        /// </summary>
        public string Cidr { get; set; }

        /// <summary>
        /// the date this VPC was created
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// an alternate display text of the VPC.
        /// </summary>
        public string DisplayText { get; set; }

        /// <summary>
        /// is VPC uses distributed router for one hop forwarding and host based network ACL's
        /// </summary>
        public bool Distributedvpcrouter { get; set; }

        /// <summary>
        /// the first IPv4 DNS for the VPC
        /// </summary>
        public string Dns1 { get; set; }

        /// <summary>
        /// the second IPv4 DNS for the VPC
        /// </summary>
        public string Dns2 { get; set; }

        /// <summary>
        /// the domain name of the owner
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// the domain id of the VPC owner
        /// </summary>
        public string DomainId { get; set; }

        /// <summary>
        /// is vpc for display to the regular user
        /// </summary>
        public bool ForDisplay { get; set; }

        /// <summary>
        /// Base64 string representation of the resource icon
        /// </summary>
        public ResourceIconResponse Icon { get; set; }

        /// <summary>
        /// the first IPv6 DNS for the VPC
        /// </summary>
        public string Ip6dns1 { get; set; }

        /// <summary>
        /// the second IPv6 DNS for the VPC
        /// </summary>
        public string Ip6dns2 { get; set; }

        /// <summary>
        /// The routes for the network to ease adding route in upstream router
        /// </summary>
        public IList<Ipv6RouteResponse> Ip6routes { get; set; }

        /// <summary>
        /// the name of the VPC
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// the list of networks belongign to the VPC
        /// </summary>
        public IList<NetworkResponse> Network { get; set; }

        /// <summary>
        /// the network domain of the VPC
        /// </summary>
        public string NetworkDomain { get; set; }

        /// <summary>
        /// the project name of the VPC
        /// </summary>
        public string Project { get; set; }

        /// <summary>
        /// the project id of the VPC
        /// </summary>
        public string ProjectId { get; set; }

        /// <summary>
        /// MTU configured on the public interfaces of the VPC VR
        /// </summary>
        public int? PublicMtu { get; set; }

        /// <summary>
        /// if this VPC has redundant router
        /// </summary>
        public bool Redundantvpcrouter { get; set; }

        /// <summary>
        /// true if VPC is region level
        /// </summary>
        public bool RegionLevelVpc { get; set; }

        /// <summary>
        /// true VPC requires restart
        /// </summary>
        public bool RestartRequired { get; set; }

        /// <summary>
        /// state of the VPC. Can be Inactive/Enabled
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// vpc offering id the VPC is created from
        /// </summary>
        public string VpcOfferingId { get; set; }

        /// <summary>
        /// vpc offering name the VPC is created from
        /// </summary>
        public string VpcOfferingName { get; set; }

        /// <summary>
        /// zone id of the vpc
        /// </summary>
        public string ZoneId { get; set; }

        /// <summary>
        /// the name of the zone the VPC belongs to
        /// </summary>
        public string ZoneName { get; set; }

        /// <summary>
        /// the list of supported services
        /// </summary>
        public IList<ServiceResponse> Service { get; set; }

        /// <summary>
        /// the list of resource tags associated with the project
        /// </summary>
        public IList<ResourceTagResponse> Tags { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
