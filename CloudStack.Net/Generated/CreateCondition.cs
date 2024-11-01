using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateConditionRequest : APIRequest
    {
        public CreateConditionRequest() : base("createCondition") {}

        /// <summary>
        /// ID of the Counter.
        /// </summary>
        public Guid CounterId {
            get { return GetParameterValue<Guid>(nameof(CounterId).ToLower()); }
            set { SetParameterValue(nameof(CounterId).ToLower(), value); }
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

        /// <summary>
        /// the account of the condition. Must be used with the domainId parameter.
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// the domain ID of the account.
        /// </summary>
        public Guid? DomainId {
            get { return GetParameterValue<Guid?>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// an optional project for condition
        /// </summary>
        public Guid? ProjectId {
            get { return GetParameterValue<Guid?>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Creates a condition for VM auto scaling
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse CreateCondition(CreateConditionRequest request);
        Task<AsyncJobResponse> CreateConditionAsync(CreateConditionRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse CreateCondition(CreateConditionRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> CreateConditionAsync(CreateConditionRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
