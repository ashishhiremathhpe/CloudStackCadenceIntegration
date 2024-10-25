using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class SecondaryStorageHeuristicsResponse
    {
        /// <summary>
        /// ID of the heuristic.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// When the heuristic was created.
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// Description of the heuristic.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The heuristic rule, in JavaScript language, used to select a secondary storage to be directed.
        /// </summary>
        public string HeuristicRule { get; set; }

        /// <summary>
        /// Name of the heuristic.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// When the heuristic was removed.
        /// </summary>
        public DateTime Removed { get; set; }

        /// <summary>
        /// The resource type directed to a specific secondary storage by the selector. Valid options are: ISO, SNAPSHOT, TEMPLATE and VOLUME.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// The zone which the heuristic is valid upon.
        /// </summary>
        public string ZoneId { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
