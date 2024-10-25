using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UploadVolumeRequest : APIRequest
    {
        public UploadVolumeRequest() : base("uploadVolume") {}

        /// <summary>
        /// the format for the volume. Possible values include QCOW2, OVA, and VHD.
        /// </summary>
        public string Format {
            get { return GetParameterValue<string>(nameof(Format).ToLower()); }
            set { SetParameterValue(nameof(Format).ToLower(), value); }
        }

        /// <summary>
        /// the name of the volume
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// the URL of where the volume is hosted. Possible URL include http:// and https://
        /// </summary>
        public string Url {
            get { return GetParameterValue<string>(nameof(Url).ToLower()); }
            set { SetParameterValue(nameof(Url).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the zone the volume is to be hosted on
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
        /// the checksum value of this volume. The parameter containing the checksum will be considered a MD5sum if it is not prefixed
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
        /// the ID of the disk offering. This must be a custom sized offering since during uploadVolume volume size is unknown.
        /// </summary>
        public Guid? DiskOfferingId {
            get { return GetParameterValue<Guid?>(nameof(DiskOfferingId).ToLower()); }
            set { SetParameterValue(nameof(DiskOfferingId).ToLower(), value); }
        }

        /// <summary>
        /// an optional domainId. If the account parameter is used, domainId must also be used. If account is NOT provided then volume will be assigned to the caller account and domain.
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
        /// Upload volume for the project
        /// </summary>
        public Guid? ProjectId {
            get { return GetParameterValue<Guid?>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Uploads a data disk.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse UploadVolume(UploadVolumeRequest request);
        Task<AsyncJobResponse> UploadVolumeAsync(UploadVolumeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse UploadVolume(UploadVolumeRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> UploadVolumeAsync(UploadVolumeRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
