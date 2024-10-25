using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UnmanageVMInstanceResponse
    {
        /// <summary>
        /// details of the unmanage VM operation
        /// </summary>
        public string Details { get; set; }

        /// <summary>
        /// result of the unmanage VM operation
        /// </summary>
        public bool Success { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
