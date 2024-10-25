using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class RegisterIsoRequest : APIRequest
    {
        public RegisterIsoRequest() : base("registerIso") {}

        /// <summary>
        /// the name of the ISO
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// the URL to where the ISO is currently being hosted
        /// </summary>
        public string Url {
            get { return GetParameterValue<string>(nameof(Url).ToLower()); }
            set { SetParameterValue(nameof(Url).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the zone you wish to register the ISO to.
        /// </summary>
        public Guid ZoneId {
            get { return GetParameterValue<Guid>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

        /// <summary>
        /// an optional account name. Must be used with domainId.
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// true if this ISO is bootable. If not passed explicitly its assumed to be true
        /// </summary>
        public bool? Bootable {
            get { return GetParameterValue<bool?>(nameof(Bootable).ToLower()); }
            set { SetParameterValue(nameof(Bootable).ToLower(), value); }
        }

        /// <summary>
        /// the checksum value of this ISO. The parameter containing the checksum will be considered a MD5sum if it is not prefixed
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
        /// true if ISO should bypass Secondary Storage and be downloaded to Primary Storage on deployment
        /// </summary>
        public bool? DirectDownload {
            get { return GetParameterValue<bool?>(nameof(DirectDownload).ToLower()); }
            set { SetParameterValue(nameof(DirectDownload).ToLower(), value); }
        }

        /// <summary>
        /// the display text of the ISO, defaults to the 'name'
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
        /// Image store UUID
        /// </summary>
        public string ImageStoreUuid {
            get { return GetParameterValue<string>(nameof(ImageStoreUuid).ToLower()); }
            set { SetParameterValue(nameof(ImageStoreUuid).ToLower(), value); }
        }

        /// <summary>
        /// true if ISO contains XS/VMWare tools inorder to support dynamic scaling of VM CPU/memory
        /// </summary>
        public bool? IsDynamicallyScalable {
            get { return GetParameterValue<bool?>(nameof(IsDynamicallyScalable).ToLower()); }
            set { SetParameterValue(nameof(IsDynamicallyScalable).ToLower(), value); }
        }

        /// <summary>
        /// true if the ISO or its derivatives are extractable; default is false
        /// </summary>
        public bool? Isextractable {
            get { return GetParameterValue<bool?>(nameof(Isextractable).ToLower()); }
            set { SetParameterValue(nameof(Isextractable).ToLower(), value); }
        }

        /// <summary>
        /// true if you want this ISO to be featured
        /// </summary>
        public bool? Isfeatured {
            get { return GetParameterValue<bool?>(nameof(Isfeatured).ToLower()); }
            set { SetParameterValue(nameof(Isfeatured).ToLower(), value); }
        }

        /// <summary>
        /// true if you want to register the ISO to be publicly available to all users, false otherwise.
        /// </summary>
        public bool? Ispublic {
            get { return GetParameterValue<bool?>(nameof(Ispublic).ToLower()); }
            set { SetParameterValue(nameof(Ispublic).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the OS type that best represents the OS of this ISO. If the ISO is bootable this parameter needs to be passed
        /// </summary>
        public Guid? OsTypeId {
            get { return GetParameterValue<Guid?>(nameof(OsTypeId).ToLower()); }
            set { SetParameterValue(nameof(OsTypeId).ToLower(), value); }
        }

        /// <summary>
        /// true if password reset feature is supported; default is false
        /// </summary>
        public bool? PasswordEnabled {
            get { return GetParameterValue<bool?>(nameof(PasswordEnabled).ToLower()); }
            set { SetParameterValue(nameof(PasswordEnabled).ToLower(), value); }
        }

        /// <summary>
        /// Register ISO for the project
        /// </summary>
        public Guid? ProjectId {
            get { return GetParameterValue<Guid?>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Registers an existing ISO into the CloudStack Cloud.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        TemplateResponse RegisterIso(RegisterIsoRequest request);
        Task<TemplateResponse> RegisterIsoAsync(RegisterIsoRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public TemplateResponse RegisterIso(RegisterIsoRequest request) => Proxy.Request<TemplateResponse>(request);
        public Task<TemplateResponse> RegisterIsoAsync(RegisterIsoRequest request) => Proxy.RequestAsync<TemplateResponse>(request);
    }
}
