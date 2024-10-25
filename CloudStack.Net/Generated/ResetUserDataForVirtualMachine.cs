using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ResetUserDataForVirtualMachineRequest : APIRequest
    {
        public ResetUserDataForVirtualMachineRequest() : base("resetUserDataForVirtualMachine") {}

        /// <summary>
        /// The ID of the virtual machine
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// an optional account for the virtual machine. Must be used with domainId.
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// an optional domainId for the virtual machine. If the account parameter is used, domainId must also be used.
        /// </summary>
        public Guid? DomainId {
            get { return GetParameterValue<Guid?>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// an optional project for the virtual machine
        /// </summary>
        public Guid? ProjectId {
            get { return GetParameterValue<Guid?>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
        }

        /// <summary>
        /// an optional binary data that can be sent to the virtual machine upon a successful deployment. This binary data must be base64 encoded before adding it to the request. Using HTTP GET (via querystring), you can send up to 4KB of data after base64 encoding. Using HTTP POST(via POST body), you can send up to 1MB of data after base64 encoding.You also need to change vm.userdata.max.length value
        /// </summary>
        public string UserData {
            get { return GetParameterValue<string>(nameof(UserData).ToLower()); }
            set { SetParameterValue(nameof(UserData).ToLower(), value); }
        }

        /// <summary>
        /// used to specify the parameters values for the variables in userdata.
        /// </summary>
        public IList<IDictionary<string, object>> UserdataDetails {
            get { return GetList<IDictionary<string, object>>(nameof(UserdataDetails).ToLower()); }
            set { SetParameterValue(nameof(UserdataDetails).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the userdata
        /// </summary>
        public Guid? UserdataId {
            get { return GetParameterValue<Guid?>(nameof(UserdataId).ToLower()); }
            set { SetParameterValue(nameof(UserdataId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Resets the UserData for virtual machine. The virtual machine must be in a "Stopped" state. [async]
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        UserVmResponse ResetUserDataForVirtualMachine(ResetUserDataForVirtualMachineRequest request);
        Task<UserVmResponse> ResetUserDataForVirtualMachineAsync(ResetUserDataForVirtualMachineRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public UserVmResponse ResetUserDataForVirtualMachine(ResetUserDataForVirtualMachineRequest request) => Proxy.Request<UserVmResponse>(request);
        public Task<UserVmResponse> ResetUserDataForVirtualMachineAsync(ResetUserDataForVirtualMachineRequest request) => Proxy.RequestAsync<UserVmResponse>(request);
    }
}
