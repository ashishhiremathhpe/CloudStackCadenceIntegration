using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ObjectStoreResponse
    {
        /// <summary>
        /// the ID of the object store
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the name of the object store
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// the provider name of the object store
        /// </summary>
        public string ProviderName { get; set; }

        /// <summary>
        /// the total size of the object store
        /// </summary>
        public long StorageTotal { get; set; }

        /// <summary>
        /// the object store currently used size
        /// </summary>
        public long StorageUsed { get; set; }

        /// <summary>
        /// the url of the object store
        /// </summary>
        public string Url { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
