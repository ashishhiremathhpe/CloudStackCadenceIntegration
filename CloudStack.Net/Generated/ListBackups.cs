using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListBackupsRequest : APIListRequest
    {
        public ListBackupsRequest() : base("listBackups") {}

        /// <summary>
        /// list resources by account. Must be used with the domainId parameter.
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// list only resources belonging to the domain specified
        /// </summary>
        public Guid? DomainId {
            get { return GetParameterValue<Guid?>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// id of the backup
        /// </summary>
        public Guid? Id {
            get { return GetParameterValue<Guid?>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// defaults to false, but if true, lists all resources from the parent specified by the domainId till leaves.
        /// </summary>
        public bool? Isrecursive {
            get { return GetParameterValue<bool?>(nameof(Isrecursive).ToLower()); }
            set { SetParameterValue(nameof(Isrecursive).ToLower(), value); }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// If set to false, list only resources belonging to the command's caller; if set to true - list resources that the caller is authorized to see. Default value is false. Resources dedicated to a project are listed only if using the projectid parameter.
        /// </summary>
        public bool? ListAll {
            get { return GetParameterValue<bool?>(nameof(ListAll).ToLower()); }
            set { SetParameterValue(nameof(ListAll).ToLower(), value); }
        }

        /// <summary>
        /// list objects by project; if projectid=-1 lists All VMs
        /// </summary>
        public Guid? ProjectId {
            get { return GetParameterValue<Guid?>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
        }

        /// <summary>
        /// id of the VM
        /// </summary>
        public Guid? Virtualmachineid {
            get { return GetParameterValue<Guid?>(nameof(Virtualmachineid).ToLower()); }
            set { SetParameterValue(nameof(Virtualmachineid).ToLower(), value); }
        }

        /// <summary>
        /// list backups by zone id
        /// </summary>
        public Guid? ZoneId {
            get { return GetParameterValue<Guid?>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists VM backups
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<BackupResponse> ListBackups(ListBackupsRequest request);
        Task<ListResponse<BackupResponse>> ListBackupsAsync(ListBackupsRequest request);
        ListResponse<BackupResponse> ListBackupsAllPages(ListBackupsRequest request);
        Task<ListResponse<BackupResponse>> ListBackupsAllPagesAsync(ListBackupsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<BackupResponse> ListBackups(ListBackupsRequest request) => Proxy.Request<ListResponse<BackupResponse>>(request);
        public Task<ListResponse<BackupResponse>> ListBackupsAsync(ListBackupsRequest request) => Proxy.RequestAsync<ListResponse<BackupResponse>>(request);
        public ListResponse<BackupResponse> ListBackupsAllPages(ListBackupsRequest request) => Proxy.RequestAllPages<BackupResponse>(request);
        public Task<ListResponse<BackupResponse>> ListBackupsAllPagesAsync(ListBackupsRequest request) => Proxy.RequestAllPagesAsync<BackupResponse>(request);
    }
}
