using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class PodResponse
    {
        /// <summary>
        /// the ID of the Pod
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the allocation state of the Pod
        /// </summary>
        public string AllocationState { get; set; }

        /// <summary>
        /// the ending IP for the Pod. This parameter is deprecated, please use 'endip' from ipranges parameter.
        /// </summary>
        public IList<string> EndIp { get; set; }

        /// <summary>
        /// indicates if range is dedicated for CPVM and SSVM. This parameter is deprecated, please use 'forsystemvms' from ipranges parameter.
        /// </summary>
        public IList<string> ForSystemVms { get; set; }

        /// <summary>
        /// the gateway of the Pod
        /// </summary>
        public string Gateway { get; set; }

        /// <summary>
        /// the name of the Pod
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// the netmask of the Pod
        /// </summary>
        public string Netmask { get; set; }

        /// <summary>
        /// the starting IP for the Pod. This parameter is deprecated, please use 'startip' from ipranges parameter.
        /// </summary>
        public IList<string> StartIp { get; set; }

        /// <summary>
        /// indicates Vlan ID for the range. This parameter is deprecated, please use 'vlanid' from ipranges parameter.
        /// </summary>
        public IList<string> VlanId { get; set; }

        /// <summary>
        /// the Zone ID of the Pod
        /// </summary>
        public string ZoneId { get; set; }

        /// <summary>
        /// the Zone name of the Pod
        /// </summary>
        public string ZoneName { get; set; }

        /// <summary>
        /// the capacity of the Pod
        /// </summary>
        public IList<CapacityResponse> Capacity { get; set; }

        /// <summary>
        /// the IP ranges for the Pod
        /// </summary>
        public IList<IpRangeResponse> IpRanges { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
