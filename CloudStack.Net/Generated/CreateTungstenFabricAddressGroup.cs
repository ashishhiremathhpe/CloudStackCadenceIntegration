using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateTungstenFabricAddressGroupRequest : APIRequest
    {
        public CreateTungstenFabricAddressGroupRequest() : base("createTungstenFabricAddressGroup") {}

        /// <summary>
        /// Tungsten-Fabric ip prefix
        /// </summary>
        public string IpPrefix {
            get { return GetParameterValue<string>(nameof(IpPrefix).ToLower()); }
            set { SetParameterValue(nameof(IpPrefix).ToLower(), value); }
        }

        /// <summary>
        /// Tungsten-Fabric ip prefix length
        /// </summary>
        public int? IpPrefixLen {
            get { return GetParameterValue<int?>(nameof(IpPrefixLen).ToLower()); }
            set { SetParameterValue(nameof(IpPrefixLen).ToLower(), value); }
        }

        /// <summary>
        /// Tungsten-Fabric address group name
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// the ID of zone
        /// </summary>
        public Guid ZoneId {
            get { return GetParameterValue<Guid>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

    }
    /// <summary>
    /// create Tungsten-Fabric address group
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse CreateTungstenFabricAddressGroup(CreateTungstenFabricAddressGroupRequest request);
        Task<AsyncJobResponse> CreateTungstenFabricAddressGroupAsync(CreateTungstenFabricAddressGroupRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse CreateTungstenFabricAddressGroup(CreateTungstenFabricAddressGroupRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> CreateTungstenFabricAddressGroupAsync(CreateTungstenFabricAddressGroupRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
