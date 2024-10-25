using System;

namespace CloudStack.Net
{
    public enum HostType
    {
        Storage,
        Routing,
        SecondaryStorage,
        SecondaryStorageCmdExecutor,
        ConsoleProxy,
        ExternalFirewall,
        ExternalLoadBalancer,
        ExternalVirtualSwitchSupervisor,
        PxeServer,
        BaremetalPxe,
        BaremetalDhcp,
        TrafficMonitor,
        NetScalerControlCenter,
        ExternalDhcp,
        SecondaryStorageVM,
        LocalSecondaryStorage,
        L2Networking,
    }
}
