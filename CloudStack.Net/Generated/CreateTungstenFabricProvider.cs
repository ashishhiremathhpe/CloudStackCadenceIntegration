using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateTungstenFabricProviderRequest : APIRequest
    {
        public CreateTungstenFabricProviderRequest() : base("createTungstenFabricProvider") {}

        /// <summary>
        /// Tungsten-Fabric provider name
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// Tungsten-Fabric provider gateway
        /// </summary>
        public string Tungstengateway {
            get { return GetParameterValue<string>(nameof(Tungstengateway).ToLower()); }
            set { SetParameterValue(nameof(Tungstengateway).ToLower(), value); }
        }

        /// <summary>
        /// Tungsten-Fabric provider hostname
        /// </summary>
        public string Tungstenproviderhostname {
            get { return GetParameterValue<string>(nameof(Tungstenproviderhostname).ToLower()); }
            set { SetParameterValue(nameof(Tungstenproviderhostname).ToLower(), value); }
        }

        /// <summary>
        /// the ID of zone
        /// </summary>
        public Guid ZoneId {
            get { return GetParameterValue<Guid>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

        /// <summary>
        /// Tungsten-Fabric provider introspect port
        /// </summary>
        public string Tungstenproviderintrospectport {
            get { return GetParameterValue<string>(nameof(Tungstenproviderintrospectport).ToLower()); }
            set { SetParameterValue(nameof(Tungstenproviderintrospectport).ToLower(), value); }
        }

        /// <summary>
        /// Tungsten-Fabric provider port
        /// </summary>
        public string Tungstenproviderport {
            get { return GetParameterValue<string>(nameof(Tungstenproviderport).ToLower()); }
            set { SetParameterValue(nameof(Tungstenproviderport).ToLower(), value); }
        }

        /// <summary>
        /// Tungsten-Fabric provider vrouter port
        /// </summary>
        public string Tungstenprovidervrouterport {
            get { return GetParameterValue<string>(nameof(Tungstenprovidervrouterport).ToLower()); }
            set { SetParameterValue(nameof(Tungstenprovidervrouterport).ToLower(), value); }
        }

    }
    /// <summary>
    /// Create Tungsten-Fabric provider in cloudstack
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        TungstenFabricProviderResponse CreateTungstenFabricProvider(CreateTungstenFabricProviderRequest request);
        Task<TungstenFabricProviderResponse> CreateTungstenFabricProviderAsync(CreateTungstenFabricProviderRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public TungstenFabricProviderResponse CreateTungstenFabricProvider(CreateTungstenFabricProviderRequest request) => Proxy.Request<TungstenFabricProviderResponse>(request);
        public Task<TungstenFabricProviderResponse> CreateTungstenFabricProviderAsync(CreateTungstenFabricProviderRequest request) => Proxy.RequestAsync<TungstenFabricProviderResponse>(request);
    }
}
