using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DestroyVolumeRequest : APIRequest
    {
        public DestroyVolumeRequest() : base("destroyVolume") {}

        /// <summary>
        /// The ID of the volume
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// If true is passed, the volume is expunged immediately. False by default.
        /// </summary>
        public bool? Expunge {
            get { return GetParameterValue<bool?>(nameof(Expunge).ToLower()); }
            set { SetParameterValue(nameof(Expunge).ToLower(), value); }
        }

    }
    /// <summary>
    /// Destroys a Volume.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DestroyVolume(DestroyVolumeRequest request);
        Task<AsyncJobResponse> DestroyVolumeAsync(DestroyVolumeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DestroyVolume(DestroyVolumeRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DestroyVolumeAsync(DestroyVolumeRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
