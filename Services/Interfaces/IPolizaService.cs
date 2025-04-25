using policyApi.Models.Request;
using policyApi.Models.Response;

public interface IPolizaService
{
    Task<List<PolizaResponse>> GetPolizasFiltradas(GetPolizaRequest getPolizaRequest);
    Task<bool> DesactivarPoliza(int id);
    Task<(bool Success, string? Message)> CrearOActualizarPoliza(CrearPolizaRequest request);
}