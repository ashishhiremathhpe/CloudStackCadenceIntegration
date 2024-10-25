using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class VMScheduleResponse
    {
        /// <summary>
        /// the ID of VM schedule
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Action
        /// </summary>
        public Action Action { get; set; }

        /// <summary>
        /// Date when the schedule was created
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// Description of VM schedule
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// VM schedule is enabled
        /// </summary>
        public bool Enabled { get; set; }

        /// <summary>
        /// Date after which the schedule becomes inactive
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Cron formatted VM schedule
        /// </summary>
        public string Schedule { get; set; }

        /// <summary>
        /// Date from which the schedule is active
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Timezone of the schedule
        /// </summary>
        public string TimeZone { get; set; }

        /// <summary>
        /// ID of virtual machine
        /// </summary>
        public string Virtualmachineid { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
