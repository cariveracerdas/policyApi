using System.ComponentModel.DataAnnotations;

namespace policyApi.Models
{
    public class CoberturaModelEntity
    {
        [Key]
        public int IdCobertura { get; set; }
        public required string Nombre { get; set; }
        public bool Activo { get; set; }
        public ICollection<PolizaModelEntity>? Polizas { get; set; }
    }
}
