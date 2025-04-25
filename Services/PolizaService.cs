using Microsoft.EntityFrameworkCore;
using policyApi;
using policyApi.Models;
using policyApi.Models.Request;
using policyApi.Models.Response;

public class PolizaService : IPolizaService
{
    private readonly AppDbContext _context;

    public PolizaService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<PolizaResponse>> GetPolizasFiltradas(GetPolizaRequest request)
    {
        var query = _context.Polizas
            .Include(p => p.TipoPoliza)
            .Include(p => p.Cliente)
            .Include(p => p.EstadoPoliza)
            .Include(p => p.Cobertura)
            .Where(p => p.Activo)
            .AsQueryable();

        if (!string.IsNullOrEmpty(request.NumeroPoliza))
            query = query.Where(p => p.NumeroPoliza.Contains(request.NumeroPoliza));

        if (request.IdTipoPoliza.HasValue)
            query = query.Where(p => p.IdTipoPoliza == request.IdTipoPoliza);

        if (request.FechaVencimiento.HasValue)
            query = query.Where(p => p.FechaVencimiento.Date == request.FechaVencimiento.Value.Date);

        if (!string.IsNullOrEmpty(request.CedulaAsegurado))
            query = query.Where(p => p.CedulaAsegurado.Contains(request.CedulaAsegurado));

        if (!string.IsNullOrEmpty(request.NombreCompleto))
            query = query.Where(p => (p.Cliente.Nombre + " " + p.Cliente.PrimerApellido + " " + p.Cliente.SegundoApellido).Contains(request.NombreCompleto));

        return await query.Select(p => new PolizaResponse
        {
            IdPoliza = p.IdPoliza,
            NumeroPoliza = p.NumeroPoliza,
            CedulaAsegurado = p.CedulaAsegurado,
            MontoAsegurado = p.MontoAsegurado,
            FechaVencimiento = p.FechaVencimiento,
            FechaEmision = p.FechaEmision,
            Prima = p.Prima,
            Periodo = p.Periodo,
            FechaInclusion = p.FechaInclusion,
            Aseguradora = p.Aseguradora,

            IdTipoPoliza = p.IdTipoPoliza,
            TipoPoliza = p.TipoPoliza != null ? p.TipoPoliza.Nombre : string.Empty,

            IdEstadoPoliza = p.IdEstadoPoliza,
            EstadoPoliza = p.EstadoPoliza != null ? p.EstadoPoliza.Nombre : string.Empty,

            IdCobertura = p.IdCobertura,
            Cobertura = p.Cobertura != null ? p.Cobertura.Nombre : string.Empty,

            NombreAsegurado = p.Cliente.Nombre,
            Apellido1Asegurado = p.Cliente.PrimerApellido,
            Apellido2Asegurado = p.Cliente.SegundoApellido
        }).ToListAsync();
    }
    public async Task<bool> DesactivarPoliza(int id)
    {
        var poliza = await _context.Polizas.FindAsync(id);
        if (poliza == null) return false;

        poliza.Activo = false;
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<(bool Success, string? Message)> CrearOActualizarPoliza(CrearPolizaRequest request)
    {
        var cliente = await _context.Clientes.FirstOrDefaultAsync(c => c.CedulaAsegurado == request.CedulaAsegurado);
        if (cliente == null) return (false, "La cédula del asegurado no está registrada.");

        PolizaModelEntity? poliza;

        if (request.IdPoliza.HasValue)
        {
            poliza = await _context.Polizas.FindAsync(request.IdPoliza);
            if (poliza == null) return (false, "No se encontró la póliza a actualizar.");

            var polizaExiste = await _context.Polizas.FirstOrDefaultAsync(c => c.NumeroPoliza == request.NumeroPoliza && c.IdPoliza != request.IdPoliza && c.Activo);
            if (polizaExiste is not null) return (false, "El numero de poliza ya se encuentra registrado");
            
            poliza.NumeroPoliza = request.NumeroPoliza;
            poliza.CedulaAsegurado = request.CedulaAsegurado;
            poliza.IdTipoPoliza = request.IdTipoPoliza;
            poliza.IdEstadoPoliza = request.IdEstadoPoliza;
            poliza.IdCobertura = request.IdCobertura;
            poliza.MontoAsegurado = request.MontoAsegurado;
            poliza.FechaEmision = request.FechaEmision;
            poliza.FechaVencimiento = request.FechaVencimiento;
            poliza.FechaInclusion = request.FechaInclusion;
            poliza.Prima = request.Prima;
            poliza.Periodo = request.Periodo;
            poliza.Aseguradora = request.Aseguradora;
        }
        else
        {
            var polizaExiste = await _context.Polizas.FirstOrDefaultAsync(c => c.NumeroPoliza == request.NumeroPoliza);
            if (polizaExiste is not null) return (false, "El numero de poliza ya se encuentra registrado");

            poliza = new PolizaModelEntity()
            {
                NumeroPoliza = request.NumeroPoliza,
                CedulaAsegurado = request.CedulaAsegurado,
                IdTipoPoliza = request.IdTipoPoliza,
                IdEstadoPoliza = request.IdEstadoPoliza,
                IdCobertura = request.IdCobertura,
                MontoAsegurado = request.MontoAsegurado,
                FechaEmision = request.FechaEmision,
                FechaVencimiento = request.FechaVencimiento,
                FechaInclusion = request.FechaInclusion,
                Prima = request.Prima,
                Periodo = request.Periodo,
                Aseguradora = request.Aseguradora,
                Activo = true,
            };
            _context.Polizas.Add(poliza);
        }
        await _context.SaveChangesAsync();
        return (true, null);
    }
}
