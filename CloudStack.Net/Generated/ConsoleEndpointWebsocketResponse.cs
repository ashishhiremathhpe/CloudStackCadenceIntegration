using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ConsoleEndpointWebsocketResponse
    {
        /// <summary>
        /// the console websocket extra field for validation (if enabled)
        /// </summary>
        public string Extra { get; set; }

        /// <summary>
        /// the console websocket host
        /// </summary>
        public string Host { get; set; }

        /// <summary>
        /// the console websocket path
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// the console websocket port
        /// </summary>
        public string Port { get; set; }

        /// <summary>
        /// the console websocket token
        /// </summary>
        public string Token { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
