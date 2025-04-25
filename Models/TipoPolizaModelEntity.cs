using System.ComponentModel.DataAnnotations;

namespace policyApi.Models
{
    public class TipoPolizaModelEntity
    {
        [Key]
        public int IdTipoPoliza { get; set; }
        public required string Nombre { get; set; }
        public bool Activo { get; set; }
        public ICollection<PolizaModelEntity>? Polizas { get; set; }
    }
}
