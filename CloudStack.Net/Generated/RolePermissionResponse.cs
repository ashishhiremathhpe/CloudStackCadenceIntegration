using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class RolePermissionResponse
    {
        /// <summary>
        /// the ID of the role permission
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the ID of the role to which the role permission belongs
        /// </summary>
        public string RoleId { get; set; }

        /// <summary>
        /// the name of the role to which the role permission belongs
        /// </summary>
        public string RoleName { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
