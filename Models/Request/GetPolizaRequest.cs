namespace policyApi.Models.Request
{
    public class GetPolizaRequest
    {
        public string? NumeroPoliza { get; set; }
        public int? IdTipoPoliza { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public string? CedulaAsegurado { get; set; }
        public string? NombreCompleto { get; set; }
    }
}
