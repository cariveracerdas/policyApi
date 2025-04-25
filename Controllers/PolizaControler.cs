using Microsoft.AspNetCore.Mvc;
using policyApi.Models.Request;

[ApiController]
[Route("api/[controller]")]
public class PolizaController : ControllerBase
{
    private readonly PolizaService _polizaService;

    public PolizaController(PolizaService polizaService)
    {
        _polizaService = polizaService;
    }

    [HttpPost("filtrar")]
    public async Task<IActionResult> FiltrarPolizas([FromBody] GetPolizaRequest request)
    {
        var resultado = await _polizaService.GetPolizasFiltradas(request);
        return Ok(resultado);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Desactivar(int id)
    {
        var success = await _polizaService.DesactivarPoliza(id);
        if (!success) return NotFound();

        return NoContent();
    }

    [HttpPost("guardar")]
    public async Task<IActionResult> GuardarPoliza([FromBody] CrearPolizaRequest request)
    {
        var (success, message) = await _polizaService.CrearOActualizarPoliza(request);
        if (!success) return BadRequest(message);
        return Ok("Póliza guardada correctamente.");
    }
}