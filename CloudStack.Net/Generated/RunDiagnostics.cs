using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class RunDiagnosticsRequest : APIRequest
    {
        public RunDiagnosticsRequest() : base("runDiagnostics") {}

        /// <summary>
        /// The IP/Domain address to test connection to
        /// </summary>
        public string Ipaddress {
            get { return GetParameterValue<string>(nameof(Ipaddress).ToLower()); }
            set { SetParameterValue(nameof(Ipaddress).ToLower(), value); }
        }

        /// <summary>
        /// The ID of the system VM instance to diagnose
        /// </summary>
        public Guid Targetid {
            get { return GetParameterValue<Guid>(nameof(Targetid).ToLower()); }
            set { SetParameterValue(nameof(Targetid).ToLower(), value); }
        }

        /// <summary>
        /// The system VM diagnostics type  valid options are: ping, traceroute, arping
        /// </summary>
        public string Type {
            get { return GetParameterValue<string>(nameof(Type).ToLower()); }
            set { SetParameterValue(nameof(Type).ToLower(), value); }
        }

        /// <summary>
        /// Additional command line options that apply for each command
        /// </summary>
        public string Params {
            get { return GetParameterValue<string>(nameof(Params).ToLower()); }
            set { SetParameterValue(nameof(Params).ToLower(), value); }
        }

    }
    /// <summary>
    /// Execute network-utility command (ping/arping/tracert) on system VMs remotely
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse RunDiagnostics(RunDiagnosticsRequest request);
        Task<AsyncJobResponse> RunDiagnosticsAsync(RunDiagnosticsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse RunDiagnostics(RunDiagnosticsRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> RunDiagnosticsAsync(RunDiagnosticsRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
