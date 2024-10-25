using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteVnfTemplateRequest : APIRequest
    {
        public DeleteVnfTemplateRequest() : base("deleteVnfTemplate") {}

        /// <summary>
        /// the ID of the template
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// Force delete a template.
        /// </summary>
        public bool? Forced {
            get { return GetParameterValue<bool?>(nameof(Forced).ToLower()); }
            set { SetParameterValue(nameof(Forced).ToLower(), value); }
        }

        /// <summary>
        /// the ID of zone of the template
        /// </summary>
        public Guid? ZoneId {
            get { return GetParameterValue<Guid?>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Deletes a VNF template from the system. All virtual machines using the deleted template will not be affected.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeleteVnfTemplate(DeleteVnfTemplateRequest request);
        Task<AsyncJobResponse> DeleteVnfTemplateAsync(DeleteVnfTemplateRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteVnfTemplate(DeleteVnfTemplateRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DeleteVnfTemplateAsync(DeleteVnfTemplateRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
