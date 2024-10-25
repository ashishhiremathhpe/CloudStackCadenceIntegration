using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateGuestOsMappingRequest : APIRequest
    {
        public UpdateGuestOsMappingRequest() : base("updateGuestOsMapping") {}

        /// <summary>
        /// UUID of the Guest OS to hypervisor name Mapping
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// Hypervisor specific name for this Guest OS
        /// </summary>
        public string OsNameForHypervisor {
            get { return GetParameterValue<string>(nameof(OsNameForHypervisor).ToLower()); }
            set { SetParameterValue(nameof(OsNameForHypervisor).ToLower(), value); }
        }

        /// <summary>
        /// When set to true, checks for the correct guest os mapping name in the provided hypervisor (supports VMware and XenServer only. At least one hypervisor host with the version specified must be available. Default version will not work.)
        /// </summary>
        public bool? OsMappingCheckEnabled {
            get { return GetParameterValue<bool?>(nameof(OsMappingCheckEnabled).ToLower()); }
            set { SetParameterValue(nameof(OsMappingCheckEnabled).ToLower(), value); }
        }

    }
    /// <summary>
    /// Updates the information about Guest OS to Hypervisor specific name mapping
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse UpdateGuestOsMapping(UpdateGuestOsMappingRequest request);
        Task<AsyncJobResponse> UpdateGuestOsMappingAsync(UpdateGuestOsMappingRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse UpdateGuestOsMapping(UpdateGuestOsMappingRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> UpdateGuestOsMappingAsync(UpdateGuestOsMappingRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
