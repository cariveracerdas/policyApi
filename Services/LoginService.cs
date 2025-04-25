using policyApi.Models.Request;
using policyApi.Models.Response;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using policyApi.Models;
using policyApi.Services.Interfaces;

namespace policyApi.Services
{
    public class LoginService : ILoginService
    {
        private readonly AppDbContext _context;
        private readonly PasswordHasher<UsuarioModelEntity> _passwordHasher;

        public LoginService(AppDbContext context)
        {
            _context = context;
            _passwordHasher = new PasswordHasher<UsuarioModelEntity>();
        }

        public async Task<LoginResponse> Autenticar(LoginRequest request)
        {
            var user = await _context.Usuarios
            .FirstOrDefaultAsync(u => u.Username == request.Username);

            if (user == null)
            {
                return new LoginResponse
                {
                    Success = false,
                    Message = "Credenciales incorrectas"
                };
            }
            var passwordVerificationResult = _passwordHasher.VerifyHashedPassword(user, user.Password, request.Password);

            if (passwordVerificationResult != PasswordVerificationResult.Success)
            {
                return new LoginResponse
                {
                    Success = false,
                    Message = "Credenciales incorrectas"
                };
            }

            return new LoginResponse
            {
                Success = true,
                Message = "Login exitoso"
            };
        }
    }
}
