using policyApi.Models.Response;

namespace policyApi.Services.Interfaces
{
    public interface ITipoPolizaService
    {
        Task<List<TipoPolizaResponse>> GetTipoPolizas();
    }
}