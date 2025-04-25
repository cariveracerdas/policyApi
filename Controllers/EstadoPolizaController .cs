using Microsoft.AspNetCore.Mvc;
using policyApi.Services;

namespace policyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstadoPolizaController : ControllerBase
    {
        private readonly EstadoPolizaService _estadoPolizaService;

        public EstadoPolizaController(EstadoPolizaService estadoPolizaService)
        {
            _estadoPolizaService = estadoPolizaService;
        }

        [HttpGet]
        public async Task<IActionResult> GetActivos()
        {
            var estados = await _estadoPolizaService.GetEstadosPoliza();
            return Ok(estados);
        }
    }
}
