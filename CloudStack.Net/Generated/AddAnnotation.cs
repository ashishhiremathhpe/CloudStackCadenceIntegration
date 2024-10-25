using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AddAnnotationRequest : APIRequest
    {
        public AddAnnotationRequest() : base("addAnnotation") {}

        /// <summary>
        /// the annotation is visible for admins only
        /// </summary>
        public bool? AdminsOnly {
            get { return GetParameterValue<bool?>(nameof(AdminsOnly).ToLower()); }
            set { SetParameterValue(nameof(AdminsOnly).ToLower(), value); }
        }

        /// <summary>
        /// the annotation text
        /// </summary>
        public string Annotation {
            get { return GetParameterValue<string>(nameof(Annotation).ToLower()); }
            set { SetParameterValue(nameof(Annotation).ToLower(), value); }
        }

        /// <summary>
        /// the id of the entity to annotate
        /// </summary>
        public string Entityid {
            get { return GetParameterValue<string>(nameof(Entityid).ToLower()); }
            set { SetParameterValue(nameof(Entityid).ToLower(), value); }
        }

        /// <summary>
        /// The following entity types are allowed VM, VOLUME, SNAPSHOT, VM_SNAPSHOT, INSTANCE_GROUP, SSH_KEYPAIR, USER_DATA, NETWORK, VPC, PUBLIC_IP_ADDRESS, VPN_CUSTOMER_GATEWAY, TEMPLATE, ISO, KUBERNETES_CLUSTER, SERVICE_OFFERING, DISK_OFFERING, NETWORK_OFFERING, ZONE, POD, CLUSTER, HOST, DOMAIN, PRIMARY_STORAGE, SECONDARY_STORAGE, VR, SYSTEM_VM, AUTOSCALE_VM_GROUP, MANAGEMENT_SERVER
        /// </summary>
        public string EntityType {
            get { return GetParameterValue<string>(nameof(EntityType).ToLower()); }
            set { SetParameterValue(nameof(EntityType).ToLower(), value); }
        }

    }
    /// <summary>
    /// add an annotation.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AnnotationResponse AddAnnotation(AddAnnotationRequest request);
        Task<AnnotationResponse> AddAnnotationAsync(AddAnnotationRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AnnotationResponse AddAnnotation(AddAnnotationRequest request) => Proxy.Request<AnnotationResponse>(request);
        public Task<AnnotationResponse> AddAnnotationAsync(AddAnnotationRequest request) => Proxy.RequestAsync<AnnotationResponse>(request);
    }
}
