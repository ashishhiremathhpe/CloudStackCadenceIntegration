using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class IsAccountAllowedToCreateOfferingsWithTagsRequest : APIRequest
    {
        public IsAccountAllowedToCreateOfferingsWithTagsRequest() : base("isAccountAllowedToCreateOfferingsWithTags") {}

        /// <summary>
        /// Account UUID
        /// </summary>
        public Guid? Id {
            get { return GetParameterValue<Guid?>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Return true if the specified account is allowed to create offerings with tags.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        IsAccountAllowedToCreateOfferingsWithTagsResponse IsAccountAllowedToCreateOfferingsWithTags(IsAccountAllowedToCreateOfferingsWithTagsRequest request);
        Task<IsAccountAllowedToCreateOfferingsWithTagsResponse> IsAccountAllowedToCreateOfferingsWithTagsAsync(IsAccountAllowedToCreateOfferingsWithTagsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public IsAccountAllowedToCreateOfferingsWithTagsResponse IsAccountAllowedToCreateOfferingsWithTags(IsAccountAllowedToCreateOfferingsWithTagsRequest request) => Proxy.Request<IsAccountAllowedToCreateOfferingsWithTagsResponse>(request);
        public Task<IsAccountAllowedToCreateOfferingsWithTagsResponse> IsAccountAllowedToCreateOfferingsWithTagsAsync(IsAccountAllowedToCreateOfferingsWithTagsRequest request) => Proxy.RequestAsync<IsAccountAllowedToCreateOfferingsWithTagsResponse>(request);
    }
}
