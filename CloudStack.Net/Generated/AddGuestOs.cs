using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AddGuestOsRequest : APIRequest
    {
        public AddGuestOsRequest() : base("addGuestOs") {}

        /// <summary>
        /// ID of Guest OS category
        /// </summary>
        public Guid OsCategoryId {
            get { return GetParameterValue<Guid>(nameof(OsCategoryId).ToLower()); }
            set { SetParameterValue(nameof(OsCategoryId).ToLower(), value); }
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

        /// <summary>
        /// Optional name for Guest OS
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

    }
    /// <summary>
    /// Add a new guest OS type
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse AddGuestOs(AddGuestOsRequest request);
        Task<AsyncJobResponse> AddGuestOsAsync(AddGuestOsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse AddGuestOs(AddGuestOsRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> AddGuestOsAsync(AddGuestOsRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
