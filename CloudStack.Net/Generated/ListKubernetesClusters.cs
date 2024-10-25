using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListKubernetesClustersRequest : APIListRequest
    {
        public ListKubernetesClustersRequest() : base("listKubernetesClusters") {}

        /// <summary>
        /// list resources by account. Must be used with the domainId parameter.
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// type of the cluster: CloudManaged, ExternalManaged
        /// </summary>
        public string ClusterType {
            get { return GetParameterValue<string>(nameof(ClusterType).ToLower()); }
            set { SetParameterValue(nameof(ClusterType).ToLower(), value); }
        }

        /// <summary>
        /// list only resources belonging to the domain specified
        /// </summary>
        public Guid? DomainId {
            get { return GetParameterValue<Guid?>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the Kubernetes cluster
        /// </summary>
        public Guid? Id {
            get { return GetParameterValue<Guid?>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// defaults to false, but if true, lists all resources from the parent specified by the domainId till leaves.
        /// </summary>
        public bool? Isrecursive {
            get { return GetParameterValue<bool?>(nameof(Isrecursive).ToLower()); }
            set { SetParameterValue(nameof(Isrecursive).ToLower(), value); }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// If set to false, list only resources belonging to the command's caller; if set to true - list resources that the caller is authorized to see. Default value is false. Resources dedicated to a project are listed only if using the projectid parameter.
        /// </summary>
        public bool? ListAll {
            get { return GetParameterValue<bool?>(nameof(ListAll).ToLower()); }
            set { SetParameterValue(nameof(ListAll).ToLower(), value); }
        }

        /// <summary>
        /// name of the Kubernetes cluster (a substring match is made against the parameter value, data for all matching Kubernetes clusters will be returned)
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// list objects by project; if projectid=-1 lists All VMs
        /// </summary>
        public Guid? ProjectId {
            get { return GetParameterValue<Guid?>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
        }

        /// <summary>
        /// state of the Kubernetes cluster
        /// </summary>
        public string State {
            get { return GetParameterValue<string>(nameof(State).ToLower()); }
            set { SetParameterValue(nameof(State).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists Kubernetes clusters
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<KubernetesClusterResponse> ListKubernetesClusters(ListKubernetesClustersRequest request);
        Task<ListResponse<KubernetesClusterResponse>> ListKubernetesClustersAsync(ListKubernetesClustersRequest request);
        ListResponse<KubernetesClusterResponse> ListKubernetesClustersAllPages(ListKubernetesClustersRequest request);
        Task<ListResponse<KubernetesClusterResponse>> ListKubernetesClustersAllPagesAsync(ListKubernetesClustersRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<KubernetesClusterResponse> ListKubernetesClusters(ListKubernetesClustersRequest request) => Proxy.Request<ListResponse<KubernetesClusterResponse>>(request);
        public Task<ListResponse<KubernetesClusterResponse>> ListKubernetesClustersAsync(ListKubernetesClustersRequest request) => Proxy.RequestAsync<ListResponse<KubernetesClusterResponse>>(request);
        public ListResponse<KubernetesClusterResponse> ListKubernetesClustersAllPages(ListKubernetesClustersRequest request) => Proxy.RequestAllPages<KubernetesClusterResponse>(request);
        public Task<ListResponse<KubernetesClusterResponse>> ListKubernetesClustersAllPagesAsync(ListKubernetesClustersRequest request) => Proxy.RequestAllPagesAsync<KubernetesClusterResponse>(request);
    }
}
