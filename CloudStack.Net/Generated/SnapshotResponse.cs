using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class SnapshotResponse
    {
        /// <summary>
        /// ID of the snapshot
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the account associated with the snapshot
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        ///   the date the snapshot was created
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// ID of the datastore for the snapshot entry
        /// </summary>
        public string DatastoreId { get; set; }

        /// <summary>
        /// name of the datastore for the snapshot entry
        /// </summary>
        public string DatastoreName { get; set; }

        /// <summary>
        /// state of the snapshot on the datastore
        /// </summary>
        public string DatastoreState { get; set; }

        /// <summary>
        /// type of the datastore for the snapshot entry
        /// </summary>
        public string DatastoreType { get; set; }

        /// <summary>
        /// the domain name of the snapshot's account
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// the domain ID of the snapshot's account
        /// </summary>
        public string DomainId { get; set; }

        /// <summary>
        /// download progress of a snapshot
        /// </summary>
        public IDictionary<string, string> DownloadDetails { get; set; }

        /// <summary>
        /// valid types are hourly, daily, weekly, monthy, template, and none.
        /// </summary>
        public string IntervalType { get; set; }

        /// <summary>
        /// valid location types are primary and secondary.
        /// </summary>
        public string LocationType { get; set; }

        /// <summary>
        /// name of the snapshot
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// display name of the os on volume
        /// </summary>
        public string OsDisplayName { get; set; }

        /// <summary>
        /// id of the os on volume
        /// </summary>
        public string OsTypeId { get; set; }

        /// <summary>
        /// physical size of backedup snapshot on image store
        /// </summary>
        public long PhysicalSize { get; set; }

        /// <summary>
        /// the project name of the snapshot
        /// </summary>
        public string Project { get; set; }

        /// <summary>
        /// the project id of the snapshot
        /// </summary>
        public string ProjectId { get; set; }

        /// <summary>
        /// indicates whether the underlying storage supports reverting the volume to this snapshot
        /// </summary>
        public bool Revertable { get; set; }

        /// <summary>
        /// the type of the snapshot
        /// </summary>
        public string SnapshotType { get; set; }

        /// <summary>
        /// the state of the snapshot. BackedUp means that snapshot is ready to be used; Creating - the snapshot is being allocated on the primary storage; BackingUp - the snapshot is being backed up on secondary storage
        /// </summary>
        public State State { get; set; }

        /// <summary>
        /// the status of the template
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// virtual size of backedup snapshot on image store
        /// </summary>
        public long VirtualSize { get; set; }

        /// <summary>
        /// ID of the disk volume
        /// </summary>
        public string VolumeId { get; set; }

        /// <summary>
        /// name of the disk volume
        /// </summary>
        public string VolumeName { get; set; }

        /// <summary>
        /// type of the disk volume
        /// </summary>
        public string VolumeType { get; set; }

        /// <summary>
        /// id of the availability zone
        /// </summary>
        public string ZoneId { get; set; }

        /// <summary>
        /// name of the availability zone
        /// </summary>
        public string ZoneName { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
