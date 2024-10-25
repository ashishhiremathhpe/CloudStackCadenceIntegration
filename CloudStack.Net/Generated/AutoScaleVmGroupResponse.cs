using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AutoScaleVmGroupResponse
    {
        /// <summary>
        /// the autoscale vm group ID
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the account owning the vm group
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// the id of the guest network the lb rule belongs to
        /// </summary>
        public string Associatednetworkid { get; set; }

        /// <summary>
        /// the name of the guest network the lb rule belongs to
        /// </summary>
        public string Associatednetworkname { get; set; }

        /// <summary>
        /// the number of available virtual machines (in Running, Starting, Stopping or Migrating state) in the vmgroup
        /// </summary>
        public int AvailableVirtualMachineCount { get; set; }

        /// <summary>
        /// the date when this vm group was created
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// the domain name of the vm group
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// the domain ID of the vm group
        /// </summary>
        public string DomainId { get; set; }

        /// <summary>
        /// is group for display to the regular user
        /// </summary>
        public bool ForDisplay { get; set; }

        /// <summary>
        /// the frequency at which the conditions have to be evaluated
        /// </summary>
        public int Interval { get; set; }

        /// <summary>
        /// the lb provider of the guest network the lb rule belongs to
        /// </summary>
        public string LbProvider { get; set; }

        /// <summary>
        /// the load balancer rule ID
        /// </summary>
        public string Lbruleid { get; set; }

        /// <summary>
        /// the maximum number of members in the vmgroup, The number of instances in the vm group will be equal to or less than this number.
        /// </summary>
        public int MaxMembers { get; set; }

        /// <summary>
        /// the minimum number of members in the vmgroup, the number of instances in the vm group will be equal to or more than this number.
        /// </summary>
        public int MinMembers { get; set; }

        /// <summary>
        /// the name of the autoscale vm group 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// the private port
        /// </summary>
        public string PrivatePort { get; set; }

        /// <summary>
        /// the project name of the vm group
        /// </summary>
        public string Project { get; set; }

        /// <summary>
        /// the project id of the vm group
        /// </summary>
        public string ProjectId { get; set; }

        /// <summary>
        /// the public ip address
        /// </summary>
        public string PublicIp { get; set; }

        /// <summary>
        /// the public ip address id
        /// </summary>
        public string PublicIpId { get; set; }

        /// <summary>
        /// the public port
        /// </summary>
        public string PublicPort { get; set; }

        /// <summary>
        /// list of scaledown autoscale policies
        /// </summary>
        public IList<AutoScalePolicyResponse> ScaleDownPolicies { get; set; }

        /// <summary>
        /// list of scaleup autoscale policies
        /// </summary>
        public IList<AutoScalePolicyResponse> ScaleUpPolicies { get; set; }

        /// <summary>
        /// the current state of the AutoScale Vm Group
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// the autoscale profile that contains information about the vms in the vm group.
        /// </summary>
        public string Vmprofileid { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
