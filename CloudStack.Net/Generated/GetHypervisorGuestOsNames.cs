using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class GetHypervisorGuestOsNamesRequest : APIRequest
    {
        public GetHypervisorGuestOsNamesRequest() : base("getHypervisorGuestOsNames") {}

        /// <summary>
        /// Hypervisor type. One of : VMware, XenServer
        /// </summary>
        public string Hypervisor {
            get { return GetParameterValue<string>(nameof(Hypervisor).ToLower()); }
            set { SetParameterValue(nameof(Hypervisor).ToLower(), value); }
        }

        /// <summary>
        /// Hypervisor version to get the guest os names (atleast one hypervisor host with the version specified must be available)
        /// </summary>
        public string HypervisorVersion {
            get { return GetParameterValue<string>(nameof(HypervisorVersion).ToLower()); }
            set { SetParameterValue(nameof(HypervisorVersion).ToLower(), value); }
        }

        /// <summary>
        /// Keyword for guest os name
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

    }
    /// <summary>
    /// Gets the guest OS names in the hypervisor
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse GetHypervisorGuestOsNames(GetHypervisorGuestOsNamesRequest request);
        Task<AsyncJobResponse> GetHypervisorGuestOsNamesAsync(GetHypervisorGuestOsNamesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse GetHypervisorGuestOsNames(GetHypervisorGuestOsNamesRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> GetHypervisorGuestOsNamesAsync(GetHypervisorGuestOsNamesRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
