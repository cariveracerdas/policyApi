using policyApi.Models.Response;

namespace policyApi.Services.Interfaces
{
    public interface IEstadoPolizaService
    {
        Task<List<EstadoPolizaResponse>> GetEstadosPoliza();
    }
}
