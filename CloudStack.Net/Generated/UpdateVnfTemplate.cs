using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateVnfTemplateRequest : APIRequest
    {
        public UpdateVnfTemplateRequest() : base("updateVnfTemplate") {}

        /// <summary>
        /// the ID of the image file
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// true if image is bootable, false otherwise; available only for updateIso API
        /// </summary>
        public bool? Bootable {
            get { return GetParameterValue<bool?>(nameof(Bootable).ToLower()); }
            set { SetParameterValue(nameof(Bootable).ToLower(), value); }
        }

        /// <summary>
        /// optional boolean field, which indicates if details should be cleaned up or not (if set to true, details removed for this resource, details field ignored; if false or not set, no action)
        /// </summary>
        public bool? CleanupDetails {
            get { return GetParameterValue<bool?>(nameof(CleanupDetails).ToLower()); }
            set { SetParameterValue(nameof(CleanupDetails).ToLower(), value); }
        }

        /// <summary>
        /// optional boolean field, which indicates if VNF details will be cleaned up or not
        /// </summary>
        public bool? CleanupVnfDetails {
            get { return GetParameterValue<bool?>(nameof(CleanupVnfDetails).ToLower()); }
            set { SetParameterValue(nameof(CleanupVnfDetails).ToLower(), value); }
        }

        /// <summary>
        /// optional boolean field, which indicates if VNF nics will be cleaned up or not
        /// </summary>
        public bool? CleanupVnfNics {
            get { return GetParameterValue<bool?>(nameof(CleanupVnfNics).ToLower()); }
            set { SetParameterValue(nameof(CleanupVnfNics).ToLower(), value); }
        }

        /// <summary>
        /// Details in key/value pairs using format details[i].keyname=keyvalue. Example: details[0].hypervisortoolsversion=xenserver61
        /// </summary>
        public IList<IDictionary<string, object>> Details {
            get { return GetList<IDictionary<string, object>>(nameof(Details).ToLower()); }
            set { SetParameterValue(nameof(Details).ToLower(), value); }
        }

        /// <summary>
        /// the display text of the image
        /// </summary>
        public string DisplayText {
            get { return GetParameterValue<string>(nameof(DisplayText).ToLower()); }
            set { SetParameterValue(nameof(DisplayText).ToLower(), value); }
        }

        /// <summary>
        /// the format for the image
        /// </summary>
        public string Format {
            get { return GetParameterValue<string>(nameof(Format).ToLower()); }
            set { SetParameterValue(nameof(Format).ToLower(), value); }
        }

        /// <summary>
        /// true if template/ISO contains XS/VMWare tools inorder to support dynamic scaling of VM cpu/memory
        /// </summary>
        public bool? IsDynamicallyScalable {
            get { return GetParameterValue<bool?>(nameof(IsDynamicallyScalable).ToLower()); }
            set { SetParameterValue(nameof(IsDynamicallyScalable).ToLower(), value); }
        }

        /// <summary>
        /// true if the template type is routing i.e., if template is used to deploy router
        /// </summary>
        public bool? Isrouting {
            get { return GetParameterValue<bool?>(nameof(Isrouting).ToLower()); }
            set { SetParameterValue(nameof(Isrouting).ToLower(), value); }
        }

        /// <summary>
        /// the name of the image file
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the OS type that best represents the OS of this image.
        /// </summary>
        public Guid? OsTypeId {
            get { return GetParameterValue<Guid?>(nameof(OsTypeId).ToLower()); }
            set { SetParameterValue(nameof(OsTypeId).ToLower(), value); }
        }

        /// <summary>
        /// true if the image supports the password reset feature; default is false
        /// </summary>
        public bool? PasswordEnabled {
            get { return GetParameterValue<bool?>(nameof(PasswordEnabled).ToLower()); }
            set { SetParameterValue(nameof(PasswordEnabled).ToLower(), value); }
        }

        /// <summary>
        /// true if the template requires HVM, false otherwise; available only for updateTemplate API
        /// </summary>
        public bool? RequiresHvm {
            get { return GetParameterValue<bool?>(nameof(RequiresHvm).ToLower()); }
            set { SetParameterValue(nameof(RequiresHvm).ToLower(), value); }
        }

        /// <summary>
        /// sort key of the template, integer
        /// </summary>
        public int? SortKey {
            get { return GetParameterValue<int?>(nameof(SortKey).ToLower()); }
            set { SetParameterValue(nameof(SortKey).ToLower(), value); }
        }

        /// <summary>
        /// true if the template supports the sshkey upload feature; default is false
        /// </summary>
        public bool? SshKeyEnabled {
            get { return GetParameterValue<bool?>(nameof(SshKeyEnabled).ToLower()); }
            set { SetParameterValue(nameof(SshKeyEnabled).ToLower(), value); }
        }

        /// <summary>
        /// the type of the template. Valid options are: USER/VNF (for all users) and SYSTEM/ROUTING/BUILTIN (for admins only).
        /// </summary>
        public string TemplateType {
            get { return GetParameterValue<string>(nameof(TemplateType).ToLower()); }
            set { SetParameterValue(nameof(TemplateType).ToLower(), value); }
        }

        /// <summary>
        /// VNF details in key/value pairs using format vnfdetails[i].keyname=keyvalue. Example: vnfdetails[0].vendor=xxx&&vnfdetails[0].version=2.0
        /// </summary>
        public IList<IDictionary<string, object>> VnfDetails {
            get { return GetList<IDictionary<string, object>>(nameof(VnfDetails).ToLower()); }
            set { SetParameterValue(nameof(VnfDetails).ToLower(), value); }
        }

        /// <summary>
        /// VNF nics in key/value pairs using format vnfnics[i].keyname=keyvalue.  Example: vnfnics[0].deviceid=0&&vnfnics[0].name=FirstNIC&&vnfnics[0].required=true&&vnfnics[1].deviceid=1&&vnfnics[1].name=SecondNIC
        /// </summary>
        public IList<IDictionary<string, object>> VnfNics {
            get { return GetList<IDictionary<string, object>>(nameof(VnfNics).ToLower()); }
            set { SetParameterValue(nameof(VnfNics).ToLower(), value); }
        }

    }
    /// <summary>
    /// Updates a template to VNF template or attributes of a VNF template.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        TemplateResponse UpdateVnfTemplate(UpdateVnfTemplateRequest request);
        Task<TemplateResponse> UpdateVnfTemplateAsync(UpdateVnfTemplateRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public TemplateResponse UpdateVnfTemplate(UpdateVnfTemplateRequest request) => Proxy.Request<TemplateResponse>(request);
        public Task<TemplateResponse> UpdateVnfTemplateAsync(UpdateVnfTemplateRequest request) => Proxy.RequestAsync<TemplateResponse>(request);
    }
}
