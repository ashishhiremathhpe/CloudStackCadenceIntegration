using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateVlanIpRangeRequest : APIRequest
    {
        public UpdateVlanIpRangeRequest() : base("updateVlanIpRange") {}

        /// <summary>
        /// the UUID of the VLAN IP range
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// the ending IP address in the VLAN IP range
        /// </summary>
        public string EndIp {
            get { return GetParameterValue<string>(nameof(EndIp).ToLower()); }
            set { SetParameterValue(nameof(EndIp).ToLower(), value); }
        }

        /// <summary>
        /// the ending IPv6 address in the IPv6 network range
        /// </summary>
        public string EndIpv6 {
            get { return GetParameterValue<string>(nameof(EndIpv6).ToLower()); }
            set { SetParameterValue(nameof(EndIpv6).ToLower(), value); }
        }

        /// <summary>
        /// true if IP range is set to system vms, false if not
        /// </summary>
        public bool? ForSystemVms {
            get { return GetParameterValue<bool?>(nameof(ForSystemVms).ToLower()); }
            set { SetParameterValue(nameof(ForSystemVms).ToLower(), value); }
        }

        /// <summary>
        /// the gateway of the VLAN IP range
        /// </summary>
        public string Gateway {
            get { return GetParameterValue<string>(nameof(Gateway).ToLower()); }
            set { SetParameterValue(nameof(Gateway).ToLower(), value); }
        }

        /// <summary>
        /// the CIDR of IPv6 network, must be at least /64
        /// </summary>
        public string Ip6Cidr {
            get { return GetParameterValue<string>(nameof(Ip6Cidr).ToLower()); }
            set { SetParameterValue(nameof(Ip6Cidr).ToLower(), value); }
        }

        /// <summary>
        /// the gateway of the IPv6 network
        /// </summary>
        public string Ip6Gateway {
            get { return GetParameterValue<string>(nameof(Ip6Gateway).ToLower()); }
            set { SetParameterValue(nameof(Ip6Gateway).ToLower(), value); }
        }

        /// <summary>
        /// the netmask of the VLAN IP range
        /// </summary>
        public string Netmask {
            get { return GetParameterValue<string>(nameof(Netmask).ToLower()); }
            set { SetParameterValue(nameof(Netmask).ToLower(), value); }
        }

        /// <summary>
        /// the beginning IP address in the VLAN IP range
        /// </summary>
        public string StartIp {
            get { return GetParameterValue<string>(nameof(StartIp).ToLower()); }
            set { SetParameterValue(nameof(StartIp).ToLower(), value); }
        }

        /// <summary>
        /// the beginning IPv6 address in the IPv6 network range
        /// </summary>
        public string StartIpv6 {
            get { return GetParameterValue<string>(nameof(StartIpv6).ToLower()); }
            set { SetParameterValue(nameof(StartIpv6).ToLower(), value); }
        }

    }
    /// <summary>
    /// Updates a VLAN IP range.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        VlanIpRangeResponse UpdateVlanIpRange(UpdateVlanIpRangeRequest request);
        Task<VlanIpRangeResponse> UpdateVlanIpRangeAsync(UpdateVlanIpRangeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public VlanIpRangeResponse UpdateVlanIpRange(UpdateVlanIpRangeRequest request) => Proxy.Request<VlanIpRangeResponse>(request);
        public Task<VlanIpRangeResponse> UpdateVlanIpRangeAsync(UpdateVlanIpRangeRequest request) => Proxy.RequestAsync<VlanIpRangeResponse>(request);
    }
}
