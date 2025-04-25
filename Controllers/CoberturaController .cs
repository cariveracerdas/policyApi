using Microsoft.AspNetCore.Mvc;
using policyApi.Services;

namespace policyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoberturaController : ControllerBase
    {
        private readonly CoberturaService _coberturaService;

        public CoberturaController(CoberturaService coberturaService)
        {
            _coberturaService = coberturaService;
        }

        [HttpGet]
        public async Task<IActionResult> GetActivos()
        {
            var coberturas = await _coberturaService.GetCoberturas();
            return Ok(coberturas);
        }
    }
}
