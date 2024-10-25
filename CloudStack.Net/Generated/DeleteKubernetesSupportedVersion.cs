using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteKubernetesSupportedVersionRequest : APIRequest
    {
        public DeleteKubernetesSupportedVersionRequest() : base("deleteKubernetesSupportedVersion") {}

        /// <summary>
        /// the ID of the Kubernetes supported version
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Deletes a Kubernetes cluster
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeleteKubernetesSupportedVersion(DeleteKubernetesSupportedVersionRequest request);
        Task<AsyncJobResponse> DeleteKubernetesSupportedVersionAsync(DeleteKubernetesSupportedVersionRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteKubernetesSupportedVersion(DeleteKubernetesSupportedVersionRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DeleteKubernetesSupportedVersionAsync(DeleteKubernetesSupportedVersionRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
