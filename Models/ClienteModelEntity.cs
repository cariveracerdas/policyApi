using System.ComponentModel.DataAnnotations;

namespace policyApi.Models
{
    public class ClienteModelEntity
    {
        [Key]
        public required string CedulaAsegurado { get; set; }
        public required string Nombre { get; set; }
        public required string PrimerApellido { get; set; }
        public required string SegundoApellido { get; set; }
        public required string TipoPersona { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public ICollection<PolizaModelEntity>? Polizas { get; set; }
    }
}
