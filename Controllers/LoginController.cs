using policyApi.Models.Request;
using Microsoft.AspNetCore.Mvc;
using policyApi.Services;

namespace policyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly LoginService _loginService;

        public LoginController(LoginService loginService)
        {
            _loginService = loginService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginRequest request) 
        {
            var response = await _loginService.Autenticar(request); 

            if (!response.Success)
            {
                return Unauthorized(response);
            }

            return Ok(response);
        }
    }
}
