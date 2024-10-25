using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteVMScheduleRequest : APIRequest
    {
        public DeleteVMScheduleRequest() : base("deleteVMSchedule") {}

        /// <summary>
        /// ID of VM
        /// </summary>
        public Guid Virtualmachineid {
            get { return GetParameterValue<Guid>(nameof(Virtualmachineid).ToLower()); }
            set { SetParameterValue(nameof(Virtualmachineid).ToLower(), value); }
        }

        /// <summary>
        /// ID of VM schedule
        /// </summary>
        public Guid? Id {
            get { return GetParameterValue<Guid?>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// IDs of VM schedule
        /// </summary>
        public IList<Guid> Ids {
            get { return GetList<Guid>(nameof(Ids).ToLower()); }
            set { SetParameterValue(nameof(Ids).ToLower(), value); }
        }

    }
    /// <summary>
    /// Delete VM Schedule.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteVMSchedule(DeleteVMScheduleRequest request);
        Task<SuccessResponse> DeleteVMScheduleAsync(DeleteVMScheduleRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteVMSchedule(DeleteVMScheduleRequest request) => Proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> DeleteVMScheduleAsync(DeleteVMScheduleRequest request) => Proxy.RequestAsync<SuccessResponse>(request);
    }
}
