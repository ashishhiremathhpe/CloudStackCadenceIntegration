using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class RunDiagnosticsResponse
    {
        /// <summary>
        /// the command execution return code
        /// </summary>
        public string ExitCode { get; set; }

        /// <summary>
        /// the standard error output from the command execution
        /// </summary>
        public string Stderr { get; set; }

        /// <summary>
        /// the standard output from the command execution
        /// </summary>
        public string Stdout { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
