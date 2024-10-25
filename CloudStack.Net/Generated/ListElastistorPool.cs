using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListElastistorPoolRequest : APIRequest
    {
        public ListElastistorPoolRequest() : base("listElastistorPool") {}

        /// <summary>
        /// the ID of the Pool
        /// </summary>
        public long? Id {
            get { return GetParameterValue<long?>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists the pools of elastistor
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListElastistorPoolResponse ListElastistorPool(ListElastistorPoolRequest request);
        Task<ListElastistorPoolResponse> ListElastistorPoolAsync(ListElastistorPoolRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListElastistorPoolResponse ListElastistorPool(ListElastistorPoolRequest request) => Proxy.Request<ListElastistorPoolResponse>(request);
        public Task<ListElastistorPoolResponse> ListElastistorPoolAsync(ListElastistorPoolRequest request) => Proxy.RequestAsync<ListElastistorPoolResponse>(request);
    }
}
