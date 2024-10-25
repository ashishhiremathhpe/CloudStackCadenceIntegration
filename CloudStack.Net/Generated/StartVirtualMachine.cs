using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class StartVirtualMachineRequest : APIRequest
    {
        public StartVirtualMachineRequest() : base("startVirtualMachine") {}

        /// <summary>
        /// The ID of the virtual machine
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// Boot into hardware setup menu or not
        /// </summary>
        public bool? BootIntoSetup {
            get { return GetParameterValue<bool?>(nameof(BootIntoSetup).ToLower()); }
            set { SetParameterValue(nameof(BootIntoSetup).ToLower(), value); }
        }

        /// <summary>
        /// destination Cluster ID to deploy the VM to - parameter available for root admin only
        /// </summary>
        public Guid? ClusterId {
            get { return GetParameterValue<Guid?>(nameof(ClusterId).ToLower()); }
            set { SetParameterValue(nameof(ClusterId).ToLower(), value); }
        }

        /// <summary>
        /// True by default, CloudStack will firstly try to start the VM on the last host where it run on before stopping, if destination host is not specified. If false, CloudStack will not consider the last host and start the VM by normal process.
        /// </summary>
        public bool? ConsiderLastHost {
            get { return GetParameterValue<bool?>(nameof(ConsiderLastHost).ToLower()); }
            set { SetParameterValue(nameof(ConsiderLastHost).ToLower(), value); }
        }

        /// <summary>
        /// Deployment planner to use for vm allocation. Available to ROOT admin only
        /// </summary>
        public string DeploymentPlanner {
            get { return GetParameterValue<string>(nameof(DeploymentPlanner).ToLower()); }
            set { SetParameterValue(nameof(DeploymentPlanner).ToLower(), value); }
        }

        /// <summary>
        /// destination Host ID to deploy the VM to - parameter available for root admin only
        /// </summary>
        public Guid? HostId {
            get { return GetParameterValue<Guid?>(nameof(HostId).ToLower()); }
            set { SetParameterValue(nameof(HostId).ToLower(), value); }
        }

        /// <summary>
        /// destination Pod ID to deploy the VM to - parameter available for root admin only
        /// </summary>
        public Guid? PodId {
            get { return GetParameterValue<Guid?>(nameof(PodId).ToLower()); }
            set { SetParameterValue(nameof(PodId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Starts a virtual machine.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse StartVirtualMachine(StartVirtualMachineRequest request);
        Task<AsyncJobResponse> StartVirtualMachineAsync(StartVirtualMachineRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse StartVirtualMachine(StartVirtualMachineRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> StartVirtualMachineAsync(StartVirtualMachineRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
