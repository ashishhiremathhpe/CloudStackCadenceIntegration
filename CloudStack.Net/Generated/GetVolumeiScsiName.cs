using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class GetVolumeiScsiNameRequest : APIRequest
    {
        public GetVolumeiScsiNameRequest() : base("getVolumeiScsiName") {}

        /// <summary>
        /// CloudStack Volume UUID
        /// </summary>
        public string Volumeid {
            get { return GetParameterValue<string>(nameof(Volumeid).ToLower()); }
            set { SetParameterValue(nameof(Volumeid).ToLower(), value); }
        }

    }
    /// <summary>
    /// Get Volume's iSCSI Name
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ApiVolumeiScsiNameResponse GetVolumeiScsiName(GetVolumeiScsiNameRequest request);
        Task<ApiVolumeiScsiNameResponse> GetVolumeiScsiNameAsync(GetVolumeiScsiNameRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ApiVolumeiScsiNameResponse GetVolumeiScsiName(GetVolumeiScsiNameRequest request) => Proxy.Request<ApiVolumeiScsiNameResponse>(request);
        public Task<ApiVolumeiScsiNameResponse> GetVolumeiScsiNameAsync(GetVolumeiScsiNameRequest request) => Proxy.RequestAsync<ApiVolumeiScsiNameResponse>(request);
    }
}
