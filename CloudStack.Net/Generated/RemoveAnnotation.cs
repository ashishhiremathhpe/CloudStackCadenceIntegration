using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class RemoveAnnotationRequest : APIRequest
    {
        public RemoveAnnotationRequest() : base("removeAnnotation") {}

        /// <summary>
        /// the id of the annotation
        /// </summary>
        public string Id {
            get { return GetParameterValue<string>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// remove an annotation.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AnnotationResponse RemoveAnnotation(RemoveAnnotationRequest request);
        Task<AnnotationResponse> RemoveAnnotationAsync(RemoveAnnotationRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AnnotationResponse RemoveAnnotation(RemoveAnnotationRequest request) => Proxy.Request<AnnotationResponse>(request);
        public Task<AnnotationResponse> RemoveAnnotationAsync(RemoveAnnotationRequest request) => Proxy.RequestAsync<AnnotationResponse>(request);
    }
}
