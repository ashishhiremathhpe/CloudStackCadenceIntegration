using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class QuotaTariffResponse
    {
        /// <summary>
        /// activation rule of the quota tariff
        /// </summary>
        public string ActivationRule { get; set; }

        /// <summary>
        /// currency
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// the start date of the quota tariff
        /// </summary>
        public DateTime EffectiveDate { get; set; }

        /// <summary>
        /// the end date of the quota tariff
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// when the quota tariff was removed
        /// </summary>
        public DateTime Removed { get; set; }

        /// <summary>
        /// tariffValue
        /// </summary>
        public decimal TariffValue { get; set; }

        /// <summary>
        /// usageDiscriminator
        /// </summary>
        public string UsageDiscriminator { get; set; }

        /// <summary>
        /// usageName
        /// </summary>
        public string UsageName { get; set; }

        /// <summary>
        /// usageType
        /// </summary>
        public int UsageType { get; set; }

        /// <summary>
        /// usage type description
        /// </summary>
        public string UsageTypeDescription { get; set; }

        /// <summary>
        /// usageUnit
        /// </summary>
        public string UsageUnit { get; set; }

        /// <summary>
        /// uuid
        /// </summary>
        public string Uuid { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
