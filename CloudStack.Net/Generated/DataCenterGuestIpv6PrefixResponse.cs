using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DataCenterGuestIpv6PrefixResponse
    {
        /// <summary>
        /// id of the guest IPv6 prefix
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// count of the available IPv6 subnets for the prefix.
        /// </summary>
        public int? AvailableSubnets { get; set; }

        /// <summary>
        ///  date when this IPv6 prefix was created.
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// guest IPv6 prefix
        /// </summary>
        public string Prefix { get; set; }

        /// <summary>
        /// count of the total IPv6 subnets for the prefix.
        /// </summary>
        public int? TotalSubnets { get; set; }

        /// <summary>
        /// count of the used IPv6 subnets for the prefix.
        /// </summary>
        public int? UsedSubnets { get; set; }

        /// <summary>
        /// id of zone to which the IPv6 prefix belongs to.
        /// </summary>
        public string ZoneId { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
