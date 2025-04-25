using Microsoft.AspNetCore.Mvc;
using policyApi.Services;

namespace policyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoPolizaController : ControllerBase
    {
        private readonly TipoPolizaService _tipoPolizaService;

        public TipoPolizaController(TipoPolizaService tipoPolizaService)
        {
            _tipoPolizaService = tipoPolizaService;
        }

        [HttpGet]
        public async Task<IActionResult> GetTipoPolizas()
        {
            var tipos = await _tipoPolizaService.GetTipoPolizas();
            return Ok(tipos);
        }
    }
}
