using policyApi.Models.Response;
using policyApi.Models.Request;

namespace policyApi.Services.Interfaces
{
    public interface ILoginService
    {
        Task<LoginResponse> Autenticar(LoginRequest request);
   
    }
}

