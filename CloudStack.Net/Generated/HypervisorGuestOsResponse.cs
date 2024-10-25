using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class HypervisorGuestOsResponse
    {
        /// <summary>
        /// standard display name for the Guest OS
        /// </summary>
        public string Osdisplayname { get; set; }

        /// <summary>
        /// hypervisor specific name for the Guest OS
        /// </summary>
        public string OsNameForHypervisor { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
