using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class MoveDomainRequest : APIRequest
    {
        public MoveDomainRequest() : base("moveDomain") {}

        /// <summary>
        /// The ID of the domain to be moved.
        /// </summary>
        public Guid DomainId {
            get { return GetParameterValue<Guid>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// The ID of the new parent domain of the domain to be moved.
        /// </summary>
        public Guid ParentDomainId {
            get { return GetParameterValue<Guid>(nameof(ParentDomainId).ToLower()); }
            set { SetParameterValue(nameof(ParentDomainId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Moves a domain and its children to a new parent domain.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        DomainResponse MoveDomain(MoveDomainRequest request);
        Task<DomainResponse> MoveDomainAsync(MoveDomainRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public DomainResponse MoveDomain(MoveDomainRequest request) => Proxy.Request<DomainResponse>(request);
        public Task<DomainResponse> MoveDomainAsync(MoveDomainRequest request) => Proxy.RequestAsync<DomainResponse>(request);
    }
}
