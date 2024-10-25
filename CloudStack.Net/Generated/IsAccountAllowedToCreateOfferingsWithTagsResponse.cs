using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class IsAccountAllowedToCreateOfferingsWithTagsResponse
    {
        /// <summary>
        /// is domain admin allowed to create offerings with tags
        /// </summary>
        public bool IsAllowed { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
