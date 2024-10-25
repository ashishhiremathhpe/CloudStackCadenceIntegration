using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateVPCOfferingRequest : APIRequest
    {
        public CreateVPCOfferingRequest() : base("createVPCOffering") {}

        /// <summary>
        /// the name of the vpc offering
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// services supported by the vpc offering
        /// </summary>
        public IList<string> SupportedServices {
            get { return GetList<string>(nameof(SupportedServices).ToLower()); }
            set { SetParameterValue(nameof(SupportedServices).ToLower(), value); }
        }

        /// <summary>
        /// the display text of the vpc offering, defaults to the 'name'
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
        /// set to true if the offering is to be enabled during creation. Default is false
        /// </summary>
        public bool? Enable {
            get { return GetParameterValue<bool?>(nameof(Enable).ToLower()); }
            set { SetParameterValue(nameof(Enable).ToLower(), value); }
        }

        /// <summary>
        /// The internet protocol of the offering. Options are ipv4 and dualstack. Default is ipv4. dualstack will create an offering that supports both IPv4 and IPv6
        /// </summary>
        public string InternetProtocol {
            get { return GetParameterValue<string>(nameof(InternetProtocol).ToLower()); }
            set { SetParameterValue(nameof(InternetProtocol).ToLower(), value); }
        }

        /// <summary>
        /// desired service capabilities as part of vpc offering
        /// </summary>
        public IList<IDictionary<string, object>> ServiceCapabilityList {
            get { return GetList<IDictionary<string, object>>(nameof(ServiceCapabilityList).ToLower()); }
            set { SetParameterValue(nameof(ServiceCapabilityList).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the service offering for the VPC router appliance
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
        /// the ID of the containing zone(s), null for public offerings
        /// </summary>
        public IList<Guid> Zoneid {
            get { return GetList<Guid>(nameof(Zoneid).ToLower()); }
            set { SetParameterValue(nameof(Zoneid).ToLower(), value); }
        }

    }
    /// <summary>
    /// Creates VPC offering
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse CreateVPCOffering(CreateVPCOfferingRequest request);
        Task<AsyncJobResponse> CreateVPCOfferingAsync(CreateVPCOfferingRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse CreateVPCOffering(CreateVPCOfferingRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> CreateVPCOfferingAsync(CreateVPCOfferingRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
