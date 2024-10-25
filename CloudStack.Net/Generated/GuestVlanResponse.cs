using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class GuestVlanResponse
    {
        /// <summary>
        /// the guest VLAN id
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// the account of the guest VLAN range
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// the allocation state of the guest VLAN
        /// </summary>
        public string AllocationState { get; set; }

        /// <summary>
        /// the domain name of the guest VLAN range
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// the domain ID of the guest VLAN range
        /// </summary>
        public string DomainId { get; set; }

        /// <summary>
        /// true if the guest VLAN is dedicated to the account
        /// </summary>
        public bool IsDedicated { get; set; }

        /// <summary>
        /// the list of networks who use this guest VLAN
        /// </summary>
        public IList<NetworkResponse> Network { get; set; }

        /// <summary>
        /// the physical network ID of the guest VLAN range
        /// </summary>
        public string PhysicalNetworkId { get; set; }

        /// <summary>
        /// the physical network name of the guest VLAN range
        /// </summary>
        public string PhysicalNetworkName { get; set; }

        /// <summary>
        /// the project name of the guest VLAN range
        /// </summary>
        public string Project { get; set; }

        /// <summary>
        /// the project id of the guest VLAN range
        /// </summary>
        public string ProjectId { get; set; }

        /// <summary>
        /// date the guest VLAN was taken
        /// </summary>
        public DateTime Taken { get; set; }

        /// <summary>
        /// the guest VLAN
        /// </summary>
        public string Vlan { get; set; }

        /// <summary>
        /// the zone ID of the guest VLAN range
        /// </summary>
        public string ZoneId { get; set; }

        /// <summary>
        /// the zone name of the guest VLAN range
        /// </summary>
        public string ZoneName { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
