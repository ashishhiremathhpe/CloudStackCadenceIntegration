using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UserDataResponse
    {
        /// <summary>
        /// ID of the ssh keypair
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the owner of the userdata
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// the owner id of the userdata
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// the domain name of the userdata owner
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// the domain id of the userdata owner
        /// </summary>
        public string DomainId { get; set; }

        /// <summary>
        /// Name of the userdata
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// list of parameters which contains the list of keys or string parameters that are needed to be passed for any variables declared in userdata
        /// </summary>
        public string Params { get; set; }

        /// <summary>
        /// base64 encoded userdata content
        /// </summary>
        public string UserData { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
