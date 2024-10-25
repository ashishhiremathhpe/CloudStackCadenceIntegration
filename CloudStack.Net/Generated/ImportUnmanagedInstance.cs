using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ImportUnmanagedInstanceRequest : APIRequest
    {
        public ImportUnmanagedInstanceRequest() : base("importUnmanagedInstance") {}

        /// <summary>
        /// the cluster ID
        /// </summary>
        public Guid ClusterId {
            get { return GetParameterValue<Guid>(nameof(ClusterId).ToLower()); }
            set { SetParameterValue(nameof(ClusterId).ToLower(), value); }
        }

        /// <summary>
        /// the name of the instance as it is known to the hypervisor
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// the service offering for the virtual machine
        /// </summary>
        public Guid ServiceOfferingId {
            get { return GetParameterValue<Guid>(nameof(ServiceOfferingId).ToLower()); }
            set { SetParameterValue(nameof(ServiceOfferingId).ToLower(), value); }
        }

        /// <summary>
        /// an optional account for the virtual machine. Must be used with domainId.
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// datadisk template to disk-offering mapping using keys disk and diskOffering
        /// </summary>
        public IList<IDictionary<string, object>> Datadiskofferinglist {
            get { return GetList<IDictionary<string, object>>(nameof(Datadiskofferinglist).ToLower()); }
            set { SetParameterValue(nameof(Datadiskofferinglist).ToLower(), value); }
        }

        /// <summary>
        /// used to specify the custom parameters.
        /// </summary>
        public IList<IDictionary<string, object>> Details {
            get { return GetList<IDictionary<string, object>>(nameof(Details).ToLower()); }
            set { SetParameterValue(nameof(Details).ToLower(), value); }
        }

        /// <summary>
        /// the display name of the instance
        /// </summary>
        public string DisplayName {
            get { return GetParameterValue<string>(nameof(DisplayName).ToLower()); }
            set { SetParameterValue(nameof(DisplayName).ToLower(), value); }
        }

        /// <summary>
        /// import instance to the domain specified
        /// </summary>
        public Guid? DomainId {
            get { return GetParameterValue<Guid?>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// VM is imported despite some of its NIC's MAC addresses are already present, in case the MAC address exists then a new MAC address is generated
        /// </summary>
        public bool? Forced {
            get { return GetParameterValue<bool?>(nameof(Forced).ToLower()); }
            set { SetParameterValue(nameof(Forced).ToLower(), value); }
        }

        /// <summary>
        /// the host name of the instance
        /// </summary>
        public string HostName {
            get { return GetParameterValue<string>(nameof(HostName).ToLower()); }
            set { SetParameterValue(nameof(HostName).ToLower(), value); }
        }

        /// <summary>
        /// vm and its volumes are allowed to migrate to different host/pool when offerings passed are incompatible with current host/pool
        /// </summary>
        public bool? MigrateAllowed {
            get { return GetParameterValue<bool?>(nameof(MigrateAllowed).ToLower()); }
            set { SetParameterValue(nameof(MigrateAllowed).ToLower(), value); }
        }

        /// <summary>
        /// VM nic to ip address mapping using keys nic, ip4Address
        /// </summary>
        public IList<IDictionary<string, object>> NicIpAddressList {
            get { return GetList<IDictionary<string, object>>(nameof(NicIpAddressList).ToLower()); }
            set { SetParameterValue(nameof(NicIpAddressList).ToLower(), value); }
        }

        /// <summary>
        /// VM nic to network id mapping using keys nic and network
        /// </summary>
        public IList<IDictionary<string, object>> NicNetworkList {
            get { return GetList<IDictionary<string, object>>(nameof(NicNetworkList).ToLower()); }
            set { SetParameterValue(nameof(NicNetworkList).ToLower(), value); }
        }

        /// <summary>
        /// import instance for the project
        /// </summary>
        public Guid? ProjectId {
            get { return GetParameterValue<Guid?>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the template for the virtual machine
        /// </summary>
        public Guid? TemplateId {
            get { return GetParameterValue<Guid?>(nameof(TemplateId).ToLower()); }
            set { SetParameterValue(nameof(TemplateId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Import unmanaged virtual machine from a given cluster.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse ImportUnmanagedInstance(ImportUnmanagedInstanceRequest request);
        Task<AsyncJobResponse> ImportUnmanagedInstanceAsync(ImportUnmanagedInstanceRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse ImportUnmanagedInstance(ImportUnmanagedInstanceRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> ImportUnmanagedInstanceAsync(ImportUnmanagedInstanceRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
