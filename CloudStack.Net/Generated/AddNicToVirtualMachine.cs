using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AddNicToVirtualMachineRequest : APIRequest
    {
        public AddNicToVirtualMachineRequest() : base("addNicToVirtualMachine") {}

        /// <summary>
        /// Network ID
        /// </summary>
        public Guid Networkid {
            get { return GetParameterValue<Guid>(nameof(Networkid).ToLower()); }
            set { SetParameterValue(nameof(Networkid).ToLower(), value); }
        }

        /// <summary>
        /// Virtual Machine ID
        /// </summary>
        public Guid Virtualmachineid {
            get { return GetParameterValue<Guid>(nameof(Virtualmachineid).ToLower()); }
            set { SetParameterValue(nameof(Virtualmachineid).ToLower(), value); }
        }

        /// <summary>
        /// DHCP options which are passed to the nic Example: dhcpoptions[0].dhcp:114=url&dhcpoptions[0].dhcp:66=www.test.com
        /// </summary>
        public IList<IDictionary<string, object>> DhcpOptions {
            get { return GetList<IDictionary<string, object>>(nameof(DhcpOptions).ToLower()); }
            set { SetParameterValue(nameof(DhcpOptions).ToLower(), value); }
        }

        /// <summary>
        /// IP Address for the new network
        /// </summary>
        public string Ipaddress {
            get { return GetParameterValue<string>(nameof(Ipaddress).ToLower()); }
            set { SetParameterValue(nameof(Ipaddress).ToLower(), value); }
        }

        /// <summary>
        /// Mac Address for the new network
        /// </summary>
        public string Macaddress {
            get { return GetParameterValue<string>(nameof(Macaddress).ToLower()); }
            set { SetParameterValue(nameof(Macaddress).ToLower(), value); }
        }

    }
    /// <summary>
    /// Adds VM to specified network by creating a NIC
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse AddNicToVirtualMachine(AddNicToVirtualMachineRequest request);
        Task<AsyncJobResponse> AddNicToVirtualMachineAsync(AddNicToVirtualMachineRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse AddNicToVirtualMachine(AddNicToVirtualMachineRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> AddNicToVirtualMachineAsync(AddNicToVirtualMachineRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
