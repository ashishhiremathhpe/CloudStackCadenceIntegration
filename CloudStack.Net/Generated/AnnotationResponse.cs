using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AnnotationResponse
    {
        /// <summary>
        /// the (uu)id of the annotation
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// True if the annotation is available for admins only
        /// </summary>
        public bool AdminsOnly { get; set; }

        /// <summary>
        /// the contents of the annotation
        /// </summary>
        public string Annotation { get; set; }

        /// <summary>
        /// the creation timestamp for this annotation
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// the (uu)id of the entity to which this annotation pertains
        /// </summary>
        public string Entityid { get; set; }

        /// <summary>
        /// the name of the entity to which this annotation pertains
        /// </summary>
        public string EntityName { get; set; }

        /// <summary>
        /// the type of the annotated entity
        /// </summary>
        public string EntityType { get; set; }

        /// <summary>
        /// the removal timestamp for this annotation
        /// </summary>
        public DateTime Removed { get; set; }

        /// <summary>
        /// The (uu)id of the user that entered the annotation
        /// </summary>
        public string Userid { get; set; }

        /// <summary>
        /// The username of the user that entered the annotation
        /// </summary>
        public string Username { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
