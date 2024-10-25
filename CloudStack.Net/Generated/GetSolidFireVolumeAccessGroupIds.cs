using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class GetSolidFireVolumeAccessGroupIdsRequest : APIRequest
    {
        public GetSolidFireVolumeAccessGroupIdsRequest() : base("getSolidFireVolumeAccessGroupIds") {}

        /// <summary>
        /// Cluster UUID
        /// </summary>
        public string Clusterid {
            get { return GetParameterValue<string>(nameof(Clusterid).ToLower()); }
            set { SetParameterValue(nameof(Clusterid).ToLower(), value); }
        }

        /// <summary>
        /// Storage Pool UUID
        /// </summary>
        public string Storageid {
            get { return GetParameterValue<string>(nameof(Storageid).ToLower()); }
            set { SetParameterValue(nameof(Storageid).ToLower(), value); }
        }

    }
    /// <summary>
    /// Get the SF Volume Access Group IDs
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ApiSolidFireVolumeAccessGroupIdsResponse GetSolidFireVolumeAccessGroupIds(GetSolidFireVolumeAccessGroupIdsRequest request);
        Task<ApiSolidFireVolumeAccessGroupIdsResponse> GetSolidFireVolumeAccessGroupIdsAsync(GetSolidFireVolumeAccessGroupIdsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ApiSolidFireVolumeAccessGroupIdsResponse GetSolidFireVolumeAccessGroupIds(GetSolidFireVolumeAccessGroupIdsRequest request) => Proxy.Request<ApiSolidFireVolumeAccessGroupIdsResponse>(request);
        public Task<ApiSolidFireVolumeAccessGroupIdsResponse> GetSolidFireVolumeAccessGroupIdsAsync(GetSolidFireVolumeAccessGroupIdsRequest request) => Proxy.RequestAsync<ApiSolidFireVolumeAccessGroupIdsResponse>(request);
    }
}
