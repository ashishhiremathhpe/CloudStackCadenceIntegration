using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class RegisterVnfTemplateRequest : APIRequest
    {
        public RegisterVnfTemplateRequest() : base("registerVnfTemplate") {}

        /// <summary>
        /// the format for the template. Possible values include QCOW2, RAW, VHD and OVA.
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
        /// the name of the template
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// the URL of where the template is hosted. Possible URL include http:// and https://
        /// </summary>
        public string Url {
            get { return GetParameterValue<string>(nameof(Url).ToLower()); }
            set { SetParameterValue(nameof(Url).ToLower(), value); }
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
        /// the checksum value of this template. The parameter containing the checksum will be considered a MD5sum if it is not prefixed
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
        /// Template details in key/value pairs using format details[i].keyname=keyvalue. Example: details[0].hypervisortoolsversion=xenserver61
        /// </summary>
        public IList<IDictionary<string, object>> Details {
            get { return GetList<IDictionary<string, object>>(nameof(Details).ToLower()); }
            set { SetParameterValue(nameof(Details).ToLower(), value); }
        }

        /// <summary>
        /// true if template should bypass Secondary Storage and be downloaded to Primary Storage on deployment
        /// </summary>
        public bool? DirectDownload {
            get { return GetParameterValue<bool?>(nameof(DirectDownload).ToLower()); }
            set { SetParameterValue(nameof(DirectDownload).ToLower(), value); }
        }

        /// <summary>
        /// The display text of the template, defaults to 'name'.
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
        /// the ID of the OS Type that best represents the OS of this template. Not applicable with VMware, as we honour what is defined in the template
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
        /// Register template for the project
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

        /// <summary>
        /// the ID of the zone the template is to be hosted on
        /// </summary>
        public Guid? ZoneId {
            get { return GetParameterValue<Guid?>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

        /// <summary>
        /// A list of zone ids where the template will be hosted. Use this parameter if the template needs to be registered to multiple zones in one go. Use zoneid if the template needs to be registered to only one zone.Passing only -1 to this will cause the template to be registered as a cross zone template and will be copied to all zones. 
        /// </summary>
        public IList<Guid> ZoneIds {
            get { return GetList<Guid>(nameof(ZoneIds).ToLower()); }
            set { SetParameterValue(nameof(ZoneIds).ToLower(), value); }
        }

    }
    /// <summary>
    /// Registers an existing VNF template into the CloudStack cloud. 
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        TemplateResponse RegisterVnfTemplate(RegisterVnfTemplateRequest request);
        Task<TemplateResponse> RegisterVnfTemplateAsync(RegisterVnfTemplateRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public TemplateResponse RegisterVnfTemplate(RegisterVnfTemplateRequest request) => Proxy.Request<TemplateResponse>(request);
        public Task<TemplateResponse> RegisterVnfTemplateAsync(RegisterVnfTemplateRequest request) => Proxy.RequestAsync<TemplateResponse>(request);
    }
}
