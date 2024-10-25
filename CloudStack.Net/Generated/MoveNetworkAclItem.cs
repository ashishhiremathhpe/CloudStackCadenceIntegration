using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class MoveNetworkAclItemRequest : APIRequest
    {
        public MoveNetworkAclItemRequest() : base("moveNetworkAclItem") {}

        /// <summary>
        /// The ID of the network ACL rule that is being moved to a new position.
        /// </summary>
        public string Id {
            get { return GetParameterValue<string>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// Md5 hash used to check the consistency of the ACL rule list before applying the ACL rule move. This check is useful to manage concurrency problems that may happen when multiple users are editing the same ACL rule listing. The parameter is not required. Therefore, if the user does not send it, they assume the risk of moving ACL rules without checking the consistency of the access control list before executing the move. We use MD5 hash function on a String that is composed of all UUIDs of the ACL rules in concatenated in their respective order (order defined via 'number' field).
        /// </summary>
        public string AclConsistencyHash {
            get { return GetParameterValue<string>(nameof(AclConsistencyHash).ToLower()); }
            set { SetParameterValue(nameof(AclConsistencyHash).ToLower(), value); }
        }

        /// <summary>
        /// an optional field, in case you want to set a custom id to the resource. Allowed to Root Admins only
        /// </summary>
        public string CustomId {
            get { return GetParameterValue<string>(nameof(CustomId).ToLower()); }
            set { SetParameterValue(nameof(CustomId).ToLower(), value); }
        }

        /// <summary>
        /// The ID of the rule that is right after the new position where the rule being moved is going to be placed. This value can be 'NULL' if the rule is being moved to the last position of the network ACL list.
        /// </summary>
        public string Nextaclruleid {
            get { return GetParameterValue<string>(nameof(Nextaclruleid).ToLower()); }
            set { SetParameterValue(nameof(Nextaclruleid).ToLower(), value); }
        }

        /// <summary>
        /// The ID of the first rule that is right before the new position where the rule being moved is going to be placed. This value can be 'NULL' if the rule is being moved to the first position of the network ACL list.
        /// </summary>
        public string Previousaclruleid {
            get { return GetParameterValue<string>(nameof(Previousaclruleid).ToLower()); }
            set { SetParameterValue(nameof(Previousaclruleid).ToLower(), value); }
        }

    }
    /// <summary>
    /// Move an ACL rule to a position bettwen two other ACL rules of the same ACL network list
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse MoveNetworkAclItem(MoveNetworkAclItemRequest request);
        Task<AsyncJobResponse> MoveNetworkAclItemAsync(MoveNetworkAclItemRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse MoveNetworkAclItem(MoveNetworkAclItemRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> MoveNetworkAclItemAsync(MoveNetworkAclItemRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
