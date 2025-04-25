using Microsoft.EntityFrameworkCore;
using policyApi.Models.Response;
using policyApi.Services.Interfaces;

namespace policyApi.Services
{
    public class TipoPolizaService : ITipoPolizaService
    {
        private readonly AppDbContext _context;

        public TipoPolizaService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<TipoPolizaResponse>> GetTipoPolizas()
        {
            return await _context.TipoPolizas
                                 .Where(tp => tp.Activo)
                                 .Select(tp => new TipoPolizaResponse
                                 {
                                     IdTipoPoliza = tp.IdTipoPoliza,
                                     Nombre = tp.Nombre
                                 })
                                 .ToListAsync();
        }
    }
}
