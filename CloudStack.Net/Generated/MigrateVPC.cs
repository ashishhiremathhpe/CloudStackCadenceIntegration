using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class MigrateVPCRequest : APIRequest
    {
        public MigrateVPCRequest() : base("migrateVPC") {}

        /// <summary>
        /// the ID of the vpc
        /// </summary>
        public Guid Vpcid {
            get { return GetParameterValue<Guid>(nameof(Vpcid).ToLower()); }
            set { SetParameterValue(nameof(Vpcid).ToLower(), value); }
        }

        /// <summary>
        /// vpc offering ID
        /// </summary>
        public Guid VpcOfferingId {
            get { return GetParameterValue<Guid>(nameof(VpcOfferingId).ToLower()); }
            set { SetParameterValue(nameof(VpcOfferingId).ToLower(), value); }
        }

        /// <summary>
        /// true if previous network migration cmd failed
        /// </summary>
        public bool? Resume {
            get { return GetParameterValue<bool?>(nameof(Resume).ToLower()); }
            set { SetParameterValue(nameof(Resume).ToLower(), value); }
        }

        /// <summary>
        /// network offering ids for each network in the vpc. Example: tierNetworkOfferings[0].networkId=networkId1&tierNetworkOfferings[0].networkOfferingId=newNetworkofferingId1&tierNetworkOfferings[1].networkId=networkId2&tierNetworkOfferings[1].networkOfferingId=newNetworkofferingId2
        /// </summary>
        public IList<IDictionary<string, object>> TierNetworkOfferings {
            get { return GetList<IDictionary<string, object>>(nameof(TierNetworkOfferings).ToLower()); }
            set { SetParameterValue(nameof(TierNetworkOfferings).ToLower(), value); }
        }

    }
    /// <summary>
    /// moves a vpc to another physical network
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse MigrateVPC(MigrateVPCRequest request);
        Task<AsyncJobResponse> MigrateVPCAsync(MigrateVPCRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse MigrateVPC(MigrateVPCRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> MigrateVPCAsync(MigrateVPCRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
