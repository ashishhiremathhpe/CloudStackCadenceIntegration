using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class GetUploadParamsForIsoRequest : APIRequest
    {
        public GetUploadParamsForIsoRequest() : base("getUploadParamsForIso") {}

        /// <summary>
        /// the format for the volume/template/iso. Possible values include QCOW2, OVA, and VHD.
        /// </summary>
        public string Format {
            get { return GetParameterValue<string>(nameof(Format).ToLower()); }
            set { SetParameterValue(nameof(Format).ToLower(), value); }
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
        /// true if this ISO is bootable. If not passed explicitly its assumed to be true
        /// </summary>
        public bool? Bootable {
            get { return GetParameterValue<bool?>(nameof(Bootable).ToLower()); }
            set { SetParameterValue(nameof(Bootable).ToLower(), value); }
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
        /// the display text of the ISO. This is usually used for display purposes.
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
        /// Upload volume/template/iso for the project
        /// </summary>
        public Guid? ProjectId {
            get { return GetParameterValue<Guid?>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
        }

    }
    /// <summary>
    /// upload an existing ISO into the CloudStack cloud.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        GetUploadParamsResponse GetUploadParamsForIso(GetUploadParamsForIsoRequest request);
        Task<GetUploadParamsResponse> GetUploadParamsForIsoAsync(GetUploadParamsForIsoRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public GetUploadParamsResponse GetUploadParamsForIso(GetUploadParamsForIsoRequest request) => Proxy.Request<GetUploadParamsResponse>(request);
        public Task<GetUploadParamsResponse> GetUploadParamsForIsoAsync(GetUploadParamsForIsoRequest request) => Proxy.RequestAsync<GetUploadParamsResponse>(request);
    }
}
