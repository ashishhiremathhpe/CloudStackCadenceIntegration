using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateConsoleEndpointRequest : APIRequest
    {
        public CreateConsoleEndpointRequest() : base("createConsoleEndpoint") {}

        /// <summary>
        /// ID of the VM
        /// </summary>
        public Guid Virtualmachineid {
            get { return GetParameterValue<Guid>(nameof(Virtualmachineid).ToLower()); }
            set { SetParameterValue(nameof(Virtualmachineid).ToLower(), value); }
        }

        /// <summary>
        /// (optional) extra security token, valid when the extra validation is enabled
        /// </summary>
        public string Token {
            get { return GetParameterValue<string>(nameof(Token).ToLower()); }
            set { SetParameterValue(nameof(Token).ToLower(), value); }
        }

    }
    /// <summary>
    /// Create a console endpoint to connect to a VM console
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        CreateConsoleEndpointResponse CreateConsoleEndpoint(CreateConsoleEndpointRequest request);
        Task<CreateConsoleEndpointResponse> CreateConsoleEndpointAsync(CreateConsoleEndpointRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public CreateConsoleEndpointResponse CreateConsoleEndpoint(CreateConsoleEndpointRequest request) => Proxy.Request<CreateConsoleEndpointResponse>(request);
        public Task<CreateConsoleEndpointResponse> CreateConsoleEndpointAsync(CreateConsoleEndpointRequest request) => Proxy.RequestAsync<CreateConsoleEndpointResponse>(request);
    }
}
