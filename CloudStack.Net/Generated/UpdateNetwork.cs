using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateNetworkRequest : APIRequest
    {
        public UpdateNetworkRequest() : base("updateNetwork") {}

        /// <summary>
        /// the ID of the network
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// Force update even if CIDR type is different
        /// </summary>
        public bool? ChangeCidr {
            get { return GetParameterValue<bool?>(nameof(ChangeCidr).ToLower()); }
            set { SetParameterValue(nameof(ChangeCidr).ToLower(), value); }
        }

        /// <summary>
        /// an optional field, in case you want to set a custom id to the resource. Allowed to Root Admins only
        /// </summary>
        public string CustomId {
            get { return GetParameterValue<string>(nameof(CustomId).ToLower()); }
            set { SetParameterValue(nameof(CustomId).ToLower(), value); }
        }

        /// <summary>
        /// an optional field, whether to the display the network to the end user or not.
        /// </summary>
        public bool? DisplayNetwork {
            get { return GetParameterValue<bool?>(nameof(DisplayNetwork).ToLower()); }
            set { SetParameterValue(nameof(DisplayNetwork).ToLower(), value); }
        }

        /// <summary>
        /// the new display text for the network
        /// </summary>
        public string DisplayText {
            get { return GetParameterValue<string>(nameof(DisplayText).ToLower()); }
            set { SetParameterValue(nameof(DisplayText).ToLower(), value); }
        }

        /// <summary>
        /// the first IPv4 DNS for the network. Empty string will update the first IPv4 DNS with the value from the zone
        /// </summary>
        public string Dns1 {
            get { return GetParameterValue<string>(nameof(Dns1).ToLower()); }
            set { SetParameterValue(nameof(Dns1).ToLower(), value); }
        }

        /// <summary>
        /// the second IPv4 DNS for the network. Empty string will update the second IPv4 DNS with the value from the zone
        /// </summary>
        public string Dns2 {
            get { return GetParameterValue<string>(nameof(Dns2).ToLower()); }
            set { SetParameterValue(nameof(Dns2).ToLower(), value); }
        }

        /// <summary>
        /// Setting this to true will cause a forced network update,
        /// </summary>
        public bool? Forced {
            get { return GetParameterValue<bool?>(nameof(Forced).ToLower()); }
            set { SetParameterValue(nameof(Forced).ToLower(), value); }
        }

        /// <summary>
        /// CIDR for guest VMs, CloudStack allocates IPs to guest VMs only from this CIDR
        /// </summary>
        public string GuestVmCidr {
            get { return GetParameterValue<string>(nameof(GuestVmCidr).ToLower()); }
            set { SetParameterValue(nameof(GuestVmCidr).ToLower(), value); }
        }

        /// <summary>
        /// when true ip address usage for the network will not be exported by the listUsageRecords API
        /// </summary>
        public bool? HideIpAddressUsage {
            get { return GetParameterValue<bool?>(nameof(HideIpAddressUsage).ToLower()); }
            set { SetParameterValue(nameof(HideIpAddressUsage).ToLower(), value); }
        }

        /// <summary>
        /// the first IPv6 DNS for the network. Empty string will update the first IPv6 DNS with the value from the zone
        /// </summary>
        public string Ip6Dns1 {
            get { return GetParameterValue<string>(nameof(Ip6Dns1).ToLower()); }
            set { SetParameterValue(nameof(Ip6Dns1).ToLower(), value); }
        }

        /// <summary>
        /// the second IPv6 DNS for the network. Empty string will update the second IPv6 DNS with the value from the zone
        /// </summary>
        public string Ip6Dns2 {
            get { return GetParameterValue<string>(nameof(Ip6Dns2).ToLower()); }
            set { SetParameterValue(nameof(Ip6Dns2).ToLower(), value); }
        }

        /// <summary>
        /// the new name for the network
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// network domain
        /// </summary>
        public string NetworkDomain {
            get { return GetParameterValue<string>(nameof(NetworkDomain).ToLower()); }
            set { SetParameterValue(nameof(NetworkDomain).ToLower(), value); }
        }

        /// <summary>
        /// network offering ID
        /// </summary>
        public Guid? NetworkOfferingId {
            get { return GetParameterValue<Guid?>(nameof(NetworkOfferingId).ToLower()); }
            set { SetParameterValue(nameof(NetworkOfferingId).ToLower(), value); }
        }

        /// <summary>
        /// MTU to be configured on the network VR's public facing interfaces
        /// </summary>
        public int? PrivateMtu {
            get { return GetParameterValue<int?>(nameof(PrivateMtu).ToLower()); }
            set { SetParameterValue(nameof(PrivateMtu).ToLower(), value); }
        }

        /// <summary>
        /// MTU to be configured on the network VR's public facing interfaces
        /// </summary>
        public int? PublicMtu {
            get { return GetParameterValue<int?>(nameof(PublicMtu).ToLower()); }
            set { SetParameterValue(nameof(PublicMtu).ToLower(), value); }
        }

        /// <summary>
        /// IPV4 address to be assigned to the public interface of the network router. This address must already be acquired for this network
        /// </summary>
        public string Sourcenatipaddress {
            get { return GetParameterValue<string>(nameof(Sourcenatipaddress).ToLower()); }
            set { SetParameterValue(nameof(Sourcenatipaddress).ToLower(), value); }
        }

        /// <summary>
        /// if true, we will update the routers one after the other. applicable only for redundant router based networks using virtual router as provider
        /// </summary>
        public bool? UpdateInSequence {
            get { return GetParameterValue<bool?>(nameof(UpdateInSequence).ToLower()); }
            set { SetParameterValue(nameof(UpdateInSequence).ToLower(), value); }
        }

    }
    /// <summary>
    /// Updates a network
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse UpdateNetwork(UpdateNetworkRequest request);
        Task<AsyncJobResponse> UpdateNetworkAsync(UpdateNetworkRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse UpdateNetwork(UpdateNetworkRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> UpdateNetworkAsync(UpdateNetworkRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
