namespace policyApi.Models.Response
{
    public class PolizaResponse
    {
        public int IdPoliza { get; set; }
        public string NumeroPoliza { get; set; } = string.Empty;
        public string CedulaAsegurado { get; set; } = string.Empty;
        public string NombreAsegurado { get; set; } = string.Empty;
        public string Apellido1Asegurado { get; set; } = string.Empty;
        public string Apellido2Asegurado { get; set; } = string.Empty;

        public decimal MontoAsegurado { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public DateTime FechaEmision { get; set; }
        public decimal Prima { get; set; }
        public DateTime Periodo { get; set; }
        public DateTime FechaInclusion { get; set; }
        public string Aseguradora { get; set; } = string.Empty;

        public int IdTipoPoliza { get; set; }
        public string TipoPoliza { get; set; } = string.Empty;

        public int IdEstadoPoliza { get; set; }
        public string EstadoPoliza { get; set; } = string.Empty;

        public int IdCobertura { get; set; }
        public string Cobertura { get; set; } = string.Empty;
    }
}
