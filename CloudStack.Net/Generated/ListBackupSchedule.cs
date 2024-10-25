using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListBackupScheduleRequest : APIRequest
    {
        public ListBackupScheduleRequest() : base("listBackupSchedule") {}

        /// <summary>
        /// ID of the VM
        /// </summary>
        public Guid Virtualmachineid {
            get { return GetParameterValue<Guid>(nameof(Virtualmachineid).ToLower()); }
            set { SetParameterValue(nameof(Virtualmachineid).ToLower(), value); }
        }

    }
    /// <summary>
    /// List backup schedule of a VM
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        BackupScheduleResponse ListBackupSchedule(ListBackupScheduleRequest request);
        Task<BackupScheduleResponse> ListBackupScheduleAsync(ListBackupScheduleRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public BackupScheduleResponse ListBackupSchedule(ListBackupScheduleRequest request) => Proxy.Request<BackupScheduleResponse>(request);
        public Task<BackupScheduleResponse> ListBackupScheduleAsync(ListBackupScheduleRequest request) => Proxy.RequestAsync<BackupScheduleResponse>(request);
    }
}
