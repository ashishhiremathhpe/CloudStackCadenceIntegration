using CloudStack.Net;
using CloudStackCadenceIntegration.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Neon.Cadence;

namespace CloudStackCadenceIntegration.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DeployVMController : ControllerBase
    {
        private readonly CadenceClient _cadenceClient;
        private readonly IVMService _vmService;
        private readonly ILogger<DeployVMController> _logger;

        public DeployVMController(IVMService vmService, CadenceClient cadenceClient, ILogger<DeployVMController> logger)
        {
            _vmService = vmService;
            _cadenceClient = cadenceClient;
            _logger = logger;
        }


        [HttpPost]
        public IActionResult DeployVM([FromBody] DeployVirtualMachineRequest request)
        {
            _logger.LogInformation("DeployVM method called with ServiceOfferingId: {ServiceOfferingId}, TemplateId: {TemplateId}, ZoneId: {ZoneId}", request.ServiceOfferingId, request.TemplateId, request.ZoneId);
            var message = _vmService.DeployVMs(_cadenceClient, request);
            return Ok(message);
        }
    }
}