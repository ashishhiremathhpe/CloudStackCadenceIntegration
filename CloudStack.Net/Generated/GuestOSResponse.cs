using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class GuestOSResponse
    {
        /// <summary>
        /// the ID of the OS type
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the name/description of the OS type
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// is the guest OS visible for the users
        /// </summary>
        public bool ForDisplay { get; set; }

        /// <summary>
        /// is the guest OS user defined
        /// </summary>
        public bool IsUserDefined { get; set; }

        /// <summary>
        /// the name of the OS type
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// the ID of the OS category
        /// </summary>
        public string OsCategoryId { get; set; }

        /// <summary>
        /// the name of the OS category
        /// </summary>
        public string OsCategoryName { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
