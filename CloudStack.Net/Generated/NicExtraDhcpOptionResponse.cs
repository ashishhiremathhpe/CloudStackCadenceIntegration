using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class NicExtraDhcpOptionResponse
    {
        /// <summary>
        /// the ID of the extra dhcp option
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the extra DHCP option code
        /// </summary>
        public int Extradhcpoptioncode { get; set; }

        /// <summary>
        /// the name of the extra DHCP option
        /// </summary>
        public string Extradhcpoptionname { get; set; }

        /// <summary>
        /// the extra DHCP option value
        /// </summary>
        public string Extradhcpvalue { get; set; }

        /// <summary>
        /// the ID of the nic
        /// </summary>
        public string NicId { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
