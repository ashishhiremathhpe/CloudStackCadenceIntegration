using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class RemoveSecondaryStorageSelectorRequest : APIRequest
    {
        public RemoveSecondaryStorageSelectorRequest() : base("removeSecondaryStorageSelector") {}

        /// <summary>
        /// The unique identifier of the secondary storage selector to be removed.
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Removes an existing secondary storage selector.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SecondaryStorageHeuristicsResponse RemoveSecondaryStorageSelector(RemoveSecondaryStorageSelectorRequest request);
        Task<SecondaryStorageHeuristicsResponse> RemoveSecondaryStorageSelectorAsync(RemoveSecondaryStorageSelectorRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SecondaryStorageHeuristicsResponse RemoveSecondaryStorageSelector(RemoveSecondaryStorageSelectorRequest request) => Proxy.Request<SecondaryStorageHeuristicsResponse>(request);
        public Task<SecondaryStorageHeuristicsResponse> RemoveSecondaryStorageSelectorAsync(RemoveSecondaryStorageSelectorRequest request) => Proxy.RequestAsync<SecondaryStorageHeuristicsResponse>(request);
    }
}
