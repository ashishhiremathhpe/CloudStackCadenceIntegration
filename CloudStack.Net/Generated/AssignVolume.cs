using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AssignVolumeRequest : APIRequest
    {
        public AssignVolumeRequest() : base("assignVolume") {}

        /// <summary>
        /// The ID of the volume to be reassigned.
        /// </summary>
        public Guid VolumeId {
            get { return GetParameterValue<Guid>(nameof(VolumeId).ToLower()); }
            set { SetParameterValue(nameof(VolumeId).ToLower(), value); }
        }

        /// <summary>
        /// The ID of the account to which the volume will be assigned. Mutually exclusive with parameter 'projectid'.
        /// </summary>
        public Guid? AccountId {
            get { return GetParameterValue<Guid?>(nameof(AccountId).ToLower()); }
            set { SetParameterValue(nameof(AccountId).ToLower(), value); }
        }

        /// <summary>
        /// The ID of the project to which the volume will be assigned. Mutually exclusive with 'accountid'.
        /// </summary>
        public Guid? Projectid {
            get { return GetParameterValue<Guid?>(nameof(Projectid).ToLower()); }
            set { SetParameterValue(nameof(Projectid).ToLower(), value); }
        }

    }
    /// <summary>
    /// Changes ownership of a Volume from one account to another.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        VolumeResponse AssignVolume(AssignVolumeRequest request);
        Task<VolumeResponse> AssignVolumeAsync(AssignVolumeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public VolumeResponse AssignVolume(AssignVolumeRequest request) => Proxy.Request<VolumeResponse>(request);
        public Task<VolumeResponse> AssignVolumeAsync(AssignVolumeRequest request) => Proxy.RequestAsync<VolumeResponse>(request);
    }
}
