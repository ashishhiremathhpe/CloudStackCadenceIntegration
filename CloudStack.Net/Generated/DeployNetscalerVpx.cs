using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeployNetscalerVpxRequest : APIRequest
    {
        public DeployNetscalerVpxRequest() : base("deployNetscalerVpx") {}

        /// <summary>
        /// the ID of the service offering for the virtual machine
        /// </summary>
        public Guid ServiceOfferingId {
            get { return GetParameterValue<Guid>(nameof(ServiceOfferingId).ToLower()); }
            set { SetParameterValue(nameof(ServiceOfferingId).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the template for the virtual machine
        /// </summary>
        public Guid TemplateId {
            get { return GetParameterValue<Guid>(nameof(TemplateId).ToLower()); }
            set { SetParameterValue(nameof(TemplateId).ToLower(), value); }
        }

        /// <summary>
        /// availability zone for the virtual machine
        /// </summary>
        public Guid ZoneId {
            get { return GetParameterValue<Guid>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

        /// <summary>
        /// The network this ip address should be associated to.
        /// </summary>
        public Guid? NetworkId {
            get { return GetParameterValue<Guid?>(nameof(NetworkId).ToLower()); }
            set { SetParameterValue(nameof(NetworkId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Creates new NS Vpx
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeployNetscalerVpx(DeployNetscalerVpxRequest request);
        Task<AsyncJobResponse> DeployNetscalerVpxAsync(DeployNetscalerVpxRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeployNetscalerVpx(DeployNetscalerVpxRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DeployNetscalerVpxAsync(DeployNetscalerVpxRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
