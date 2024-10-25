using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateHypervisorCapabilitiesRequest : APIRequest
    {
        public UpdateHypervisorCapabilitiesRequest() : base("updateHypervisorCapabilities") {}

        /// <summary>
        /// ID of the hypervisor capability
        /// </summary>
        public Guid? Id {
            get { return GetParameterValue<Guid?>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// the maximum number of Data Volumes that can be attached to a VM for this hypervisor.
        /// </summary>
        public int? MaxDataVolumesLimit {
            get { return GetParameterValue<int?>(nameof(MaxDataVolumesLimit).ToLower()); }
            set { SetParameterValue(nameof(MaxDataVolumesLimit).ToLower(), value); }
        }

        /// <summary>
        /// the max number of Guest VMs per host for this hypervisor.
        /// </summary>
        public long? MaxGuestsLimit {
            get { return GetParameterValue<long?>(nameof(MaxGuestsLimit).ToLower()); }
            set { SetParameterValue(nameof(MaxGuestsLimit).ToLower(), value); }
        }

        /// <summary>
        /// the maximum number of the hypervisor hosts per cluster 
        /// </summary>
        public int? Maxhostspercluster {
            get { return GetParameterValue<int?>(nameof(Maxhostspercluster).ToLower()); }
            set { SetParameterValue(nameof(Maxhostspercluster).ToLower(), value); }
        }

        /// <summary>
        /// set true to enable security group for this hypervisor.
        /// </summary>
        public bool? SecurityGroupEnabled {
            get { return GetParameterValue<bool?>(nameof(SecurityGroupEnabled).ToLower()); }
            set { SetParameterValue(nameof(SecurityGroupEnabled).ToLower(), value); }
        }

        /// <summary>
        /// set true to enable storage motion support for this hypervisor
        /// </summary>
        public bool? Storagemotionenabled {
            get { return GetParameterValue<bool?>(nameof(Storagemotionenabled).ToLower()); }
            set { SetParameterValue(nameof(Storagemotionenabled).ToLower(), value); }
        }

        /// <summary>
        /// set true to enable VM snapshots for this hypervisor
        /// </summary>
        public bool? VmSnapshotEnabled {
            get { return GetParameterValue<bool?>(nameof(VmSnapshotEnabled).ToLower()); }
            set { SetParameterValue(nameof(VmSnapshotEnabled).ToLower(), value); }
        }

    }
    /// <summary>
    /// Updates a hypervisor capabilities.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        HypervisorCapabilitiesResponse UpdateHypervisorCapabilities(UpdateHypervisorCapabilitiesRequest request);
        Task<HypervisorCapabilitiesResponse> UpdateHypervisorCapabilitiesAsync(UpdateHypervisorCapabilitiesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public HypervisorCapabilitiesResponse UpdateHypervisorCapabilities(UpdateHypervisorCapabilitiesRequest request) => Proxy.Request<HypervisorCapabilitiesResponse>(request);
        public Task<HypervisorCapabilitiesResponse> UpdateHypervisorCapabilitiesAsync(UpdateHypervisorCapabilitiesRequest request) => Proxy.RequestAsync<HypervisorCapabilitiesResponse>(request);
    }
}
