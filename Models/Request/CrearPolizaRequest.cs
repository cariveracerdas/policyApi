namespace policyApi.Models.Request
{
    public class CrearPolizaRequest
    {
        public int? IdPoliza { get; set; } 
        public string NumeroPoliza { get; set; } = string.Empty;
        public string CedulaAsegurado { get; set; } = string.Empty;
        public int IdTipoPoliza { get; set; }
        public int IdEstadoPoliza { get; set; }
        public int IdCobertura { get; set; }

        public decimal MontoAsegurado { get; set; }
        public DateTime FechaEmision { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public DateTime FechaInclusion { get; set; }
        public decimal Prima { get; set; }
        public DateTime Periodo { get; set; }
        public string Aseguradora { get; set; } = string.Empty;
    }
}
