using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateAnnotationVisibilityRequest : APIRequest
    {
        public UpdateAnnotationVisibilityRequest() : base("updateAnnotationVisibility") {}

        /// <summary>
        /// the id of the annotation
        /// </summary>
        public string Id {
            get { return GetParameterValue<string>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// the annotation is visible for admins only
        /// </summary>
        public bool AdminsOnly {
            get { return GetParameterValue<bool>(nameof(AdminsOnly).ToLower()); }
            set { SetParameterValue(nameof(AdminsOnly).ToLower(), value); }
        }

    }
    /// <summary>
    /// update an annotation visibility.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AnnotationResponse UpdateAnnotationVisibility(UpdateAnnotationVisibilityRequest request);
        Task<AnnotationResponse> UpdateAnnotationVisibilityAsync(UpdateAnnotationVisibilityRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AnnotationResponse UpdateAnnotationVisibility(UpdateAnnotationVisibilityRequest request) => Proxy.Request<AnnotationResponse>(request);
        public Task<AnnotationResponse> UpdateAnnotationVisibilityAsync(UpdateAnnotationVisibilityRequest request) => Proxy.RequestAsync<AnnotationResponse>(request);
    }
}
