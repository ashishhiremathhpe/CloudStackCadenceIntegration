using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateConsoleEndpointResponse
    {
        /// <summary>
        /// details in case of an error
        /// </summary>
        public string Details { get; set; }

        /// <summary>
        /// true if the console endpoint is generated properly
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// the console url
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// the console websocket options
        /// </summary>
        public ConsoleEndpointWebsocketResponse Websocket { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
