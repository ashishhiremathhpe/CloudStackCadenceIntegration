using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListVmsForImportRequest : APIListRequest
    {
        public ListVmsForImportRequest() : base("listVmsForImport") {}

        /// <summary>
        /// the host name or IP address
        /// </summary>
        public string Host {
            get { return GetParameterValue<string>(nameof(Host).ToLower()); }
            set { SetParameterValue(nameof(Host).ToLower(), value); }
        }

        /// <summary>
        /// hypervisor type of the host
        /// </summary>
        public string Hypervisor {
            get { return GetParameterValue<string>(nameof(Hypervisor).ToLower()); }
            set { SetParameterValue(nameof(Hypervisor).ToLower(), value); }
        }

        /// <summary>
        /// the zone ID
        /// </summary>
        public Guid ZoneId {
            get { return GetParameterValue<Guid>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// the password for the host
        /// </summary>
        public string Password {
            get { return GetParameterValue<string>(nameof(Password).ToLower()); }
            set { SetParameterValue(nameof(Password).ToLower(), value); }
        }

        /// <summary>
        /// the username for the host
        /// </summary>
        public string Username {
            get { return GetParameterValue<string>(nameof(Username).ToLower()); }
            set { SetParameterValue(nameof(Username).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists virtual machines on a unmanaged host
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<UnmanagedInstanceResponse> ListVmsForImport(ListVmsForImportRequest request);
        Task<ListResponse<UnmanagedInstanceResponse>> ListVmsForImportAsync(ListVmsForImportRequest request);
        ListResponse<UnmanagedInstanceResponse> ListVmsForImportAllPages(ListVmsForImportRequest request);
        Task<ListResponse<UnmanagedInstanceResponse>> ListVmsForImportAllPagesAsync(ListVmsForImportRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<UnmanagedInstanceResponse> ListVmsForImport(ListVmsForImportRequest request) => Proxy.Request<ListResponse<UnmanagedInstanceResponse>>(request);
        public Task<ListResponse<UnmanagedInstanceResponse>> ListVmsForImportAsync(ListVmsForImportRequest request) => Proxy.RequestAsync<ListResponse<UnmanagedInstanceResponse>>(request);
        public ListResponse<UnmanagedInstanceResponse> ListVmsForImportAllPages(ListVmsForImportRequest request) => Proxy.RequestAllPages<UnmanagedInstanceResponse>(request);
        public Task<ListResponse<UnmanagedInstanceResponse>> ListVmsForImportAllPagesAsync(ListVmsForImportRequest request) => Proxy.RequestAllPagesAsync<UnmanagedInstanceResponse>(request);
    }
}
