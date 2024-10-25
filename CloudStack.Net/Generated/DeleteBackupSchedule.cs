using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteBackupScheduleRequest : APIRequest
    {
        public DeleteBackupScheduleRequest() : base("deleteBackupSchedule") {}

        /// <summary>
        /// ID of the VM
        /// </summary>
        public Guid Virtualmachineid {
            get { return GetParameterValue<Guid>(nameof(Virtualmachineid).ToLower()); }
            set { SetParameterValue(nameof(Virtualmachineid).ToLower(), value); }
        }

    }
    /// <summary>
    /// Deletes the backup schedule of a VM
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteBackupSchedule(DeleteBackupScheduleRequest request);
        Task<SuccessResponse> DeleteBackupScheduleAsync(DeleteBackupScheduleRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteBackupSchedule(DeleteBackupScheduleRequest request) => Proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> DeleteBackupScheduleAsync(DeleteBackupScheduleRequest request) => Proxy.RequestAsync<SuccessResponse>(request);
    }
}
