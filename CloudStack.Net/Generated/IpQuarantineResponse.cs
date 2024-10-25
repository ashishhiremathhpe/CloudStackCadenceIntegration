using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class IpQuarantineResponse
    {
        /// <summary>
        /// ID of the quarantine process.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// When the quarantine was created.
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// End date for the quarantine.
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// The public IP address in quarantine.
        /// </summary>
        public string Ipaddress { get; set; }

        /// <summary>
        /// Account ID of the previous public IP address owner.
        /// </summary>
        public string PreviousOwnerId { get; set; }

        /// <summary>
        /// Account name of the previous public IP address owner.
        /// </summary>
        public string PreviousOwnerName { get; set; }

        /// <summary>
        /// The reason for removing the IP from quarantine prematurely.
        /// </summary>
        public string RemovalReason { get; set; }

        /// <summary>
        /// When the quarantine was removed.
        /// </summary>
        public DateTime Removed { get; set; }

        /// <summary>
        /// ID of the account that removed the IP from quarantine.
        /// </summary>
        public string RemoverAccountId { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
