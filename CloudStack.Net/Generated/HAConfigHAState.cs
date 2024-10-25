using System;

namespace CloudStack.Net
{
    public enum HAConfigHAState
    {
        Disabled,
        Available,
        Ineligible,
        Suspect,
        Degraded,
        Checking,
        Recovering,
        Recovered,
        Fencing,
        Fenced,
    }
}
