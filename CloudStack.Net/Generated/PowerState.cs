using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class PowerState
    {
        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
