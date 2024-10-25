using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AlertResponse
    {
        /// <summary>
        /// the id of the alert
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// description of the alert
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// the name of the alert
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// the date and time the alert was sent
        /// </summary>
        public DateTime Sent { get; set; }

        /// <summary>
        /// One of the following alert types: MEMORY = 0, CPU = 1, STORAGE = 2, STORAGE_ALLOCATED = 3, PUBLIC_IP = 4, PRIVATE_IP = 5, SECONDARY_STORAGE = 6, HOST = 7, USERVM = 8, DOMAIN_ROUTER = 9, CONSOLE_PROXY = 10, ROUTING = 11: lost connection to default route (to the gateway), STORAGE_MISC = 12, USAGE_SERVER = 13, MANAGMENT_NODE = 14, DOMAIN_ROUTER_MIGRATE = 15, CONSOLE_PROXY_MIGRATE = 16, USERVM_MIGRATE = 17, VLAN = 18, SSVM = 19, USAGE_SERVER_RESULT = 20, STORAGE_DELETE = 21, UPDATE_RESOURCE_COUNT = 22, USAGE_SANITY_RESULT = 23, DIRECT_ATTACHED_PUBLIC_IP = 24, LOCAL_STORAGE = 25, RESOURCE_LIMIT_EXCEEDED = 26, SYNC = 27, UPLOAD_FAILED = 28, OOBM_AUTH_ERROR = 29
        /// </summary>
        public short Type { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
