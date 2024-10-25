using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListElastistorPoolResponse
    {
        /// <summary>
        /// the ID of the storage pool
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// controller of the pool
        /// </summary>
        public string Controllerid { get; set; }

        /// <summary>
        /// default gateway of the pool
        /// </summary>
        public string Gateway { get; set; }

        /// <summary>
        /// available iops of the pool
        /// </summary>
        public long Maxiops { get; set; }

        /// <summary>
        /// the name of the storage pool
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// the current available space of the pool
        /// </summary>
        public long Size { get; set; }

        /// <summary>
        /// the state of the storage pool
        /// </summary>
        public string State { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
