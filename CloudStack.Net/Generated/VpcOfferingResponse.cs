using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class VpcOfferingResponse
    {
        /// <summary>
        /// the id of the vpc offering
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the date this vpc offering was created
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// an alternate display text of the vpc offering.
        /// </summary>
        public string DisplayText { get; set; }

        /// <summary>
        ///  indicates if the vpc offering supports distributed router for one-hop forwarding
        /// </summary>
        public bool Distributedvpcrouter { get; set; }

        /// <summary>
        /// the domain name(s) this disk offering belongs to. Ignore this information as it is not currently applicable.
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// the domain ID(s) this disk offering belongs to. Ignore this information as it is not currently applicable.
        /// </summary>
        public string DomainId { get; set; }

        /// <summary>
        /// the internet protocol of the vpc offering
        /// </summary>
        public string InternetProtocol { get; set; }

        /// <summary>
        /// true if vpc offering is default, false otherwise
        /// </summary>
        public bool IsDefault { get; set; }

        /// <summary>
        /// the name of the vpc offering
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// state of the vpc offering. Can be Disabled/Enabled
        /// </summary>
        public string State { get; set; }

        /// <summary>
        ///  indicated if the offering can support region level vpc
        /// </summary>
        public bool SupportsRegionLevelVpc { get; set; }

        /// <summary>
        /// the zone name(s) this disk offering belongs to. Ignore this information as it is not currently applicable.
        /// </summary>
        public string Zone { get; set; }

        /// <summary>
        /// the zone ID(s) this disk offering belongs to. Ignore this information as it is not currently applicable.
        /// </summary>
        public string ZoneId { get; set; }

        /// <summary>
        /// the list of supported services
        /// </summary>
        public IList<ServiceResponse> Service { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
