using CloudStackCadenceIntegration.Services;
using Microsoft.AspNetCore.Mvc;
using Neon.Cadence;

namespace CloudStackCadenceIntegration.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ListVMController : ControllerBase
    {
        private readonly CadenceClient _cadenceClient;
        private readonly IVMService _vmService;

        public ListVMController(IVMService vmService, CadenceClient cadenceClient)
        {
            _vmService = vmService;
            _cadenceClient = cadenceClient;
        }

        [HttpGet]
        public IActionResult ListVM()
        {
            var message =  _vmService.ListVMs(_cadenceClient);
            return Ok(message);
        }
    }
}