using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class VMSnapshotResponse
    {
        /// <summary>
        /// the ID of the vm snapshot
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the account associated with the disk volume
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// the create date of the vm snapshot
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// indicates if this is current snapshot
        /// </summary>
        public bool Current { get; set; }

        /// <summary>
        /// the description of the vm snapshot
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// the display name of the vm snapshot
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// the domain associated with the disk volume
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// the ID of the domain associated with the disk volume
        /// </summary>
        public string DomainId { get; set; }

        /// <summary>
        /// the type of hypervisor on which snapshot is stored
        /// </summary>
        public string Hypervisor { get; set; }

        /// <summary>
        /// the name of the vm snapshot
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// the parent ID of the vm snapshot
        /// </summary>
        public string Parent { get; set; }

        /// <summary>
        /// the parent displayName of the vm snapshot
        /// </summary>
        public string ParentName { get; set; }

        /// <summary>
        /// the project name of the vpn
        /// </summary>
        public string Project { get; set; }

        /// <summary>
        /// the project id of the vpn
        /// </summary>
        public string ProjectId { get; set; }

        /// <summary>
        /// the state of the vm snapshot
        /// </summary>
        public State State { get; set; }

        /// <summary>
        /// VM Snapshot type
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// the vm ID of the vm snapshot
        /// </summary>
        public string VirtualMachineId { get; set; }

        /// <summary>
        /// the vm name of the vm snapshot
        /// </summary>
        public string VirtualMachineName { get; set; }

        /// <summary>
        /// the Zone ID of the vm snapshot
        /// </summary>
        public string ZoneId { get; set; }

        /// <summary>
        /// the Zone name of the vm snapshot
        /// </summary>
        public string ZoneName { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
