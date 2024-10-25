using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ApplyTungstenFabricTagRequest : APIRequest
    {
        public ApplyTungstenFabricTagRequest() : base("applyTungstenFabricTag") {}

        /// <summary>
        /// the uuid of Tungsten-Fabric tag
        /// </summary>
        public string TagUuid {
            get { return GetParameterValue<string>(nameof(TagUuid).ToLower()); }
            set { SetParameterValue(nameof(TagUuid).ToLower(), value); }
        }

        /// <summary>
        /// the ID of zone
        /// </summary>
        public Guid ZoneId {
            get { return GetParameterValue<Guid>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

        /// <summary>
        /// the uuid of Tungsten-Fabric application policy set
        /// </summary>
        public string ApplicationPolicySetUuid {
            get { return GetParameterValue<string>(nameof(ApplicationPolicySetUuid).ToLower()); }
            set { SetParameterValue(nameof(ApplicationPolicySetUuid).ToLower(), value); }
        }

        /// <summary>
        /// the uuid of networks
        /// </summary>
        public IList<string> Networkuuid {
            get { return GetList<string>(nameof(Networkuuid).ToLower()); }
            set { SetParameterValue(nameof(Networkuuid).ToLower(), value); }
        }

        /// <summary>
        /// the uuid of nics
        /// </summary>
        public IList<string> Nicuuid {
            get { return GetList<string>(nameof(Nicuuid).ToLower()); }
            set { SetParameterValue(nameof(Nicuuid).ToLower(), value); }
        }

        /// <summary>
        /// the uuid of Tungsten-Fabric policy
        /// </summary>
        public string PolicyUuid {
            get { return GetParameterValue<string>(nameof(PolicyUuid).ToLower()); }
            set { SetParameterValue(nameof(PolicyUuid).ToLower(), value); }
        }

        /// <summary>
        /// the uuid of vms
        /// </summary>
        public IList<string> Vmuuid {
            get { return GetList<string>(nameof(Vmuuid).ToLower()); }
            set { SetParameterValue(nameof(Vmuuid).ToLower(), value); }
        }

    }
    /// <summary>
    /// apply Tungsten-Fabric tag
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse ApplyTungstenFabricTag(ApplyTungstenFabricTagRequest request);
        Task<AsyncJobResponse> ApplyTungstenFabricTagAsync(ApplyTungstenFabricTagRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse ApplyTungstenFabricTag(ApplyTungstenFabricTagRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> ApplyTungstenFabricTagAsync(ApplyTungstenFabricTagRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
