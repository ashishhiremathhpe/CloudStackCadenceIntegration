using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UnmanagedInstanceDiskResponse
    {
        /// <summary>
        /// the ID of the disk
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the capacity of the disk in bytes
        /// </summary>
        public long Capacity { get; set; }

        /// <summary>
        /// the controller of the disk
        /// </summary>
        public string Controller { get; set; }

        /// <summary>
        /// the controller unit of the disk
        /// </summary>
        public int? ControllerUnit { get; set; }

        /// <summary>
        /// the controller of the disk
        /// </summary>
        public string DatastoreHost { get; set; }

        /// <summary>
        /// the controller of the disk
        /// </summary>
        public string DatastoreName { get; set; }

        /// <summary>
        /// the controller of the disk
        /// </summary>
        public string DatastorePath { get; set; }

        /// <summary>
        /// the controller of the disk
        /// </summary>
        public string DatastoreType { get; set; }

        /// <summary>
        /// the file path of the disk image
        /// </summary>
        public string ImagePath { get; set; }

        /// <summary>
        /// the label of the disk
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// the position of the disk
        /// </summary>
        public int? Position { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
