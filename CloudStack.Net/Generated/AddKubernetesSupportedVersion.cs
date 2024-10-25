using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AddKubernetesSupportedVersionRequest : APIRequest
    {
        public AddKubernetesSupportedVersionRequest() : base("addKubernetesSupportedVersion") {}

        /// <summary>
        /// the minimum number of CPUs to be set with the Kubernetes version
        /// </summary>
        public int? Mincpunumber {
            get { return GetParameterValue<int?>(nameof(Mincpunumber).ToLower()); }
            set { SetParameterValue(nameof(Mincpunumber).ToLower(), value); }
        }

        /// <summary>
        /// the minimum RAM size in MB to be set with the Kubernetes version
        /// </summary>
        public int? Minmemory {
            get { return GetParameterValue<int?>(nameof(Minmemory).ToLower()); }
            set { SetParameterValue(nameof(Minmemory).ToLower(), value); }
        }

        /// <summary>
        /// the semantic version of the Kubernetes version. It needs to be specified in MAJOR.MINOR.PATCH format
        /// </summary>
        public string SemanticVersion {
            get { return GetParameterValue<string>(nameof(SemanticVersion).ToLower()); }
            set { SetParameterValue(nameof(SemanticVersion).ToLower(), value); }
        }

        /// <summary>
        /// the checksum value of the binaries ISO. The parameter containing the checksum will be considered a MD5sum if it is not prefixed
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
        /// If set to true the Kubernetes supported version ISO will bypass Secondary Storage and be downloaded to Primary Storage on deployment. Default is false
        /// </summary>
        public bool? DirectDownload {
            get { return GetParameterValue<bool?>(nameof(DirectDownload).ToLower()); }
            set { SetParameterValue(nameof(DirectDownload).ToLower(), value); }
        }

        /// <summary>
        /// the name of the Kubernetes supported version
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// the URL of the binaries ISO for Kubernetes supported version
        /// </summary>
        public string Url {
            get { return GetParameterValue<string>(nameof(Url).ToLower()); }
            set { SetParameterValue(nameof(Url).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the zone in which Kubernetes supported version will be available
        /// </summary>
        public Guid? ZoneId {
            get { return GetParameterValue<Guid?>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Add a supported Kubernetes version
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        KubernetesSupportedVersionResponse AddKubernetesSupportedVersion(AddKubernetesSupportedVersionRequest request);
        Task<KubernetesSupportedVersionResponse> AddKubernetesSupportedVersionAsync(AddKubernetesSupportedVersionRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public KubernetesSupportedVersionResponse AddKubernetesSupportedVersion(AddKubernetesSupportedVersionRequest request) => Proxy.Request<KubernetesSupportedVersionResponse>(request);
        public Task<KubernetesSupportedVersionResponse> AddKubernetesSupportedVersionAsync(AddKubernetesSupportedVersionRequest request) => Proxy.RequestAsync<KubernetesSupportedVersionResponse>(request);
    }
}
