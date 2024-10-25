using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class SynchronizeTungstenFabricDataRequest : APIRequest
    {
        public SynchronizeTungstenFabricDataRequest() : base("synchronizeTungstenFabricData") {}

        /// <summary>
        /// provider id
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Synchronize Tungsten-Fabric data
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse SynchronizeTungstenFabricData(SynchronizeTungstenFabricDataRequest request);
        Task<SuccessResponse> SynchronizeTungstenFabricDataAsync(SynchronizeTungstenFabricDataRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse SynchronizeTungstenFabricData(SynchronizeTungstenFabricDataRequest request) => Proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> SynchronizeTungstenFabricDataAsync(SynchronizeTungstenFabricDataRequest request) => Proxy.RequestAsync<SuccessResponse>(request);
    }
}
