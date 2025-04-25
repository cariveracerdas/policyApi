using policyApi.Models;
using policyApi.Models.Response;

namespace policyApi.Services.Interfaces
{
    public interface ICoberturaService
    {
        Task<List<CoberturaResponse>> GetCoberturas();
    }
}
