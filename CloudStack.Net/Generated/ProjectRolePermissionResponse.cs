using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ProjectRolePermissionResponse
    {
        /// <summary>
        /// the ID of the project role permission
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the ID of the project
        /// </summary>
        public string ProjectId { get; set; }

        /// <summary>
        /// the ID of the project role to which the role permission belongs
        /// </summary>
        public string ProjectRoleId { get; set; }

        /// <summary>
        /// the name of the project role to which the role permission belongs
        /// </summary>
        public string ProjectRoleName { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
