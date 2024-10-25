using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class BackupResponse
    {
        /// <summary>
        /// ID of the VM backup
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// account name
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// account id
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// backup offering id
        /// </summary>
        public string BackupOfferingId { get; set; }

        /// <summary>
        /// backup offering name
        /// </summary>
        public string BackupOfferingName { get; set; }

        /// <summary>
        /// backup date
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// domain name
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// domain id
        /// </summary>
        public string DomainId { get; set; }

        /// <summary>
        /// external backup id
        /// </summary>
        public string ExternalId { get; set; }

        /// <summary>
        /// backup size in bytes
        /// </summary>
        public long Size { get; set; }

        /// <summary>
        /// backup status
        /// </summary>
        public Status Status { get; set; }

        /// <summary>
        /// backup type
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// ID of the VM
        /// </summary>
        public string Virtualmachineid { get; set; }

        /// <summary>
        /// name of the VM
        /// </summary>
        public string Virtualmachinename { get; set; }

        /// <summary>
        /// backup protected (virtual) size in bytes
        /// </summary>
        public long Virtualsize { get; set; }

        /// <summary>
        /// backed up volumes
        /// </summary>
        public string Volumes { get; set; }

        /// <summary>
        /// zone name
        /// </summary>
        public string Zone { get; set; }

        /// <summary>
        /// zone id
        /// </summary>
        public string ZoneId { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
