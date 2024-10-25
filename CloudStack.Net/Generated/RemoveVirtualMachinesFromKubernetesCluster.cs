using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class RemoveVirtualMachinesFromKubernetesClusterRequest : APIListRequest
    {
        public RemoveVirtualMachinesFromKubernetesClusterRequest() : base("removeVirtualMachinesFromKubernetesCluster") {}

        /// <summary>
        /// the ID of the Kubernetes cluster
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// the IDs of the VMs to remove from the cluster
        /// </summary>
        public IList<Guid> Virtualmachineids {
            get { return GetList<Guid>(nameof(Virtualmachineids).ToLower()); }
            set { SetParameterValue(nameof(Virtualmachineids).ToLower(), value); }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

    }
    /// <summary>
    /// Remove VMs from an ExternalManaged kubernetes cluster. Not applicable for CloudManaged kubernetes clusters.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<RemoveVirtualMachinesFromKubernetesClusterResponse> RemoveVirtualMachinesFromKubernetesCluster(RemoveVirtualMachinesFromKubernetesClusterRequest request);
        Task<ListResponse<RemoveVirtualMachinesFromKubernetesClusterResponse>> RemoveVirtualMachinesFromKubernetesClusterAsync(RemoveVirtualMachinesFromKubernetesClusterRequest request);
        ListResponse<RemoveVirtualMachinesFromKubernetesClusterResponse> RemoveVirtualMachinesFromKubernetesClusterAllPages(RemoveVirtualMachinesFromKubernetesClusterRequest request);
        Task<ListResponse<RemoveVirtualMachinesFromKubernetesClusterResponse>> RemoveVirtualMachinesFromKubernetesClusterAllPagesAsync(RemoveVirtualMachinesFromKubernetesClusterRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<RemoveVirtualMachinesFromKubernetesClusterResponse> RemoveVirtualMachinesFromKubernetesCluster(RemoveVirtualMachinesFromKubernetesClusterRequest request) => Proxy.Request<ListResponse<RemoveVirtualMachinesFromKubernetesClusterResponse>>(request);
        public Task<ListResponse<RemoveVirtualMachinesFromKubernetesClusterResponse>> RemoveVirtualMachinesFromKubernetesClusterAsync(RemoveVirtualMachinesFromKubernetesClusterRequest request) => Proxy.RequestAsync<ListResponse<RemoveVirtualMachinesFromKubernetesClusterResponse>>(request);
        public ListResponse<RemoveVirtualMachinesFromKubernetesClusterResponse> RemoveVirtualMachinesFromKubernetesClusterAllPages(RemoveVirtualMachinesFromKubernetesClusterRequest request) => Proxy.RequestAllPages<RemoveVirtualMachinesFromKubernetesClusterResponse>(request);
        public Task<ListResponse<RemoveVirtualMachinesFromKubernetesClusterResponse>> RemoveVirtualMachinesFromKubernetesClusterAllPagesAsync(RemoveVirtualMachinesFromKubernetesClusterRequest request) => Proxy.RequestAllPagesAsync<RemoveVirtualMachinesFromKubernetesClusterResponse>(request);
    }
}
