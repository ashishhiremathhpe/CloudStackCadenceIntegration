using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteBackupOfferingRequest : APIRequest
    {
        public DeleteBackupOfferingRequest() : base("deleteBackupOffering") {}

        /// <summary>
        /// ID of the backup offering
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Deletes a backup offering
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteBackupOffering(DeleteBackupOfferingRequest request);
        Task<SuccessResponse> DeleteBackupOfferingAsync(DeleteBackupOfferingRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteBackupOffering(DeleteBackupOfferingRequest request) => Proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> DeleteBackupOfferingAsync(DeleteBackupOfferingRequest request) => Proxy.RequestAsync<SuccessResponse>(request);
    }
}
