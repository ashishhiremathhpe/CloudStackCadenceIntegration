using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class BackupScheduleResponse
    {
        /// <summary>
        /// the interval type of the backup schedule
        /// </summary>
        public DateUtilIntervalType IntervalType { get; set; }

        /// <summary>
        /// time the backup is scheduled to be taken.
        /// </summary>
        public string Schedule { get; set; }

        /// <summary>
        /// the time zone of the backup schedule
        /// </summary>
        public string Timezone { get; set; }

        /// <summary>
        /// ID of the VM
        /// </summary>
        public string Virtualmachineid { get; set; }

        /// <summary>
        /// name of the VM
        /// </summary>
        public string Virtualmachinename { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
