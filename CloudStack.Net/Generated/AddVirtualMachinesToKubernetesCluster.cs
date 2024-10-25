using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AddVirtualMachinesToKubernetesClusterRequest : APIRequest
    {
        public AddVirtualMachinesToKubernetesClusterRequest() : base("addVirtualMachinesToKubernetesCluster") {}

        /// <summary>
        /// the ID of the Kubernetes cluster
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// the IDs of the VMs to add to the cluster
        /// </summary>
        public IList<Guid> Virtualmachineids {
            get { return GetList<Guid>(nameof(Virtualmachineids).ToLower()); }
            set { SetParameterValue(nameof(Virtualmachineids).ToLower(), value); }
        }

        /// <summary>
        /// Is control node or not? Defaults to false.
        /// </summary>
        public bool? IsControlNode {
            get { return GetParameterValue<bool?>(nameof(IsControlNode).ToLower()); }
            set { SetParameterValue(nameof(IsControlNode).ToLower(), value); }
        }

    }
    /// <summary>
    /// Add VMs to an ExternalManaged kubernetes cluster. Not applicable for CloudManaged kubernetes clusters.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse AddVirtualMachinesToKubernetesCluster(AddVirtualMachinesToKubernetesClusterRequest request);
        Task<SuccessResponse> AddVirtualMachinesToKubernetesClusterAsync(AddVirtualMachinesToKubernetesClusterRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse AddVirtualMachinesToKubernetesCluster(AddVirtualMachinesToKubernetesClusterRequest request) => Proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> AddVirtualMachinesToKubernetesClusterAsync(AddVirtualMachinesToKubernetesClusterRequest request) => Proxy.RequestAsync<SuccessResponse>(request);
    }
}
