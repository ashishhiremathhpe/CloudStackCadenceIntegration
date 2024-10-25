using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListTemplatesRequest : APIListRequest
    {
        public ListTemplatesRequest() : base("listTemplates") {}

        /// <summary>
        /// possible values are "featured", "self", "selfexecutable","sharedexecutable","executable", and "community". * featured : templates that have been marked as featured and public. * self : templates that have been registered or created by the calling user. * selfexecutable : same as self, but only returns templates that can be used to deploy a new VM. * sharedexecutable : templates ready to be deployed that have been granted to the calling user by another user. * executable : templates that are owned by the calling user, or public templates, that can be used to deploy a VM. * community : templates that have been marked as public but not featured. * all : all templates (only usable by admins).
        /// </summary>
        public string TemplateFilter {
            get { return GetParameterValue<string>(nameof(TemplateFilter).ToLower()); }
            set { SetParameterValue(nameof(TemplateFilter).ToLower(), value); }
        }

        /// <summary>
        /// list resources by account. Must be used with the domainId parameter.
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// comma separated list of template details requested, value can be a list of [ all, min]
        /// </summary>
        public IList<string> Details {
            get { return GetList<string>(nameof(Details).ToLower()); }
            set { SetParameterValue(nameof(Details).ToLower(), value); }
        }

        /// <summary>
        /// list only resources belonging to the domain specified
        /// </summary>
        public Guid? DomainId {
            get { return GetParameterValue<Guid?>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// the hypervisor for which to restrict the search
        /// </summary>
        public string Hypervisor {
            get { return GetParameterValue<string>(nameof(Hypervisor).ToLower()); }
            set { SetParameterValue(nameof(Hypervisor).ToLower(), value); }
        }

        /// <summary>
        /// the template ID
        /// </summary>
        public Guid? Id {
            get { return GetParameterValue<Guid?>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// the IDs of the templates, mutually exclusive with id
        /// </summary>
        public IList<Guid> Ids {
            get { return GetList<Guid>(nameof(Ids).ToLower()); }
            set { SetParameterValue(nameof(Ids).ToLower(), value); }
        }

        /// <summary>
        /// ID of the image or image cache store
        /// </summary>
        public Guid? ImageStoreId {
            get { return GetParameterValue<Guid?>(nameof(ImageStoreId).ToLower()); }
            set { SetParameterValue(nameof(ImageStoreId).ToLower(), value); }
        }

        /// <summary>
        /// defaults to false, but if true, lists all resources from the parent specified by the domainId till leaves.
        /// </summary>
        public bool? Isrecursive {
            get { return GetParameterValue<bool?>(nameof(Isrecursive).ToLower()); }
            set { SetParameterValue(nameof(Isrecursive).ToLower(), value); }
        }

        /// <summary>
        /// flag to list VNF templates or not; true if need to list VNF templates, false otherwise.
        /// </summary>
        public bool? IsVnf {
            get { return GetParameterValue<bool?>(nameof(IsVnf).ToLower()); }
            set { SetParameterValue(nameof(IsVnf).ToLower(), value); }
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
        /// the template name
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// list datadisk templates by parent template id
        /// </summary>
        public Guid? ParentTemplateId {
            get { return GetParameterValue<Guid?>(nameof(ParentTemplateId).ToLower()); }
            set { SetParameterValue(nameof(ParentTemplateId).ToLower(), value); }
        }

        /// <summary>
        /// list objects by project; if projectid=-1 lists All VMs
        /// </summary>
        public Guid? ProjectId {
            get { return GetParameterValue<Guid?>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
        }

        /// <summary>
        /// flag to display the resource image for the templates
        /// </summary>
        public bool? ShowIcon {
            get { return GetParameterValue<bool?>(nameof(ShowIcon).ToLower()); }
            set { SetParameterValue(nameof(ShowIcon).ToLower(), value); }
        }

        /// <summary>
        /// show removed templates as well
        /// </summary>
        public bool? ShowRemoved {
            get { return GetParameterValue<bool?>(nameof(ShowRemoved).ToLower()); }
            set { SetParameterValue(nameof(ShowRemoved).ToLower(), value); }
        }

        /// <summary>
        /// If set to true, list only unique templates across zones
        /// </summary>
        public bool? ShowUnique {
            get { return GetParameterValue<bool?>(nameof(ShowUnique).ToLower()); }
            set { SetParameterValue(nameof(ShowUnique).ToLower(), value); }
        }

        /// <summary>
        /// ID of the storage pool
        /// </summary>
        public Guid? Storageid {
            get { return GetParameterValue<Guid?>(nameof(Storageid).ToLower()); }
            set { SetParameterValue(nameof(Storageid).ToLower(), value); }
        }

        /// <summary>
        /// List resources by tags (key/value pairs)
        /// </summary>
        public IList<IDictionary<string, object>> Tags {
            get { return GetList<IDictionary<string, object>>(nameof(Tags).ToLower()); }
            set { SetParameterValue(nameof(Tags).ToLower(), value); }
        }

        /// <summary>
        /// the type of the template
        /// </summary>
        public string TemplateType {
            get { return GetParameterValue<string>(nameof(TemplateType).ToLower()); }
            set { SetParameterValue(nameof(TemplateType).ToLower(), value); }
        }

        /// <summary>
        /// list templates by zoneId
        /// </summary>
        public Guid? ZoneId {
            get { return GetParameterValue<Guid?>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

    }
    /// <summary>
    /// List all public, private, and privileged templates.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<TemplateResponse> ListTemplates(ListTemplatesRequest request);
        Task<ListResponse<TemplateResponse>> ListTemplatesAsync(ListTemplatesRequest request);
        ListResponse<TemplateResponse> ListTemplatesAllPages(ListTemplatesRequest request);
        Task<ListResponse<TemplateResponse>> ListTemplatesAllPagesAsync(ListTemplatesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<TemplateResponse> ListTemplates(ListTemplatesRequest request) => Proxy.Request<ListResponse<TemplateResponse>>(request);
        public Task<ListResponse<TemplateResponse>> ListTemplatesAsync(ListTemplatesRequest request) => Proxy.RequestAsync<ListResponse<TemplateResponse>>(request);
        public ListResponse<TemplateResponse> ListTemplatesAllPages(ListTemplatesRequest request) => Proxy.RequestAllPages<TemplateResponse>(request);
        public Task<ListResponse<TemplateResponse>> ListTemplatesAllPagesAsync(ListTemplatesRequest request) => Proxy.RequestAllPagesAsync<TemplateResponse>(request);
    }
}
