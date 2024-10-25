using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class SimulatorHAStateResponse
    {
        /// <summary>
        /// the activity counter
        /// </summary>
        public long ActivityCounter { get; set; }

        /// <summary>
        /// the event that caused state transition
        /// </summary>
        public string Event { get; set; }

        /// <summary>
        /// the ha state
        /// </summary>
        public string HaState { get; set; }

        /// <summary>
        /// the previous ha state
        /// </summary>
        public string Prevhastate { get; set; }

        /// <summary>
        /// the recovery counter
        /// </summary>
        public long RecoveryCounter { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
