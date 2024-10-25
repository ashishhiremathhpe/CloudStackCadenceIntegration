using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateAutoScaleVmProfileRequest : APIRequest
    {
        public UpdateAutoScaleVmProfileRequest() : base("updateAutoScaleVmProfile") {}

        /// <summary>
        /// the ID of the autoscale vm profile
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the user used to launch and destroy the VMs
        /// </summary>
        public Guid? AutoscaleUserId {
            get { return GetParameterValue<Guid?>(nameof(AutoscaleUserId).ToLower()); }
            set { SetParameterValue(nameof(AutoscaleUserId).ToLower(), value); }
        }

        /// <summary>
        /// counterparam list. Example: counterparam[0].name=snmpcommunity&counterparam[0].value=public&counterparam[1].name=snmpport&counterparam[1].value=161
        /// </summary>
        public IList<IDictionary<string, object>> Counterparam {
            get { return GetList<IDictionary<string, object>>(nameof(Counterparam).ToLower()); }
            set { SetParameterValue(nameof(Counterparam).ToLower(), value); }
        }

        /// <summary>
        /// an optional field, in case you want to set a custom id to the resource. Allowed to Root Admins only
        /// </summary>
        public string CustomId {
            get { return GetParameterValue<string>(nameof(CustomId).ToLower()); }
            set { SetParameterValue(nameof(CustomId).ToLower(), value); }
        }

        /// <summary>
        /// the time allowed for existing connections to get closed before a vm is destroyed
        /// </summary>
        public int? ExpungeVmGracePeriod {
            get { return GetParameterValue<int?>(nameof(ExpungeVmGracePeriod).ToLower()); }
            set { SetParameterValue(nameof(ExpungeVmGracePeriod).ToLower(), value); }
        }

        /// <summary>
        /// an optional field, whether to the display the profile to the end user or not
        /// </summary>
        public bool? Fordisplay {
            get { return GetParameterValue<bool?>(nameof(Fordisplay).ToLower()); }
            set { SetParameterValue(nameof(Fordisplay).ToLower(), value); }
        }

        /// <summary>
        /// parameters other than zoneId/serviceOfferringId/templateId of the auto deployed virtual machine. 
        /// Example: otherdeployparams[0].name=serviceofferingid&otherdeployparams[0].value=a7fb50f6-01d9-11ed-8bc1-77f8f0228926&otherdeployparams[1].name=rootdisksize&otherdeployparams[1].value=10 .
        /// Possible parameters are "rootdisksize", "diskofferingid","size", "securitygroupids", "overridediskofferingid", "keypairs", "affinitygroupids'" and "networkids".
        /// </summary>
        public IList<IDictionary<string, object>> OtherDeployParams {
            get { return GetList<IDictionary<string, object>>(nameof(OtherDeployParams).ToLower()); }
            set { SetParameterValue(nameof(OtherDeployParams).ToLower(), value); }
        }

        /// <summary>
        /// the service offering of the auto deployed virtual machine
        /// </summary>
        public Guid? ServiceOfferingId {
            get { return GetParameterValue<Guid?>(nameof(ServiceOfferingId).ToLower()); }
            set { SetParameterValue(nameof(ServiceOfferingId).ToLower(), value); }
        }

        /// <summary>
        /// the template of the auto deployed virtual machine
        /// </summary>
        public Guid? TemplateId {
            get { return GetParameterValue<Guid?>(nameof(TemplateId).ToLower()); }
            set { SetParameterValue(nameof(TemplateId).ToLower(), value); }
        }

        /// <summary>
        /// an optional binary data that can be sent to the virtual machine upon a successful deployment. This binary data must be base64 encoded before adding it to the request. Using HTTP GET (via querystring), you can send up to 4KB of data after base64 encoding. Using HTTP POST(via POST body), you can send up to 1MB of data after base64 encoding.You also need to change vm.userdata.max.length value
        /// </summary>
        public string UserData {
            get { return GetParameterValue<string>(nameof(UserData).ToLower()); }
            set { SetParameterValue(nameof(UserData).ToLower(), value); }
        }

        /// <summary>
        /// used to specify the parameters values for the variables in userdata.
        /// </summary>
        public IList<IDictionary<string, object>> UserDataDetails {
            get { return GetList<IDictionary<string, object>>(nameof(UserDataDetails).ToLower()); }
            set { SetParameterValue(nameof(UserDataDetails).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the userdata
        /// </summary>
        public Guid? UserDataId {
            get { return GetParameterValue<Guid?>(nameof(UserDataId).ToLower()); }
            set { SetParameterValue(nameof(UserDataId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Updates an existing autoscale vm profile.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse UpdateAutoScaleVmProfile(UpdateAutoScaleVmProfileRequest request);
        Task<AsyncJobResponse> UpdateAutoScaleVmProfileAsync(UpdateAutoScaleVmProfileRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse UpdateAutoScaleVmProfile(UpdateAutoScaleVmProfileRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> UpdateAutoScaleVmProfileAsync(UpdateAutoScaleVmProfileRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
