using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class NetworkPermissionsResponse
    {
        /// <summary>
        /// the account the network is available for
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// the ID of account the network is available for
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// the name of the domain to which the network belongs
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// the ID of the domain to which the network belongs
        /// </summary>
        public string DomainId { get; set; }

        /// <summary>
        /// the network ID
        /// </summary>
        public string NetworkId { get; set; }

        /// <summary>
        /// the project the network is available for
        /// </summary>
        public string Project { get; set; }

        /// <summary>
        /// the ID of project the network is available for
        /// </summary>
        public string ProjectId { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
