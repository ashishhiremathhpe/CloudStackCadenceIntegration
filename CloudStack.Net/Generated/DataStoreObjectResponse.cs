using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DataStoreObjectResponse
    {
        /// <summary>
        /// Format of template associated with the data store object.
        /// </summary>
        public string Format { get; set; }

        /// <summary>
        /// Is it a directory.
        /// </summary>
        public bool IsDirectory { get; set; }

        /// <summary>
        /// Last modified date of the file/directory.
        /// </summary>
        public DateTime LastUpdated { get; set; }

        /// <summary>
        /// Name of the data store object.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Size is in Bytes.
        /// </summary>
        public long Size { get; set; }

        /// <summary>
        /// Snapshot ID associated with the data store object.
        /// </summary>
        public string SnapshotId { get; set; }

        /// <summary>
        /// Template ID associated with the data store object.
        /// </summary>
        public string TemplateId { get; set; }

        /// <summary>
        /// Volume ID associated with the data store object.
        /// </summary>
        public string VolumeId { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
