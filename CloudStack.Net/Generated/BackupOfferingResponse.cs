using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class BackupOfferingResponse
    {
        /// <summary>
        /// ID of the backup offering
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// whether offering allows user driven ad-hoc/scheduled backups
        /// </summary>
        public bool Allowuserdrivenbackups { get; set; }

        /// <summary>
        /// the date this backup offering was created
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// description for the backup offering
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// external ID on the provider side
        /// </summary>
        public string ExternalId { get; set; }

        /// <summary>
        /// name for the backup offering
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// zone ID
        /// </summary>
        public string ZoneId { get; set; }

        /// <summary>
        /// zone name
        /// </summary>
        public string ZoneName { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
