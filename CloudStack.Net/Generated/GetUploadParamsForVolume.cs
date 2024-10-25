using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class GetUploadParamsForVolumeRequest : APIRequest
    {
        public GetUploadParamsForVolumeRequest() : base("getUploadParamsForVolume") {}

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
        /// the ID of the disk offering. This must be a custom sized offering since during upload of volume/template size is unknown.
        /// </summary>
        public Guid? DiskOfferingId {
            get { return GetParameterValue<Guid?>(nameof(DiskOfferingId).ToLower()); }
            set { SetParameterValue(nameof(DiskOfferingId).ToLower(), value); }
        }

        /// <summary>
        /// an optional domainId. If the account parameter is used, domainId must also be used.
        /// </summary>
        public Guid? DomainId {
            get { return GetParameterValue<Guid?>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// Image store uuid
        /// </summary>
        public string ImageStoreUuid {
            get { return GetParameterValue<string>(nameof(ImageStoreUuid).ToLower()); }
            set { SetParameterValue(nameof(ImageStoreUuid).ToLower(), value); }
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
    /// Upload a data disk to the cloudstack cloud.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        GetUploadParamsResponse GetUploadParamsForVolume(GetUploadParamsForVolumeRequest request);
        Task<GetUploadParamsResponse> GetUploadParamsForVolumeAsync(GetUploadParamsForVolumeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public GetUploadParamsResponse GetUploadParamsForVolume(GetUploadParamsForVolumeRequest request) => Proxy.Request<GetUploadParamsResponse>(request);
        public Task<GetUploadParamsResponse> GetUploadParamsForVolumeAsync(GetUploadParamsForVolumeRequest request) => Proxy.RequestAsync<GetUploadParamsResponse>(request);
    }
}
