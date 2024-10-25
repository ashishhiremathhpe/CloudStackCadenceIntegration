using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListElastistorVolumeRequest : APIRequest
    {
        public ListElastistorVolumeRequest() : base("listElastistorVolume") {}

        /// <summary>
        /// the ID of the account
        /// </summary>
        public string Id {
            get { return GetParameterValue<string>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists the volumes of elastistor
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListElastistorVolumeResponse ListElastistorVolume(ListElastistorVolumeRequest request);
        Task<ListElastistorVolumeResponse> ListElastistorVolumeAsync(ListElastistorVolumeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListElastistorVolumeResponse ListElastistorVolume(ListElastistorVolumeRequest request) => Proxy.Request<ListElastistorVolumeResponse>(request);
        public Task<ListElastistorVolumeResponse> ListElastistorVolumeAsync(ListElastistorVolumeRequest request) => Proxy.RequestAsync<ListElastistorVolumeResponse>(request);
    }
}
