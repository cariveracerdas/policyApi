using System.ComponentModel.DataAnnotations;

namespace policyApi.Models
{
    public class PolizaModelEntity
    {
        [Key]
        public int IdPoliza { get; set; }
        public required string NumeroPoliza { get; set; }
        public decimal MontoAsegurado { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public DateTime FechaEmision { get; set; }
        public decimal Prima { get; set; }
        public DateTime Periodo { get; set; }
        public DateTime FechaInclusion { get; set; }
        public required string Aseguradora { get; set; }

        public required string CedulaAsegurado { get; set; }
        public  ClienteModelEntity? Cliente { get; set; }

        public int IdTipoPoliza { get; set; }
        public  TipoPolizaModelEntity? TipoPoliza { get; set; }

        public int IdEstadoPoliza { get; set; }
        public  EstadoPolizaModelEntity? EstadoPoliza { get; set; }

        public int IdCobertura { get; set; }
        public  CoberturaModelEntity? Cobertura { get; set; }
        public bool Activo {  get; set; }
    }
}
