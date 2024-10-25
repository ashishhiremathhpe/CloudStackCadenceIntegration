using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListElastistorInterfaceRequest : APIRequest
    {
        public ListElastistorInterfaceRequest() : base("listElastistorInterface") {}

        /// <summary>
        /// controller id
        /// </summary>
        public string Controllerid {
            get { return GetParameterValue<string>(nameof(Controllerid).ToLower()); }
            set { SetParameterValue(nameof(Controllerid).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists the network Interfaces of elastistor
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListElastistorVolumeResponse ListElastistorInterface(ListElastistorInterfaceRequest request);
        Task<ListElastistorVolumeResponse> ListElastistorInterfaceAsync(ListElastistorInterfaceRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListElastistorVolumeResponse ListElastistorInterface(ListElastistorInterfaceRequest request) => Proxy.Request<ListElastistorVolumeResponse>(request);
        public Task<ListElastistorVolumeResponse> ListElastistorInterfaceAsync(ListElastistorInterfaceRequest request) => Proxy.RequestAsync<ListElastistorVolumeResponse>(request);
    }
}
