using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ChildTemplateResponse
    {
        /// <summary>
        /// the template ID
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the template name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// the size of the template
        /// </summary>
        public int? Size { get; set; }

        /// <summary>
        /// the type of the template
        /// </summary>
        public string TemplateType { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
