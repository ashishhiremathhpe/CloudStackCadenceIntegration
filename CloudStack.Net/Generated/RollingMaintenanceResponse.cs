using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class RollingMaintenanceResponse
    {
        /// <summary>
        /// in case of failure, details are displayed
        /// </summary>
        public string Details { get; set; }

        /// <summary>
        /// indicates if the rolling maintenance operation was successful
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// the hosts skipped
        /// </summary>
        public IList<RollingMaintenanceHostSkippedResponse> Hostsskipped { get; set; }

        /// <summary>
        /// the hosts updated
        /// </summary>
        public IList<RollingMaintenanceHostUpdatedResponse> Hostsupdated { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
