using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class GetDiagnosticsDataRequest : APIRequest
    {
        public GetDiagnosticsDataRequest() : base("getDiagnosticsData") {}

        /// <summary>
        /// The ID of the system VM instance to retrieve diagnostics data files from
        /// </summary>
        public Guid Targetid {
            get { return GetParameterValue<Guid>(nameof(Targetid).ToLower()); }
            set { SetParameterValue(nameof(Targetid).ToLower(), value); }
        }

        /// <summary>
        /// A comma separated list of diagnostics data files to be retrieved. Defaults are taken from global settings if none has been provided.
        /// </summary>
        public IList<string> Files {
            get { return GetList<string>(nameof(Files).ToLower()); }
            set { SetParameterValue(nameof(Files).ToLower(), value); }
        }

    }
    /// <summary>
    /// Get diagnostics and files from system VMs
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse GetDiagnosticsData(GetDiagnosticsDataRequest request);
        Task<AsyncJobResponse> GetDiagnosticsDataAsync(GetDiagnosticsDataRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse GetDiagnosticsData(GetDiagnosticsDataRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> GetDiagnosticsDataAsync(GetDiagnosticsDataRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
