using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateVMScheduleRequest : APIRequest
    {
        public UpdateVMScheduleRequest() : base("updateVMSchedule") {}

        /// <summary>
        /// ID of VM schedule
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// Name of the schedule
        /// </summary>
        public string Description {
            get { return GetParameterValue<string>(nameof(Description).ToLower()); }
            set { SetParameterValue(nameof(Description).ToLower(), value); }
        }

        /// <summary>
        /// Enable VM schedule
        /// </summary>
        public bool? Enabled {
            get { return GetParameterValue<bool?>(nameof(Enabled).ToLower()); }
            set { SetParameterValue(nameof(Enabled).ToLower(), value); }
        }

        /// <summary>
        /// end date after which the schedule becomes inactiveUse format "yyyy-MM-dd hh:mm:ss")
        /// </summary>
        public DateTime? EndDate {
            get { return GetParameterValue<DateTime?>(nameof(EndDate).ToLower()); }
            set { SetParameterValue(nameof(EndDate).ToLower(), value); }
        }

        /// <summary>
        /// Schedule for action on VM in cron format. e.g. '0 15 10 * *' for 'at 15:00 on 10th day of every month'
        /// </summary>
        public string Schedule {
            get { return GetParameterValue<string>(nameof(Schedule).ToLower()); }
            set { SetParameterValue(nameof(Schedule).ToLower(), value); }
        }

        /// <summary>
        /// start date from which the schedule becomes activeUse format "yyyy-MM-dd hh:mm:ss")
        /// </summary>
        public DateTime? StartDate {
            get { return GetParameterValue<DateTime?>(nameof(StartDate).ToLower()); }
            set { SetParameterValue(nameof(StartDate).ToLower(), value); }
        }

        /// <summary>
        /// Specifies a timezone for this command. For more information on the timezone parameter, see TimeZone Format.
        /// </summary>
        public string TimeZone {
            get { return GetParameterValue<string>(nameof(TimeZone).ToLower()); }
            set { SetParameterValue(nameof(TimeZone).ToLower(), value); }
        }

    }
    /// <summary>
    /// Update VM Schedule.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        VMScheduleResponse UpdateVMSchedule(UpdateVMScheduleRequest request);
        Task<VMScheduleResponse> UpdateVMScheduleAsync(UpdateVMScheduleRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public VMScheduleResponse UpdateVMSchedule(UpdateVMScheduleRequest request) => Proxy.Request<VMScheduleResponse>(request);
        public Task<VMScheduleResponse> UpdateVMScheduleAsync(UpdateVMScheduleRequest request) => Proxy.RequestAsync<VMScheduleResponse>(request);
    }
}
