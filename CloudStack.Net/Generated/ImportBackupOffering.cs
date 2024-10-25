using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ImportBackupOfferingRequest : APIRequest
    {
        public ImportBackupOfferingRequest() : base("importBackupOffering") {}

        /// <summary>
        /// Whether users are allowed to create adhoc backups and backup schedules
        /// </summary>
        public bool Allowuserdrivenbackups {
            get { return GetParameterValue<bool>(nameof(Allowuserdrivenbackups).ToLower()); }
            set { SetParameterValue(nameof(Allowuserdrivenbackups).ToLower(), value); }
        }

        /// <summary>
        /// the description of the backup offering
        /// </summary>
        public string Description {
            get { return GetParameterValue<string>(nameof(Description).ToLower()); }
            set { SetParameterValue(nameof(Description).ToLower(), value); }
        }

        /// <summary>
        /// The backup offering ID (from backup provider side)
        /// </summary>
        public string ExternalId {
            get { return GetParameterValue<string>(nameof(ExternalId).ToLower()); }
            set { SetParameterValue(nameof(ExternalId).ToLower(), value); }
        }

        /// <summary>
        /// the name of the backup offering
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// The zone ID
        /// </summary>
        public Guid ZoneId {
            get { return GetParameterValue<Guid>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Imports a backup offering using a backup provider
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse ImportBackupOffering(ImportBackupOfferingRequest request);
        Task<AsyncJobResponse> ImportBackupOfferingAsync(ImportBackupOfferingRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse ImportBackupOffering(ImportBackupOfferingRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> ImportBackupOfferingAsync(ImportBackupOfferingRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
