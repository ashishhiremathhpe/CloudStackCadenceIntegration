using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class GetPathForVolumeRequest : APIRequest
    {
        public GetPathForVolumeRequest() : base("getPathForVolume") {}

        /// <summary>
        /// CloudStack Volume UUID
        /// </summary>
        public string Volumeid {
            get { return GetParameterValue<string>(nameof(Volumeid).ToLower()); }
            set { SetParameterValue(nameof(Volumeid).ToLower(), value); }
        }

    }
    /// <summary>
    /// Get the path associated with the provided volume UUID
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ApiPathForVolumeResponse GetPathForVolume(GetPathForVolumeRequest request);
        Task<ApiPathForVolumeResponse> GetPathForVolumeAsync(GetPathForVolumeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ApiPathForVolumeResponse GetPathForVolume(GetPathForVolumeRequest request) => Proxy.Request<ApiPathForVolumeResponse>(request);
        public Task<ApiPathForVolumeResponse> GetPathForVolumeAsync(GetPathForVolumeRequest request) => Proxy.RequestAsync<ApiPathForVolumeResponse>(request);
    }
}
