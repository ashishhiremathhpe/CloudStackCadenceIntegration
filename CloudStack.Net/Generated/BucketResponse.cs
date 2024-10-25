using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class BucketResponse
    {
        /// <summary>
        /// ID of the Bucket
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Bucket Access Key
        /// </summary>
        public string AccessKey { get; set; }

        /// <summary>
        /// the account associated with the Bucket
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// the date the Bucket was created
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// the domain associated with the bucket
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// the ID of the domain associated with the bucket
        /// </summary>
        public string DomainId { get; set; }

        /// <summary>
        /// Bucket Encryption
        /// </summary>
        public bool Encryption { get; set; }

        /// <summary>
        /// name of the Bucket
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Bucket Object Locking
        /// </summary>
        public bool Objectlocking { get; set; }

        /// <summary>
        /// id of the object storage hosting the Bucket; returned to admin user only
        /// </summary>
        public string Objectstorageid { get; set; }

        /// <summary>
        /// Name of the object storage hosting the Bucket; returned to admin user only
        /// </summary>
        public string Objectstore { get; set; }

        /// <summary>
        /// Bucket Access Policy
        /// </summary>
        public string Policy { get; set; }

        /// <summary>
        /// the project name of the bucket
        /// </summary>
        public string Project { get; set; }

        /// <summary>
        /// the project id of the bucket
        /// </summary>
        public string ProjectId { get; set; }

        /// <summary>
        /// Object storage provider
        /// </summary>
        public string Provider { get; set; }

        /// <summary>
        /// Bucket Quota in GB
        /// </summary>
        public int? Quota { get; set; }

        /// <summary>
        /// Total size of objects in Bucket
        /// </summary>
        public long Size { get; set; }

        /// <summary>
        /// State of the Bucket
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Bucket URL
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Bucket Secret Key
        /// </summary>
        public string Usersecretkey { get; set; }

        /// <summary>
        /// Bucket Versioning
        /// </summary>
        public bool Versioning { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
