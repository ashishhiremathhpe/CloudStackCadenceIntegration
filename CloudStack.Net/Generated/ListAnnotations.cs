using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListAnnotationsRequest : APIListRequest
    {
        public ListAnnotationsRequest() : base("listAnnotations") {}

        /// <summary>
        /// possible values are "self" and "all". * self : annotations that have been created by the calling user. * all : all the annotations the calling user can access
        /// </summary>
        public string AnnotationFilter {
            get { return GetParameterValue<string>(nameof(AnnotationFilter).ToLower()); }
            set { SetParameterValue(nameof(AnnotationFilter).ToLower(), value); }
        }

        /// <summary>
        /// the id of the entity for which to show annotations
        /// </summary>
        public string Entityid {
            get { return GetParameterValue<string>(nameof(Entityid).ToLower()); }
            set { SetParameterValue(nameof(Entityid).ToLower(), value); }
        }

        /// <summary>
        /// the entity type
        /// </summary>
        public string EntityType {
            get { return GetParameterValue<string>(nameof(EntityType).ToLower()); }
            set { SetParameterValue(nameof(EntityType).ToLower(), value); }
        }

        /// <summary>
        /// the id of the annotation
        /// </summary>
        public string Id {
            get { return GetParameterValue<string>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// optional: the id of the user of the annotation
        /// </summary>
        public string Userid {
            get { return GetParameterValue<string>(nameof(Userid).ToLower()); }
            set { SetParameterValue(nameof(Userid).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists annotations.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<AnnotationResponse> ListAnnotations(ListAnnotationsRequest request);
        Task<ListResponse<AnnotationResponse>> ListAnnotationsAsync(ListAnnotationsRequest request);
        ListResponse<AnnotationResponse> ListAnnotationsAllPages(ListAnnotationsRequest request);
        Task<ListResponse<AnnotationResponse>> ListAnnotationsAllPagesAsync(ListAnnotationsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<AnnotationResponse> ListAnnotations(ListAnnotationsRequest request) => Proxy.Request<ListResponse<AnnotationResponse>>(request);
        public Task<ListResponse<AnnotationResponse>> ListAnnotationsAsync(ListAnnotationsRequest request) => Proxy.RequestAsync<ListResponse<AnnotationResponse>>(request);
        public ListResponse<AnnotationResponse> ListAnnotationsAllPages(ListAnnotationsRequest request) => Proxy.RequestAllPages<AnnotationResponse>(request);
        public Task<ListResponse<AnnotationResponse>> ListAnnotationsAllPagesAsync(ListAnnotationsRequest request) => Proxy.RequestAllPagesAsync<AnnotationResponse>(request);
    }
}
