using CloudStack.Net;
using Microsoft.Extensions.Logging;
using Neon.Cadence;

namespace CloudStackCadenceIntegration.Services
{
    public interface IVMService
    {
        ListResponse<UserVmResponse> ListVMs(CadenceClient cadenceClient);
        string DeployVMs(CadenceClient cadenceClient, DeployVirtualMachineRequest request);
    }

    public class VMService : IVMService
    {
        private readonly ILogger<VMService> _logger;

        public VMService(ILogger<VMService> logger)
        {
            _logger = logger;
        }

        public ListResponse<UserVmResponse> ListVMs(CadenceClient cadenceClient)
        {
            _logger.LogInformation("Calling Cadence Workflow to list VMs");
            var stub = cadenceClient.NewWorkflowStub<IListVMWorkflow>();

            var msg = stub.ListVMAsync("http://localhost:8080/client/api/",
                "ZzNGj3F_J0EOcuT1ZNgbviATBcW9jY7ykbLMac_v6qCXZBPlAlL31qDieGl-q9ojfY0V_S-lRth84oUjVxCBng",
                "lMgesGM2xufrzPuaGbA7cNK4CCLNKmSCEuNL-Af7ScXwOfl0990ya2iqDedV84sS_i55U9V2tbGX0YMF05CqAw").Result;

            return msg;
        }

        public string DeployVMs(CadenceClient cadenceClient, DeployVirtualMachineRequest request)
        {
            _logger.LogInformation("Calling Cadence Workflow to deploy VMs");
            var stub = cadenceClient.NewWorkflowStub<IDeployVMWorkflow>();

            var msg = stub.DeployVMAsync("http://localhost:8080/client/api/",
                "ZzNGj3F_J0EOcuT1ZNgbviATBcW9jY7ykbLMac_v6qCXZBPlAlL31qDieGl-q9ojfY0V_S-lRth84oUjVxCBng",
                "lMgesGM2xufrzPuaGbA7cNK4CCLNKmSCEuNL-Af7ScXwOfl0990ya2iqDedV84sS_i55U9V2tbGX0YMF05CqAw",
                request.ServiceOfferingId,
                request.TemplateId,
                request.ZoneId).Result;

            return msg.ToString();
        }
    }
}