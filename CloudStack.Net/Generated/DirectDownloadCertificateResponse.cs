using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DirectDownloadCertificateResponse
    {
        /// <summary>
        /// the direct download certificate id
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the direct download certificate alias
        /// </summary>
        public string Alias { get; set; }

        /// <summary>
        /// the hosts where the certificate is uploaded to
        /// </summary>
        public IList<DirectDownloadCertificateHostStatusResponse> HostsMap { get; set; }

        /// <summary>
        /// the hypervisor of the hosts where the certificate is uploaded
        /// </summary>
        public string Hypervisor { get; set; }

        /// <summary>
        /// the direct download certificate issuer
        /// </summary>
        public string Issuer { get; set; }

        /// <summary>
        /// the direct download certificate serial num
        /// </summary>
        public string SerialNum { get; set; }

        /// <summary>
        /// the direct download certificate subject
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// the direct download certificate issuer
        /// </summary>
        public string Validity { get; set; }

        /// <summary>
        /// the direct download certificate version
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// the zone id where the certificate is uploaded
        /// </summary>
        public string ZoneId { get; set; }

        /// <summary>
        /// the zone name where the certificate is uploaded
        /// </summary>
        public string ZoneName { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
