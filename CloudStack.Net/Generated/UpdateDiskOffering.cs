using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateDiskOfferingRequest : APIRequest
    {
        public UpdateDiskOfferingRequest() : base("updateDiskOffering") {}

        /// <summary>
        /// ID of the disk offering
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// bytes read rate of the disk offering
        /// </summary>
        public long? BytesReadRate {
            get { return GetParameterValue<long?>(nameof(BytesReadRate).ToLower()); }
            set { SetParameterValue(nameof(BytesReadRate).ToLower(), value); }
        }

        /// <summary>
        /// burst bytes read rate of the disk offering
        /// </summary>
        public long? BytesReadRateMax {
            get { return GetParameterValue<long?>(nameof(BytesReadRateMax).ToLower()); }
            set { SetParameterValue(nameof(BytesReadRateMax).ToLower(), value); }
        }

        /// <summary>
        /// length (in seconds) of the burst
        /// </summary>
        public long? BytesReadRateMaxLength {
            get { return GetParameterValue<long?>(nameof(BytesReadRateMaxLength).ToLower()); }
            set { SetParameterValue(nameof(BytesReadRateMaxLength).ToLower(), value); }
        }

        /// <summary>
        /// bytes write rate of the disk offering
        /// </summary>
        public long? BytesWriteRate {
            get { return GetParameterValue<long?>(nameof(BytesWriteRate).ToLower()); }
            set { SetParameterValue(nameof(BytesWriteRate).ToLower(), value); }
        }

        /// <summary>
        /// burst bytes write rate of the disk offering
        /// </summary>
        public long? BytesWriteRateMax {
            get { return GetParameterValue<long?>(nameof(BytesWriteRateMax).ToLower()); }
            set { SetParameterValue(nameof(BytesWriteRateMax).ToLower(), value); }
        }

        /// <summary>
        /// length (in seconds) of the burst
        /// </summary>
        public long? BytesWriteRateMaxLength {
            get { return GetParameterValue<long?>(nameof(BytesWriteRateMaxLength).ToLower()); }
            set { SetParameterValue(nameof(BytesWriteRateMaxLength).ToLower(), value); }
        }

        /// <summary>
        /// the cache mode to use for this disk offering
        /// </summary>
        public string CacheMode {
            get { return GetParameterValue<string>(nameof(CacheMode).ToLower()); }
            set { SetParameterValue(nameof(CacheMode).ToLower(), value); }
        }

        /// <summary>
        /// an optional field, whether to display the offering to the end user or not.
        /// </summary>
        public bool? DisplayOffering {
            get { return GetParameterValue<bool?>(nameof(DisplayOffering).ToLower()); }
            set { SetParameterValue(nameof(DisplayOffering).ToLower(), value); }
        }

        /// <summary>
        /// updates alternate display text of the disk offering with this value
        /// </summary>
        public string DisplayText {
            get { return GetParameterValue<string>(nameof(DisplayText).ToLower()); }
            set { SetParameterValue(nameof(DisplayText).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the containing domain(s) as comma separated string, public for public offerings
        /// </summary>
        public string Domainid {
            get { return GetParameterValue<string>(nameof(Domainid).ToLower()); }
            set { SetParameterValue(nameof(Domainid).ToLower(), value); }
        }

        /// <summary>
        /// io requests read rate of the disk offering
        /// </summary>
        public long? IopsReadRate {
            get { return GetParameterValue<long?>(nameof(IopsReadRate).ToLower()); }
            set { SetParameterValue(nameof(IopsReadRate).ToLower(), value); }
        }

        /// <summary>
        /// burst requests read rate of the disk offering
        /// </summary>
        public long? IopsReadRateMax {
            get { return GetParameterValue<long?>(nameof(IopsReadRateMax).ToLower()); }
            set { SetParameterValue(nameof(IopsReadRateMax).ToLower(), value); }
        }

        /// <summary>
        /// length (in seconds) of the burst
        /// </summary>
        public long? IopsReadRateMaxLength {
            get { return GetParameterValue<long?>(nameof(IopsReadRateMaxLength).ToLower()); }
            set { SetParameterValue(nameof(IopsReadRateMaxLength).ToLower(), value); }
        }

        /// <summary>
        /// io requests write rate of the disk offering
        /// </summary>
        public long? IopsWriteRate {
            get { return GetParameterValue<long?>(nameof(IopsWriteRate).ToLower()); }
            set { SetParameterValue(nameof(IopsWriteRate).ToLower(), value); }
        }

        /// <summary>
        /// burst io requests write rate of the disk offering
        /// </summary>
        public long? IopsWriteRateMax {
            get { return GetParameterValue<long?>(nameof(IopsWriteRateMax).ToLower()); }
            set { SetParameterValue(nameof(IopsWriteRateMax).ToLower(), value); }
        }

        /// <summary>
        /// length (in seconds) of the burst
        /// </summary>
        public long? IopsWriteRateMaxLength {
            get { return GetParameterValue<long?>(nameof(IopsWriteRateMaxLength).ToLower()); }
            set { SetParameterValue(nameof(IopsWriteRateMaxLength).ToLower(), value); }
        }

        /// <summary>
        /// updates name of the disk offering with this value
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// sort key of the disk offering, integer
        /// </summary>
        public int? SortKey {
            get { return GetParameterValue<int?>(nameof(SortKey).ToLower()); }
            set { SetParameterValue(nameof(SortKey).ToLower(), value); }
        }

        /// <summary>
        /// comma-separated list of tags for the disk offering, tags should match with existing storage pool tags
        /// </summary>
        public string Tags {
            get { return GetParameterValue<string>(nameof(Tags).ToLower()); }
            set { SetParameterValue(nameof(Tags).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the containing zone(s) as comma separated string, all for all zones offerings
        /// </summary>
        public string Zoneid {
            get { return GetParameterValue<string>(nameof(Zoneid).ToLower()); }
            set { SetParameterValue(nameof(Zoneid).ToLower(), value); }
        }

    }
    /// <summary>
    /// Updates a disk offering.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        DiskOfferingResponse UpdateDiskOffering(UpdateDiskOfferingRequest request);
        Task<DiskOfferingResponse> UpdateDiskOfferingAsync(UpdateDiskOfferingRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public DiskOfferingResponse UpdateDiskOffering(UpdateDiskOfferingRequest request) => Proxy.Request<DiskOfferingResponse>(request);
        public Task<DiskOfferingResponse> UpdateDiskOfferingAsync(UpdateDiskOfferingRequest request) => Proxy.RequestAsync<DiskOfferingResponse>(request);
    }
}
