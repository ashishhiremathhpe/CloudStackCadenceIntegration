using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListInfrastructureRequest : APIRequest
    {
        public ListInfrastructureRequest() : base("listInfrastructure") {}

    }
    /// <summary>
    /// Lists infrastructure
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        InfrastructureResponse ListInfrastructure(ListInfrastructureRequest request);
        Task<InfrastructureResponse> ListInfrastructureAsync(ListInfrastructureRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public InfrastructureResponse ListInfrastructure(ListInfrastructureRequest request) => Proxy.Request<InfrastructureResponse>(request);
        public Task<InfrastructureResponse> ListInfrastructureAsync(ListInfrastructureRequest request) => Proxy.RequestAsync<InfrastructureResponse>(request);
    }
}
