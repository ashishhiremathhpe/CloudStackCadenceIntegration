using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListVMScheduleRequest : APIListRequest
    {
        public ListVMScheduleRequest() : base("listVMSchedule") {}

        /// <summary>
        /// ID of the VM for which schedule is to be defined
        /// </summary>
        public Guid Virtualmachineid {
            get { return GetParameterValue<Guid>(nameof(Virtualmachineid).ToLower()); }
            set { SetParameterValue(nameof(Virtualmachineid).ToLower(), value); }
        }

        /// <summary>
        /// Action taken by schedule
        /// </summary>
        public string Action {
            get { return GetParameterValue<string>(nameof(Action).ToLower()); }
            set { SetParameterValue(nameof(Action).ToLower(), value); }
        }

        /// <summary>
        /// ID of VM schedule
        /// </summary>
        public bool? Enabled {
            get { return GetParameterValue<bool?>(nameof(Enabled).ToLower()); }
            set { SetParameterValue(nameof(Enabled).ToLower(), value); }
        }

        /// <summary>
        /// ID of VM schedule
        /// </summary>
        public Guid? Id {
            get { return GetParameterValue<Guid?>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

    }
    /// <summary>
    /// List VM Schedules.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<VMScheduleResponse> ListVMSchedule(ListVMScheduleRequest request);
        Task<ListResponse<VMScheduleResponse>> ListVMScheduleAsync(ListVMScheduleRequest request);
        ListResponse<VMScheduleResponse> ListVMScheduleAllPages(ListVMScheduleRequest request);
        Task<ListResponse<VMScheduleResponse>> ListVMScheduleAllPagesAsync(ListVMScheduleRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<VMScheduleResponse> ListVMSchedule(ListVMScheduleRequest request) => Proxy.Request<ListResponse<VMScheduleResponse>>(request);
        public Task<ListResponse<VMScheduleResponse>> ListVMScheduleAsync(ListVMScheduleRequest request) => Proxy.RequestAsync<ListResponse<VMScheduleResponse>>(request);
        public ListResponse<VMScheduleResponse> ListVMScheduleAllPages(ListVMScheduleRequest request) => Proxy.RequestAllPages<VMScheduleResponse>(request);
        public Task<ListResponse<VMScheduleResponse>> ListVMScheduleAllPagesAsync(ListVMScheduleRequest request) => Proxy.RequestAllPagesAsync<VMScheduleResponse>(request);
    }
}
