using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateGuestOsRequest : APIRequest
    {
        public UpdateGuestOsRequest() : base("updateGuestOs") {}

        /// <summary>
        /// UUID of the Guest OS
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// Unique display name for Guest OS
        /// </summary>
        public string OsDisplayName {
            get { return GetParameterValue<string>(nameof(OsDisplayName).ToLower()); }
            set { SetParameterValue(nameof(OsDisplayName).ToLower(), value); }
        }

        /// <summary>
        /// Map of (key/value pairs)
        /// </summary>
        public IList<IDictionary<string, object>> Details {
            get { return GetList<IDictionary<string, object>>(nameof(Details).ToLower()); }
            set { SetParameterValue(nameof(Details).ToLower(), value); }
        }

        /// <summary>
        /// whether this guest OS is available for end users
        /// </summary>
        public bool? ForDisplay {
            get { return GetParameterValue<bool?>(nameof(ForDisplay).ToLower()); }
            set { SetParameterValue(nameof(ForDisplay).ToLower(), value); }
        }

    }
    /// <summary>
    /// Updates the information about Guest OS
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse UpdateGuestOs(UpdateGuestOsRequest request);
        Task<AsyncJobResponse> UpdateGuestOsAsync(UpdateGuestOsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse UpdateGuestOs(UpdateGuestOsRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> UpdateGuestOsAsync(UpdateGuestOsRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
