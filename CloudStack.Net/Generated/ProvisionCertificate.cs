using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ProvisionCertificateRequest : APIRequest
    {
        public ProvisionCertificateRequest() : base("provisionCertificate") {}

        /// <summary>
        /// The host/agent uuid to which the certificate has to be provisioned (issued and propagated)
        /// </summary>
        public Guid HostId {
            get { return GetParameterValue<Guid>(nameof(HostId).ToLower()); }
            set { SetParameterValue(nameof(HostId).ToLower(), value); }
        }

        /// <summary>
        /// Name of the CA service provider, otherwise the default configured provider plugin will be used
        /// </summary>
        public string Provider {
            get { return GetParameterValue<string>(nameof(Provider).ToLower()); }
            set { SetParameterValue(nameof(Provider).ToLower(), value); }
        }

        /// <summary>
        /// Whether to attempt reconnection with host/agent after successful deployment of certificate. When option is not provided, configured global setting is used
        /// </summary>
        public bool? Reconnect {
            get { return GetParameterValue<bool?>(nameof(Reconnect).ToLower()); }
            set { SetParameterValue(nameof(Reconnect).ToLower(), value); }
        }

    }
    /// <summary>
    /// Issues and propagates client certificate on a connected host/agent using configured CA plugin
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse ProvisionCertificate(ProvisionCertificateRequest request);
        Task<AsyncJobResponse> ProvisionCertificateAsync(ProvisionCertificateRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse ProvisionCertificate(ProvisionCertificateRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> ProvisionCertificateAsync(ProvisionCertificateRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
