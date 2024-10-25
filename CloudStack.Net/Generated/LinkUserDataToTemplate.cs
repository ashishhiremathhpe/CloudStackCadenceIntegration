using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class LinkUserDataToTemplateRequest : APIRequest
    {
        public LinkUserDataToTemplateRequest() : base("linkUserDataToTemplate") {}

        /// <summary>
        /// the ID of the ISO for the virtual machine
        /// </summary>
        public Guid? IsoId {
            get { return GetParameterValue<Guid?>(nameof(IsoId).ToLower()); }
            set { SetParameterValue(nameof(IsoId).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the template for the virtual machine
        /// </summary>
        public Guid? TemplateId {
            get { return GetParameterValue<Guid?>(nameof(TemplateId).ToLower()); }
            set { SetParameterValue(nameof(TemplateId).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the userdata that has to be linked to template/ISO. If not provided existing userdata will be unlinked from the template/ISO
        /// </summary>
        public Guid? UserdataId {
            get { return GetParameterValue<Guid?>(nameof(UserdataId).ToLower()); }
            set { SetParameterValue(nameof(UserdataId).ToLower(), value); }
        }

        /// <summary>
        /// an optional override policy of the userdata. Possible values are - ALLOWOVERRIDE, APPEND, DENYOVERRIDE. Default policy is allowoverride
        /// </summary>
        public string UserdataPolicy {
            get { return GetParameterValue<string>(nameof(UserdataPolicy).ToLower()); }
            set { SetParameterValue(nameof(UserdataPolicy).ToLower(), value); }
        }

    }
    /// <summary>
    /// Link or unlink a userdata to a template.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        TemplateResponse LinkUserDataToTemplate(LinkUserDataToTemplateRequest request);
        Task<TemplateResponse> LinkUserDataToTemplateAsync(LinkUserDataToTemplateRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public TemplateResponse LinkUserDataToTemplate(LinkUserDataToTemplateRequest request) => Proxy.Request<TemplateResponse>(request);
        public Task<TemplateResponse> LinkUserDataToTemplateAsync(LinkUserDataToTemplateRequest request) => Proxy.RequestAsync<TemplateResponse>(request);
    }
}
