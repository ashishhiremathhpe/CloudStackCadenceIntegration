using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class GetUploadParamsForTemplateRequest : APIRequest
    {
        public GetUploadParamsForTemplateRequest() : base("getUploadParamsForTemplate") {}

        /// <summary>
        /// the format for the volume/template/iso. Possible values include QCOW2, OVA, and VHD.
        /// </summary>
        public string Format {
            get { return GetParameterValue<string>(nameof(Format).ToLower()); }
            set { SetParameterValue(nameof(Format).ToLower(), value); }
        }

        /// <summary>
        /// the target hypervisor for the template
        /// </summary>
        public string Hypervisor {
            get { return GetParameterValue<string>(nameof(Hypervisor).ToLower()); }
            set { SetParameterValue(nameof(Hypervisor).ToLower(), value); }
        }

        /// <summary>
        /// the name of the volume/template/iso
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the zone the volume/template/iso is to be hosted on
        /// </summary>
        public Guid ZoneId {
            get { return GetParameterValue<Guid>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

        /// <summary>
        /// an optional accountName. Must be used with domainId.
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// 32 or 64 bits support. 64 by default
        /// </summary>
        public int? Bits {
            get { return GetParameterValue<int?>(nameof(Bits).ToLower()); }
            set { SetParameterValue(nameof(Bits).ToLower(), value); }
        }

        /// <summary>
        /// the checksum value of this volume/template/iso The parameter containing the checksum will be considered a MD5sum if it is not prefixed
        ///  and just a plain ascii/utf8 representation of a hexadecimal string. If it is required to
        ///  use another algorithm the hexadecimal string is to be prefixed with a string of the form,
        ///  "{<algorithm>}", not including the double quotes. In this <algorithm> is the exact string
        ///  representing the java supported algorithm, i.e. MD5 or SHA-256. Note that java does not
        ///  contain an algorithm called SHA256 or one called sha-256, only SHA-256.
        /// </summary>
        public string Checksum {
            get { return GetParameterValue<string>(nameof(Checksum).ToLower()); }
            set { SetParameterValue(nameof(Checksum).ToLower(), value); }
        }

        /// <summary>
        /// (VMware only) true if VM deployments should preserve all the configurations defined for this template
        /// </summary>
        public bool? DeployAsIs {
            get { return GetParameterValue<bool?>(nameof(DeployAsIs).ToLower()); }
            set { SetParameterValue(nameof(DeployAsIs).ToLower(), value); }
        }

        /// <summary>
        /// Template details in key/value pairs.
        /// </summary>
        public IList<IDictionary<string, object>> Details {
            get { return GetList<IDictionary<string, object>>(nameof(Details).ToLower()); }
            set { SetParameterValue(nameof(Details).ToLower(), value); }
        }

        /// <summary>
        /// the display text of the template. This is usually used for display purposes.
        /// </summary>
        public string DisplayText {
            get { return GetParameterValue<string>(nameof(DisplayText).ToLower()); }
            set { SetParameterValue(nameof(DisplayText).ToLower(), value); }
        }

        /// <summary>
        /// an optional domainId. If the account parameter is used, domainId must also be used.
        /// </summary>
        public Guid? DomainId {
            get { return GetParameterValue<Guid?>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// true if template contains XS/VMWare tools inorder to support dynamic scaling of VM cpu/memory
        /// </summary>
        public bool? IsDynamicallyScalable {
            get { return GetParameterValue<bool?>(nameof(IsDynamicallyScalable).ToLower()); }
            set { SetParameterValue(nameof(IsDynamicallyScalable).ToLower(), value); }
        }

        /// <summary>
        /// true if the template or its derivatives are extractable; default is false
        /// </summary>
        public bool? Isextractable {
            get { return GetParameterValue<bool?>(nameof(Isextractable).ToLower()); }
            set { SetParameterValue(nameof(Isextractable).ToLower(), value); }
        }

        /// <summary>
        /// true if this template is a featured template, false otherwise
        /// </summary>
        public bool? Isfeatured {
            get { return GetParameterValue<bool?>(nameof(Isfeatured).ToLower()); }
            set { SetParameterValue(nameof(Isfeatured).ToLower(), value); }
        }

        /// <summary>
        /// true if the template is available to all accounts; default is true
        /// </summary>
        public bool? Ispublic {
            get { return GetParameterValue<bool?>(nameof(Ispublic).ToLower()); }
            set { SetParameterValue(nameof(Ispublic).ToLower(), value); }
        }

        /// <summary>
        /// true if the template type is routing i.e., if template is used to deploy router
        /// </summary>
        public bool? Isrouting {
            get { return GetParameterValue<bool?>(nameof(Isrouting).ToLower()); }
            set { SetParameterValue(nameof(Isrouting).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the OS Type that best represents the OS of this template. Not required for VMware as the guest OS is obtained from the OVF file.
        /// </summary>
        public Guid? OsTypeId {
            get { return GetParameterValue<Guid?>(nameof(OsTypeId).ToLower()); }
            set { SetParameterValue(nameof(OsTypeId).ToLower(), value); }
        }

        /// <summary>
        /// true if the template supports the password reset feature; default is false
        /// </summary>
        public bool? PasswordEnabled {
            get { return GetParameterValue<bool?>(nameof(PasswordEnabled).ToLower()); }
            set { SetParameterValue(nameof(PasswordEnabled).ToLower(), value); }
        }

        /// <summary>
        /// Upload volume/template/iso for the project
        /// </summary>
        public Guid? ProjectId {
            get { return GetParameterValue<Guid?>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
        }

        /// <summary>
        /// true if this template requires HVM
        /// </summary>
        public bool? RequiresHvm {
            get { return GetParameterValue<bool?>(nameof(RequiresHvm).ToLower()); }
            set { SetParameterValue(nameof(RequiresHvm).ToLower(), value); }
        }

        /// <summary>
        /// true if the template supports the sshkey upload feature; default is false
        /// </summary>
        public bool? SshKeyEnabled {
            get { return GetParameterValue<bool?>(nameof(SshKeyEnabled).ToLower()); }
            set { SetParameterValue(nameof(SshKeyEnabled).ToLower(), value); }
        }

        /// <summary>
        /// the tag for this template.
        /// </summary>
        public string TemplateTag {
            get { return GetParameterValue<string>(nameof(TemplateTag).ToLower()); }
            set { SetParameterValue(nameof(TemplateTag).ToLower(), value); }
        }

    }
    /// <summary>
    /// upload an existing template into the CloudStack cloud. 
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        GetUploadParamsResponse GetUploadParamsForTemplate(GetUploadParamsForTemplateRequest request);
        Task<GetUploadParamsResponse> GetUploadParamsForTemplateAsync(GetUploadParamsForTemplateRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public GetUploadParamsResponse GetUploadParamsForTemplate(GetUploadParamsForTemplateRequest request) => Proxy.Request<GetUploadParamsResponse>(request);
        public Task<GetUploadParamsResponse> GetUploadParamsForTemplateAsync(GetUploadParamsForTemplateRequest request) => Proxy.RequestAsync<GetUploadParamsResponse>(request);
    }
}
