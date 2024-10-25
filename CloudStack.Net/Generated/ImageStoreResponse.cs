using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ImageStoreResponse
    {
        /// <summary>
        /// the ID of the image store
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the total disk size of the host
        /// </summary>
        public long DiskSizeTotal { get; set; }

        /// <summary>
        /// the host's currently used disk size
        /// </summary>
        public long DiskSizeUsed { get; set; }

        /// <summary>
        /// the name of the image store
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// the protocol of the image store
        /// </summary>
        public string Protocol { get; set; }

        /// <summary>
        /// the provider name of the image store
        /// </summary>
        public string ProviderName { get; set; }

        /// <summary>
        /// defines if store is read-only
        /// </summary>
        public bool Readonly { get; set; }

        /// <summary>
        /// the scope of the image store
        /// </summary>
        public ScopeType Scope { get; set; }

        /// <summary>
        /// the url of the image store
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// the Zone ID of the image store
        /// </summary>
        public string ZoneId { get; set; }

        /// <summary>
        /// the Zone name of the image store
        /// </summary>
        public string ZoneName { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
