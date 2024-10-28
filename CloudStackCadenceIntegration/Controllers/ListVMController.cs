using CloudStackCadenceIntegration.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Neon.Cadence;

namespace CloudStackCadenceIntegration.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ListVMController : ControllerBase
    {
        private readonly CadenceClient _cadenceClient;
        private readonly IVMService _vmService;
        private readonly ILogger<ListVMController> _logger;

        public ListVMController(IVMService vmService, CadenceClient cadenceClient, ILogger<ListVMController> logger)
        {
            _vmService = vmService;
            _cadenceClient = cadenceClient;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult ListVM()
        {
            var message =  _vmService.ListVMs(_cadenceClient);
            return Ok(message);
        }
    }
}