using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CertificateResponse
    {
        /// <summary>
        /// The CA certificate(s)
        /// </summary>
        public string Cacertificates { get; set; }

        /// <summary>
        /// The client certificate
        /// </summary>
        public string Certificate { get; set; }

        /// <summary>
        /// Private key for the certificate
        /// </summary>
        public string PrivateKey { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
