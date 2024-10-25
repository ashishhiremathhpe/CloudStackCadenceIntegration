using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CapabilitiesResponse
    {
        /// <summary>
        /// true if regular user is allowed to create projects
        /// </summary>
        public bool Allowusercreateprojects { get; set; }

        /// <summary>
        /// true if the user can recover and expunge virtualmachines, false otherwise
        /// </summary>
        public bool AllowUserExpungeRecoverVM { get; set; }

        /// <summary>
        /// true if the user can recover and expunge volumes, false otherwise
        /// </summary>
        public bool AllowUserExpungeRecoverVolume { get; set; }

        /// <summary>
        /// true if users can see all accounts within the same domain, false otherwise
        /// </summary>
        public bool AllowUserViewAllDomainAccounts { get; set; }

        /// <summary>
        /// true if the user is allowed to view destroyed virtualmachines, false otherwise
        /// </summary>
        public bool AllowUserViewDestroyedVM { get; set; }

        /// <summary>
        /// time interval (in seconds) to reset api count
        /// </summary>
        public int? ApiLimitInterval { get; set; }

        /// <summary>
        /// Max allowed number of api requests within the specified interval
        /// </summary>
        public int? ApiLimitMax { get; set; }

        /// <summary>
        /// version of the cloud stack
        /// </summary>
        public string CloudStackVersion { get; set; }

        /// <summary>
        /// maximum size that can be specified when create disk from disk offering with custom size
        /// </summary>
        public long Customdiskofferingmaxsize { get; set; }

        /// <summary>
        /// minimum size that can be specified when create disk from disk offering with custom size
        /// </summary>
        public long Customdiskofferingminsize { get; set; }

        /// <summary>
        /// Display name for custom hypervisor
        /// </summary>
        public string CustomHypervisorDisplayName { get; set; }

        /// <summary>
        /// default page size in the UI for various views, value set in the configurations
        /// </summary>
        public long DefaultUiPageSize { get; set; }

        /// <summary>
        /// true if dynamic role-based api checker is enabled, false otherwise
        /// </summary>
        public bool DynamicRolesEnabled { get; set; }

        /// <summary>
        /// true if stats are retained for instance disks otherwise false
        /// </summary>
        public bool InstancesDisksStatsRetentionEnabled { get; set; }

        /// <summary>
        /// the retention time for Instances disks stats
        /// </summary>
        public int? InstancesDisksStatsRetentionTime { get; set; }

        /// <summary>
        /// the retention time for Instances stats
        /// </summary>
        public int? InstancesStatsRetentionTime { get; set; }

        /// <summary>
        /// true if stats are collected only for user instances, false if system instance stats are also collected
        /// </summary>
        public bool InstancesStatsUserOnly { get; set; }

        /// <summary>
        /// true if experimental features for Kubernetes cluster such as Docker private registry are enabled, false otherwise
        /// </summary>
        public bool KubernetesClusterExperimentalFeaturesEnabled { get; set; }

        /// <summary>
        /// true if Kubernetes Service plugin is enabled, false otherwise
        /// </summary>
        public bool KubernetesServiceEnabled { get; set; }

        /// <summary>
        /// true if snapshot is supported for KVM host, false otherwise
        /// </summary>
        public bool KvmSnapshotEnabled { get; set; }

        /// <summary>
        /// If invitation confirmation is required when add account to project
        /// </summary>
        public bool ProjectInviteRequired { get; set; }

        /// <summary>
        /// true if region wide secondary is enabled, false otherwise
        /// </summary>
        public bool RegionSecondaryEnabled { get; set; }

        /// <summary>
        /// true if security groups support is enabled, false otherwise
        /// </summary>
        public bool SecurityGroupsEnabled { get; set; }

        /// <summary>
        /// true if region supports elastic load balancer on basic zones
        /// </summary>
        public string SupportELB { get; set; }

        /// <summary>
        /// true if user and domain admins can set templates to be shared, false otherwise
        /// </summary>
        public bool UserPublicTemplateEnabled { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
