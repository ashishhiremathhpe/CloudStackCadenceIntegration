using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateSecurityGroupRequest : APIRequest
    {
        public UpdateSecurityGroupRequest() : base("updateSecurityGroup") {}

        /// <summary>
        /// The ID of the security group.
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// an optional field, in case you want to set a custom id to the resource. Allowed to Root Admins only
        /// </summary>
        public string CustomId {
            get { return GetParameterValue<string>(nameof(CustomId).ToLower()); }
            set { SetParameterValue(nameof(CustomId).ToLower(), value); }
        }

        /// <summary>
        /// The new name of the security group.
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

    }
    /// <summary>
    /// Updates a security group
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SecurityGroupResponse UpdateSecurityGroup(UpdateSecurityGroupRequest request);
        Task<SecurityGroupResponse> UpdateSecurityGroupAsync(UpdateSecurityGroupRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SecurityGroupResponse UpdateSecurityGroup(UpdateSecurityGroupRequest request) => Proxy.Request<SecurityGroupResponse>(request);
        public Task<SecurityGroupResponse> UpdateSecurityGroupAsync(UpdateSecurityGroupRequest request) => Proxy.RequestAsync<SecurityGroupResponse>(request);
    }
}
