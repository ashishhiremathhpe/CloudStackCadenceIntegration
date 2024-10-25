using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateBackupOfferingRequest : APIRequest
    {
        public UpdateBackupOfferingRequest() : base("updateBackupOffering") {}

        /// <summary>
        /// The ID of the Backup Offering to be updated
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// Whether to allow user driven backups or not
        /// </summary>
        public bool? AllowUserDrivenBackups {
            get { return GetParameterValue<bool?>(nameof(AllowUserDrivenBackups).ToLower()); }
            set { SetParameterValue(nameof(AllowUserDrivenBackups).ToLower(), value); }
        }

        /// <summary>
        /// The description of the Backup Offering to be updated
        /// </summary>
        public string Description {
            get { return GetParameterValue<string>(nameof(Description).ToLower()); }
            set { SetParameterValue(nameof(Description).ToLower(), value); }
        }

        /// <summary>
        /// The name of the Backup Offering to be updated
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

    }
    /// <summary>
    /// Updates a backup offering.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        BackupOfferingResponse UpdateBackupOffering(UpdateBackupOfferingRequest request);
        Task<BackupOfferingResponse> UpdateBackupOfferingAsync(UpdateBackupOfferingRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public BackupOfferingResponse UpdateBackupOffering(UpdateBackupOfferingRequest request) => Proxy.Request<BackupOfferingResponse>(request);
        public Task<BackupOfferingResponse> UpdateBackupOfferingAsync(UpdateBackupOfferingRequest request) => Proxy.RequestAsync<BackupOfferingResponse>(request);
    }
}
