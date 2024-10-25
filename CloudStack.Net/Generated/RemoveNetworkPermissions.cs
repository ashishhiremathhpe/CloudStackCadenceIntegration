using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class RemoveNetworkPermissionsRequest : APIRequest
    {
        public RemoveNetworkPermissionsRequest() : base("removeNetworkPermissions") {}

        /// <summary>
        /// the network ID
        /// </summary>
        public Guid NetworkId {
            get { return GetParameterValue<Guid>(nameof(NetworkId).ToLower()); }
            set { SetParameterValue(nameof(NetworkId).ToLower(), value); }
        }

        /// <summary>
        /// a comma delimited list of account IDs within owner's domain. If specified, "op" parameter has to be passed in.
        /// </summary>
        public IList<Guid> AccountIds {
            get { return GetList<Guid>(nameof(AccountIds).ToLower()); }
            set { SetParameterValue(nameof(AccountIds).ToLower(), value); }
        }

        /// <summary>
        /// a comma delimited list of accounts within owner's domain. If specified, "op" parameter has to be passed in.
        /// </summary>
        public IList<string> Accounts {
            get { return GetList<string>(nameof(Accounts).ToLower()); }
            set { SetParameterValue(nameof(Accounts).ToLower(), value); }
        }

        /// <summary>
        /// a comma delimited list of projects within owner's domain. If specified, "op" parameter has to be passed in.
        /// </summary>
        public IList<Guid> ProjectIds {
            get { return GetList<Guid>(nameof(ProjectIds).ToLower()); }
            set { SetParameterValue(nameof(ProjectIds).ToLower(), value); }
        }

    }
    /// <summary>
    /// Removes network permissions.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse RemoveNetworkPermissions(RemoveNetworkPermissionsRequest request);
        Task<SuccessResponse> RemoveNetworkPermissionsAsync(RemoveNetworkPermissionsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse RemoveNetworkPermissions(RemoveNetworkPermissionsRequest request) => Proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> RemoveNetworkPermissionsAsync(RemoveNetworkPermissionsRequest request) => Proxy.RequestAsync<SuccessResponse>(request);
    }
}
