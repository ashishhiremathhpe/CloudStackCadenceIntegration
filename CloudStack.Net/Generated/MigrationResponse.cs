using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class MigrationResponse
    {
        /// <summary>
        /// Response message from migration of secondary storage data objects
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Type of migration requested for
        /// </summary>
        public string MigrationType { get; set; }

        /// <summary>
        /// true if operation is executed successfully
        /// </summary>
        public bool Success { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
