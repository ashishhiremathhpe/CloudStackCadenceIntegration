using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ReserveIpAddressRequest : APIRequest
    {
        public ReserveIpAddressRequest() : base("reserveIpAddress") {}

        /// <summary>
        /// the ID of the public IP address to reserve
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// the account to reserve with this IP address
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the domain to reserve with this IP address
        /// </summary>
        public Guid? DomainId {
            get { return GetParameterValue<Guid?>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// an optional field, whether to the display the IP to the end user or not
        /// </summary>
        public bool? Fordisplay {
            get { return GetParameterValue<bool?>(nameof(Fordisplay).ToLower()); }
            set { SetParameterValue(nameof(Fordisplay).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the project to reserve with this IP address
        /// </summary>
        public Guid? ProjectId {
            get { return GetParameterValue<Guid?>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Reserve a public IP to an account.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        IPAddressResponse ReserveIpAddress(ReserveIpAddressRequest request);
        Task<IPAddressResponse> ReserveIpAddressAsync(ReserveIpAddressRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public IPAddressResponse ReserveIpAddress(ReserveIpAddressRequest request) => Proxy.Request<IPAddressResponse>(request);
        public Task<IPAddressResponse> ReserveIpAddressAsync(ReserveIpAddressRequest request) => Proxy.RequestAsync<IPAddressResponse>(request);
    }
}
