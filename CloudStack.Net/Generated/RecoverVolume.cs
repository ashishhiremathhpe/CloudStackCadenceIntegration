using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class RecoverVolumeRequest : APIRequest
    {
        public RecoverVolumeRequest() : base("recoverVolume") {}

        /// <summary>
        /// The ID of the volume
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Recovers a Destroy volume.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        VolumeResponse RecoverVolume(RecoverVolumeRequest request);
        Task<VolumeResponse> RecoverVolumeAsync(RecoverVolumeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public VolumeResponse RecoverVolume(RecoverVolumeRequest request) => Proxy.Request<VolumeResponse>(request);
        public Task<VolumeResponse> RecoverVolumeAsync(RecoverVolumeRequest request) => Proxy.RequestAsync<VolumeResponse>(request);
    }
}
