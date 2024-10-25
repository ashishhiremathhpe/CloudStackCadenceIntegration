using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateProjectRequest : APIRequest
    {
        public CreateProjectRequest() : base("createProject") {}

        /// <summary>
        /// name of the project
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// account who will be Admin for the project
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// ID of the account owning a project
        /// </summary>
        public Guid? AccountId {
            get { return GetParameterValue<Guid?>(nameof(AccountId).ToLower()); }
            set { SetParameterValue(nameof(AccountId).ToLower(), value); }
        }

        /// <summary>
        /// The display text of the project, defaults to the 'name´.
        /// </summary>
        public string DisplayText {
            get { return GetParameterValue<string>(nameof(DisplayText).ToLower()); }
            set { SetParameterValue(nameof(DisplayText).ToLower(), value); }
        }

        /// <summary>
        /// domain ID of the account owning a project
        /// </summary>
        public Guid? DomainId {
            get { return GetParameterValue<Guid?>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// user ID of the account to be assigned as owner of the project i.e., Project Admin
        /// </summary>
        public Guid? UserId {
            get { return GetParameterValue<Guid?>(nameof(UserId).ToLower()); }
            set { SetParameterValue(nameof(UserId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Creates a project
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse CreateProject(CreateProjectRequest request);
        Task<AsyncJobResponse> CreateProjectAsync(CreateProjectRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse CreateProject(CreateProjectRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> CreateProjectAsync(CreateProjectRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
