using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ChangeOfferingForVolumeRequest : APIRequest
    {
        public ChangeOfferingForVolumeRequest() : base("changeOfferingForVolume") {}

        /// <summary>
        /// the ID of the volume
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// new disk offering id
        /// </summary>
        public Guid Diskofferingid {
            get { return GetParameterValue<Guid>(nameof(Diskofferingid).ToLower()); }
            set { SetParameterValue(nameof(Diskofferingid).ToLower(), value); }
        }

        /// <summary>
        /// Flag for automatic migration of the volume with new disk offering whenever migration is required to apply the offering
        /// </summary>
        public bool? AutoMigrate {
            get { return GetParameterValue<bool?>(nameof(AutoMigrate).ToLower()); }
            set { SetParameterValue(nameof(AutoMigrate).ToLower(), value); }
        }

        /// <summary>
        /// New maximum number of IOPS for the custom disk offering
        /// </summary>
        public long? MaxIops {
            get { return GetParameterValue<long?>(nameof(MaxIops).ToLower()); }
            set { SetParameterValue(nameof(MaxIops).ToLower(), value); }
        }

        /// <summary>
        /// New minimum number of IOPS for the custom disk offering
        /// </summary>
        public long? MinIops {
            get { return GetParameterValue<long?>(nameof(MinIops).ToLower()); }
            set { SetParameterValue(nameof(MinIops).ToLower(), value); }
        }

        /// <summary>
        /// Verify OK to Shrink
        /// </summary>
        public bool? ShrinkOk {
            get { return GetParameterValue<bool?>(nameof(ShrinkOk).ToLower()); }
            set { SetParameterValue(nameof(ShrinkOk).ToLower(), value); }
        }

        /// <summary>
        /// New volume size in GB for the custom disk offering
        /// </summary>
        public long? Size {
            get { return GetParameterValue<long?>(nameof(Size).ToLower()); }
            set { SetParameterValue(nameof(Size).ToLower(), value); }
        }

    }
    /// <summary>
    /// Change disk offering of the volume and also an option to auto migrate if required to apply the new disk offering
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse ChangeOfferingForVolume(ChangeOfferingForVolumeRequest request);
        Task<AsyncJobResponse> ChangeOfferingForVolumeAsync(ChangeOfferingForVolumeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse ChangeOfferingForVolume(ChangeOfferingForVolumeRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> ChangeOfferingForVolumeAsync(ChangeOfferingForVolumeRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
