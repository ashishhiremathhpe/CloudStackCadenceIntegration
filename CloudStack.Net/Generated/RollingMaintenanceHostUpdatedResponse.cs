using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class RollingMaintenanceHostUpdatedResponse
    {
        /// <summary>
        /// end date of the update on the host
        /// </summary>
        public string EndDate { get; set; }

        /// <summary>
        /// the ID of the updated host
        /// </summary>
        public string HostId { get; set; }

        /// <summary>
        /// the name of the updated host
        /// </summary>
        public string HostName { get; set; }

        /// <summary>
        /// output of the maintenance script on the host
        /// </summary>
        public string Output { get; set; }

        /// <summary>
        /// start date of the update on the host
        /// </summary>
        public string StartDate { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
