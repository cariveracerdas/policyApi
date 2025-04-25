using Microsoft.EntityFrameworkCore;
using policyApi.Models.Response;
using policyApi.Services.Interfaces;


namespace policyApi.Services
{
    public class EstadoPolizaService : IEstadoPolizaService
    {
        private readonly AppDbContext _context;

        public EstadoPolizaService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<EstadoPolizaResponse>> GetEstadosPoliza()
        {
            return await _context.EstadoPolizas
                .Where(ep => ep.Activo)
                .Select(ep => new EstadoPolizaResponse
                {
                    IdEstado = ep.IdEstado,
                    Nombre = ep.Nombre
                })
                .ToListAsync();
        }
    }
}
