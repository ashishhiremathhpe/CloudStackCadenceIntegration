using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListElastistorVolumeResponse
    {
        /// <summary>
        /// the id of the volume
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// compression
        /// </summary>
        public string Compression { get; set; }

        /// <summary>
        /// deduplication
        /// </summary>
        public string Deduplication { get; set; }

        /// <summary>
        /// graceallowed
        /// </summary>
        public string GraceAllowed { get; set; }

        /// <summary>
        /// the name of the volume
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// synchronization
        /// </summary>
        public string Sync { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
