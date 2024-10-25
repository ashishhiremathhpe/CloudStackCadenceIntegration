using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateBackupScheduleRequest : APIRequest
    {
        public UpdateBackupScheduleRequest() : base("updateBackupSchedule") {}

        /// <summary>
        /// valid values are HOURLY, DAILY, WEEKLY, and MONTHLY
        /// </summary>
        public string IntervalType {
            get { return GetParameterValue<string>(nameof(IntervalType).ToLower()); }
            set { SetParameterValue(nameof(IntervalType).ToLower(), value); }
        }

        /// <summary>
        /// custom backup schedule, the format is:for HOURLY MM*, for DAILY MM:HH*, for WEEKLY MM:HH:DD (1-7)*, for MONTHLY MM:HH:DD (1-28)
        /// </summary>
        public string Schedule {
            get { return GetParameterValue<string>(nameof(Schedule).ToLower()); }
            set { SetParameterValue(nameof(Schedule).ToLower(), value); }
        }

        /// <summary>
        /// Specifies a timezone for this command. For more information on the timezone parameter, see TimeZone Format.
        /// </summary>
        public string Timezone {
            get { return GetParameterValue<string>(nameof(Timezone).ToLower()); }
            set { SetParameterValue(nameof(Timezone).ToLower(), value); }
        }

        /// <summary>
        /// ID of the VM for which schedule is to be defined
        /// </summary>
        public Guid Virtualmachineid {
            get { return GetParameterValue<Guid>(nameof(Virtualmachineid).ToLower()); }
            set { SetParameterValue(nameof(Virtualmachineid).ToLower(), value); }
        }

    }
    /// <summary>
    /// Updates a user-defined VM backup schedule
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        BackupResponse UpdateBackupSchedule(UpdateBackupScheduleRequest request);
        Task<BackupResponse> UpdateBackupScheduleAsync(UpdateBackupScheduleRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public BackupResponse UpdateBackupSchedule(UpdateBackupScheduleRequest request) => Proxy.Request<BackupResponse>(request);
        public Task<BackupResponse> UpdateBackupScheduleAsync(UpdateBackupScheduleRequest request) => Proxy.RequestAsync<BackupResponse>(request);
    }
}
