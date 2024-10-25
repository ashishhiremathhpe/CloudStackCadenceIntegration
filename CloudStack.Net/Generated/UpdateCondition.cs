using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateConditionRequest : APIRequest
    {
        public UpdateConditionRequest() : base("updateCondition") {}

        /// <summary>
        /// the ID of the condition.
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// Relational Operator to be used with threshold. Valid values are EQ, GT, LT, GE, LE.
        /// </summary>
        public string RelationalOperator {
            get { return GetParameterValue<string>(nameof(RelationalOperator).ToLower()); }
            set { SetParameterValue(nameof(RelationalOperator).ToLower(), value); }
        }

        /// <summary>
        /// Value for which the Counter will be evaluated with the Operator selected.
        /// </summary>
        public long Threshold {
            get { return GetParameterValue<long>(nameof(Threshold).ToLower()); }
            set { SetParameterValue(nameof(Threshold).ToLower(), value); }
        }

    }
    /// <summary>
    /// Updates a condition for VM auto scaling
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse UpdateCondition(UpdateConditionRequest request);
        Task<AsyncJobResponse> UpdateConditionAsync(UpdateConditionRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse UpdateCondition(UpdateConditionRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> UpdateConditionAsync(UpdateConditionRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
