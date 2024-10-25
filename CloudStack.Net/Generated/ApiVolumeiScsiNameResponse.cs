using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ApiVolumeiScsiNameResponse
    {
        /// <summary>
        /// Volume iSCSI Name
        /// </summary>
        public string VolumeiScsiName { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
