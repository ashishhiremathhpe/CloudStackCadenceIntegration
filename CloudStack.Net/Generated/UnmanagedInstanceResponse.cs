using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UnmanagedInstanceResponse
    {
        /// <summary>
        /// the ID of the cluster to which virtual machine belongs
        /// </summary>
        public string ClusterId { get; set; }

        /// <summary>
        /// the name of the cluster to which virtual machine belongs
        /// </summary>
        public string ClusterName { get; set; }

        /// <summary>
        /// the CPU cores per socket for the virtual machine. VMware specific
        /// </summary>
        public int? Cpucorepersocket { get; set; }

        /// <summary>
        /// the CPU cores of the virtual machine
        /// </summary>
        public int? Cpunumber { get; set; }

        /// <summary>
        /// the CPU speed of the virtual machine
        /// </summary>
        public int? CpuSpeed { get; set; }

        /// <summary>
        /// the ID of the host to which virtual machine belongs
        /// </summary>
        public string HostId { get; set; }

        /// <summary>
        /// the name of the host to which virtual machine belongs
        /// </summary>
        public string HostName { get; set; }

        /// <summary>
        /// the memory of the virtual machine in MB
        /// </summary>
        public int? Memory { get; set; }

        /// <summary>
        /// the name of the virtual machine
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// the operating system of the virtual machine
        /// </summary>
        public string Osdisplayname { get; set; }

        /// <summary>
        /// the operating system ID of the virtual machine
        /// </summary>
        public string Osid { get; set; }

        /// <summary>
        /// the power state of the virtual machine
        /// </summary>
        public string PowerState { get; set; }

        /// <summary>
        /// the list of disks associated with the virtual machine
        /// </summary>
        public IList<UnmanagedInstanceDiskResponse> Disk { get; set; }

        /// <summary>
        /// the list of nics associated with the virtual machine
        /// </summary>
        public IList<NicResponse> Nic { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
