using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateNetworkOfferingRequest : APIRequest
    {
        public CreateNetworkOfferingRequest() : base("createNetworkOffering") {}

        /// <summary>
        /// guest type of the network offering: Shared or Isolated
        /// </summary>
        public string GuestIptype {
            get { return GetParameterValue<string>(nameof(GuestIptype).ToLower()); }
            set { SetParameterValue(nameof(GuestIptype).ToLower(), value); }
        }

        /// <summary>
        /// the name of the network offering
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// the traffic type for the network offering. Supported type in current release is GUEST only
        /// </summary>
        public string Traffictype {
            get { return GetParameterValue<string>(nameof(Traffictype).ToLower()); }
            set { SetParameterValue(nameof(Traffictype).ToLower(), value); }
        }

        /// <summary>
        /// the availability of network offering. The default value is Optional.  Another value is Required, which will make it as the default network offering for new networks 
        /// </summary>
        public string Availability {
            get { return GetParameterValue<string>(nameof(Availability).ToLower()); }
            set { SetParameterValue(nameof(Availability).ToLower(), value); }
        }

        /// <summary>
        /// true if the network offering is IP conserve mode enabled
        /// </summary>
        public bool? ConserveMode {
            get { return GetParameterValue<bool?>(nameof(ConserveMode).ToLower()); }
            set { SetParameterValue(nameof(ConserveMode).ToLower(), value); }
        }

        /// <summary>
        /// Network offering details in key/value pairs. Supported keys are internallbprovider/publiclbprovider with service provider as a value, and promiscuousmode/macaddresschanges/forgedtransmits with true/false as value to accept/reject the security settings if available for a nic/portgroup
        /// </summary>
        public IList<IDictionary<string, object>> Details {
            get { return GetList<IDictionary<string, object>>(nameof(Details).ToLower()); }
            set { SetParameterValue(nameof(Details).ToLower(), value); }
        }

        /// <summary>
        /// the display text of the network offering, defaults to the value of 'name'.
        /// </summary>
        public string DisplayText {
            get { return GetParameterValue<string>(nameof(DisplayText).ToLower()); }
            set { SetParameterValue(nameof(DisplayText).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the containing domain(s), null for public offerings
        /// </summary>
        public IList<Guid> Domainid {
            get { return GetList<Guid>(nameof(Domainid).ToLower()); }
            set { SetParameterValue(nameof(Domainid).ToLower(), value); }
        }

        /// <summary>
        /// true if guest network default egress policy is allow; false if default egress policy is deny
        /// </summary>
        public bool? EgressDefaultPolicy {
            get { return GetParameterValue<bool?>(nameof(EgressDefaultPolicy).ToLower()); }
            set { SetParameterValue(nameof(EgressDefaultPolicy).ToLower(), value); }
        }

        /// <summary>
        /// set to true if the offering is to be enabled during creation. Default is false
        /// </summary>
        public bool? Enable {
            get { return GetParameterValue<bool?>(nameof(Enable).ToLower()); }
            set { SetParameterValue(nameof(Enable).ToLower(), value); }
        }

        /// <summary>
        /// true if network offering is meant to be used for Tungsten-Fabric, false otherwise.
        /// </summary>
        public bool? ForTungsten {
            get { return GetParameterValue<bool?>(nameof(ForTungsten).ToLower()); }
            set { SetParameterValue(nameof(ForTungsten).ToLower(), value); }
        }

        /// <summary>
        /// true if network offering is meant to be used for VPC, false otherwise.
        /// </summary>
        public bool? ForVpc {
            get { return GetParameterValue<bool?>(nameof(ForVpc).ToLower()); }
            set { SetParameterValue(nameof(ForVpc).ToLower(), value); }
        }

        /// <summary>
        /// The internet protocol of network offering. Options are ipv4 and dualstack. Default is ipv4. dualstack will create a network offering that supports both IPv4 and IPv6
        /// </summary>
        public string InternetProtocol {
            get { return GetParameterValue<string>(nameof(InternetProtocol).ToLower()); }
            set { SetParameterValue(nameof(InternetProtocol).ToLower(), value); }
        }

        /// <summary>
        /// true if network offering supports persistent networks; defaulted to false if not specified
        /// </summary>
        public bool? IsPersistent {
            get { return GetParameterValue<bool?>(nameof(IsPersistent).ToLower()); }
            set { SetParameterValue(nameof(IsPersistent).ToLower(), value); }
        }

        /// <summary>
        /// if true keepalive will be turned on in the loadbalancer. At the time of writing this has only an effect on haproxy; the mode http and httpclose options are unset in the haproxy conf file.
        /// </summary>
        public bool? KeepAliveEnabled {
            get { return GetParameterValue<bool?>(nameof(KeepAliveEnabled).ToLower()); }
            set { SetParameterValue(nameof(KeepAliveEnabled).ToLower(), value); }
        }

        /// <summary>
        /// maximum number of concurrent connections supported by the network offering
        /// </summary>
        public int? MaxConnections {
            get { return GetParameterValue<int?>(nameof(MaxConnections).ToLower()); }
            set { SetParameterValue(nameof(MaxConnections).ToLower(), value); }
        }

        /// <summary>
        /// data transfer rate in megabits per second allowed
        /// </summary>
        public int? NetworkRate {
            get { return GetParameterValue<int?>(nameof(NetworkRate).ToLower()); }
            set { SetParameterValue(nameof(NetworkRate).ToLower(), value); }
        }

        /// <summary>
        /// desired service capabilities as part of network offering
        /// </summary>
        public IList<IDictionary<string, object>> Servicecapabilitylist {
            get { return GetList<IDictionary<string, object>>(nameof(Servicecapabilitylist).ToLower()); }
            set { SetParameterValue(nameof(Servicecapabilitylist).ToLower(), value); }
        }

        /// <summary>
        /// the service offering ID used by virtual router provider
        /// </summary>
        public Guid? ServiceOfferingId {
            get { return GetParameterValue<Guid?>(nameof(ServiceOfferingId).ToLower()); }
            set { SetParameterValue(nameof(ServiceOfferingId).ToLower(), value); }
        }

        /// <summary>
        /// provider to service mapping. If not specified, the provider for the service will be mapped to the default provider on the physical network
        /// </summary>
        public IList<IDictionary<string, object>> ServiceProviderList {
            get { return GetList<IDictionary<string, object>>(nameof(ServiceProviderList).ToLower()); }
            set { SetParameterValue(nameof(ServiceProviderList).ToLower(), value); }
        }

        /// <summary>
        /// true if network offering supports specifying ip ranges; defaulted to false if not specified
        /// </summary>
        public bool? SpecifyIpRanges {
            get { return GetParameterValue<bool?>(nameof(SpecifyIpRanges).ToLower()); }
            set { SetParameterValue(nameof(SpecifyIpRanges).ToLower(), value); }
        }

        /// <summary>
        /// true if network offering supports vlans
        /// </summary>
        public bool? SpecifyVlan {
            get { return GetParameterValue<bool?>(nameof(SpecifyVlan).ToLower()); }
            set { SetParameterValue(nameof(SpecifyVlan).ToLower(), value); }
        }

        /// <summary>
        /// services supported by the network offering
        /// </summary>
        public IList<string> SupportedServices {
            get { return GetList<string>(nameof(SupportedServices).ToLower()); }
            set { SetParameterValue(nameof(SupportedServices).ToLower(), value); }
        }

        /// <summary>
        /// the tags for the network offering.
        /// </summary>
        public string Tags {
            get { return GetParameterValue<string>(nameof(Tags).ToLower()); }
            set { SetParameterValue(nameof(Tags).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the containing zone(s), null for public offerings
        /// </summary>
        public IList<Guid> Zoneid {
            get { return GetList<Guid>(nameof(Zoneid).ToLower()); }
            set { SetParameterValue(nameof(Zoneid).ToLower(), value); }
        }

    }
    /// <summary>
    /// Creates a network offering.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        NetworkOfferingResponse CreateNetworkOffering(CreateNetworkOfferingRequest request);
        Task<NetworkOfferingResponse> CreateNetworkOfferingAsync(CreateNetworkOfferingRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public NetworkOfferingResponse CreateNetworkOffering(CreateNetworkOfferingRequest request) => Proxy.Request<NetworkOfferingResponse>(request);
        public Task<NetworkOfferingResponse> CreateNetworkOfferingAsync(CreateNetworkOfferingRequest request) => Proxy.RequestAsync<NetworkOfferingResponse>(request);
    }
}
