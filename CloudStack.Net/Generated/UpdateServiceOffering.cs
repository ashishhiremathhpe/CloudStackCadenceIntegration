using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateServiceOfferingRequest : APIRequest
    {
        public UpdateServiceOfferingRequest() : base("updateServiceOffering") {}

        /// <summary>
        /// the ID of the service offering to be updated
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// the display text of the service offering to be updated
        /// </summary>
        public string DisplayText {
            get { return GetParameterValue<string>(nameof(DisplayText).ToLower()); }
            set { SetParameterValue(nameof(DisplayText).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the containing domain(s) as comma separated string, public for public offerings
        /// </summary>
        public string Domainid {
            get { return GetParameterValue<string>(nameof(Domainid).ToLower()); }
            set { SetParameterValue(nameof(Domainid).ToLower(), value); }
        }

        /// <summary>
        /// the host tag for this service offering.
        /// </summary>
        public string HostTags {
            get { return GetParameterValue<string>(nameof(HostTags).ToLower()); }
            set { SetParameterValue(nameof(HostTags).ToLower(), value); }
        }

        /// <summary>
        /// the name of the service offering to be updated
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// sort key of the service offering, integer
        /// </summary>
        public int? SortKey {
            get { return GetParameterValue<int?>(nameof(SortKey).ToLower()); }
            set { SetParameterValue(nameof(SortKey).ToLower(), value); }
        }

        /// <summary>
        /// comma-separated list of tags for the service offering, tags should match with existing storage pool tags
        /// </summary>
        public string StorageTags {
            get { return GetParameterValue<string>(nameof(StorageTags).ToLower()); }
            set { SetParameterValue(nameof(StorageTags).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the containing zone(s) as comma separated string, all for all zones offerings
        /// </summary>
        public string Zoneid {
            get { return GetParameterValue<string>(nameof(Zoneid).ToLower()); }
            set { SetParameterValue(nameof(Zoneid).ToLower(), value); }
        }

    }
    /// <summary>
    /// Updates a service offering.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ServiceOfferingResponse UpdateServiceOffering(UpdateServiceOfferingRequest request);
        Task<ServiceOfferingResponse> UpdateServiceOfferingAsync(UpdateServiceOfferingRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ServiceOfferingResponse UpdateServiceOffering(UpdateServiceOfferingRequest request) => Proxy.Request<ServiceOfferingResponse>(request);
        public Task<ServiceOfferingResponse> UpdateServiceOfferingAsync(UpdateServiceOfferingRequest request) => Proxy.RequestAsync<ServiceOfferingResponse>(request);
    }
}
