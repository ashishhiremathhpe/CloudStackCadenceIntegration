using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DirectDownloadCertificateHostStatusResponse
    {
        /// <summary>
        /// indicates the details in case of failure or host skipped
        /// </summary>
        public string Details { get; set; }

        /// <summary>
        /// the ID of the host
        /// </summary>
        public string HostId { get; set; }

        /// <summary>
        /// the name of the host
        /// </summary>
        public string HostName { get; set; }

        /// <summary>
        /// indicates if the certificate has been revoked from the host, failed or skipped
        /// </summary>
        public string Status { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
