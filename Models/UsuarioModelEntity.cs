using System.ComponentModel.DataAnnotations;

namespace policyApi.Models
{
    public class UsuarioModelEntity
    {
        [Key]
        public int Id { get; set; }
        public required string Username { get; set; }
        public required string Password { get; set; }
    }
}
