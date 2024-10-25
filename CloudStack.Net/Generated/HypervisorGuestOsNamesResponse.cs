using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class HypervisorGuestOsNamesResponse
    {
        /// <summary>
        /// the guest OS count of the hypervisor
        /// </summary>
        public int? GuestOSCount { get; set; }

        /// <summary>
        /// the hypervisor
        /// </summary>
        public string Hypervisor { get; set; }

        /// <summary>
        /// version of the hypervisor for guest os names
        /// </summary>
        public string HypervisorVersion { get; set; }

        /// <summary>
        /// the guest OS list of the hypervisor
        /// </summary>
        public IList<HypervisorGuestOsResponse> GuestOSList { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
