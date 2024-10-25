using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListKubernetesSupportedVersionsRequest : APIListRequest
    {
        public ListKubernetesSupportedVersionsRequest() : base("listKubernetesSupportedVersions") {}

        /// <summary>
        /// the ID of the Kubernetes supported version
        /// </summary>
        public Guid? Id {
            get { return GetParameterValue<Guid?>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the minimum Kubernetes supported version
        /// </summary>
        public Guid? MinimumKubernetesVersionId {
            get { return GetParameterValue<Guid?>(nameof(MinimumKubernetesVersionId).ToLower()); }
            set { SetParameterValue(nameof(MinimumKubernetesVersionId).ToLower(), value); }
        }

        /// <summary>
        /// the minimum semantic version for the Kubernetes supported version to be listed
        /// </summary>
        public string MinimumSemanticVersion {
            get { return GetParameterValue<string>(nameof(MinimumSemanticVersion).ToLower()); }
            set { SetParameterValue(nameof(MinimumSemanticVersion).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the zone in which Kubernetes supported version will be available
        /// </summary>
        public Guid? ZoneId {
            get { return GetParameterValue<Guid?>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists supported Kubernetes version
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<KubernetesSupportedVersionResponse> ListKubernetesSupportedVersions(ListKubernetesSupportedVersionsRequest request);
        Task<ListResponse<KubernetesSupportedVersionResponse>> ListKubernetesSupportedVersionsAsync(ListKubernetesSupportedVersionsRequest request);
        ListResponse<KubernetesSupportedVersionResponse> ListKubernetesSupportedVersionsAllPages(ListKubernetesSupportedVersionsRequest request);
        Task<ListResponse<KubernetesSupportedVersionResponse>> ListKubernetesSupportedVersionsAllPagesAsync(ListKubernetesSupportedVersionsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<KubernetesSupportedVersionResponse> ListKubernetesSupportedVersions(ListKubernetesSupportedVersionsRequest request) => Proxy.Request<ListResponse<KubernetesSupportedVersionResponse>>(request);
        public Task<ListResponse<KubernetesSupportedVersionResponse>> ListKubernetesSupportedVersionsAsync(ListKubernetesSupportedVersionsRequest request) => Proxy.RequestAsync<ListResponse<KubernetesSupportedVersionResponse>>(request);
        public ListResponse<KubernetesSupportedVersionResponse> ListKubernetesSupportedVersionsAllPages(ListKubernetesSupportedVersionsRequest request) => Proxy.RequestAllPages<KubernetesSupportedVersionResponse>(request);
        public Task<ListResponse<KubernetesSupportedVersionResponse>> ListKubernetesSupportedVersionsAllPagesAsync(ListKubernetesSupportedVersionsRequest request) => Proxy.RequestAllPagesAsync<KubernetesSupportedVersionResponse>(request);
    }
}
