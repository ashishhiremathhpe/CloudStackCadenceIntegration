using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateKubernetesSupportedVersionRequest : APIRequest
    {
        public UpdateKubernetesSupportedVersionRequest() : base("updateKubernetesSupportedVersion") {}

        /// <summary>
        /// the ID of the Kubernetes supported version
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// the enabled or disabled state of the Kubernetes supported version
        /// </summary>
        public string State {
            get { return GetParameterValue<string>(nameof(State).ToLower()); }
            set { SetParameterValue(nameof(State).ToLower(), value); }
        }

    }
    /// <summary>
    /// Update a supported Kubernetes version
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        KubernetesSupportedVersionResponse UpdateKubernetesSupportedVersion(UpdateKubernetesSupportedVersionRequest request);
        Task<KubernetesSupportedVersionResponse> UpdateKubernetesSupportedVersionAsync(UpdateKubernetesSupportedVersionRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public KubernetesSupportedVersionResponse UpdateKubernetesSupportedVersion(UpdateKubernetesSupportedVersionRequest request) => Proxy.Request<KubernetesSupportedVersionResponse>(request);
        public Task<KubernetesSupportedVersionResponse> UpdateKubernetesSupportedVersionAsync(UpdateKubernetesSupportedVersionRequest request) => Proxy.RequestAsync<KubernetesSupportedVersionResponse>(request);
    }
}
