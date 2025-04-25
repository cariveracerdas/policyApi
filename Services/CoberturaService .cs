using policyApi.Models.Response;
using policyApi.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace policyApi.Services
{
    public class CoberturaService : ICoberturaService
    {
        private readonly AppDbContext _context;

        public CoberturaService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<CoberturaResponse>> GetCoberturas()
        {
            return await _context.Coberturas
                .Where(c => c.Activo)
                .Select(c => new CoberturaResponse
                {
                    IdCobertura = c.IdCobertura,
                    Nombre = c.Nombre
                })
                .ToListAsync();
        }
    }
}
