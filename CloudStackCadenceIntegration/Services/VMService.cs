using Microsoft.Extensions.Logging;
using Neon.Cadence;

namespace CloudStackCadenceIntegration.Services
{
    public interface IVMService
    {
        string ListVMs(CadenceClient cadenceClient);
    }

    public class VMService : IVMService
    {
        
        private readonly ILogger<VMService> _logger;

        public VMService(ILogger<VMService> logger)
        {
            _logger = logger;
        }
        public string ListVMs(CadenceClient cadenceClient)
        {
            _logger.LogInformation("Calling Cadence Workflow to list VMs");
            var stub = cadenceClient.NewWorkflowStub<IListVMWorkflow>();

            var msg = stub.ListVMAsync("https://qa.cloudstack.cloud/client/api/",
                "8y--Jfz6BpGLR94eZiKi_1OQhHAQg43ApL_3EJesv8RmDvFpv8TSDTdYDQKT3fIdueb3mCUP9YZgrRuoUaiZmQ",
                "UKnRfBaAy8mm2SHaLUAYGKHUcKDWp1Ez9-QItMOfdDeK_JMaPXv4mG8_kabVfOwxMQ9pe7y1LSVh_Ff0ggd_jQ").Result;

            return msg;
        }
    }
}