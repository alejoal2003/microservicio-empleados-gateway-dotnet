using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiEmpleado.Models
{
    [Table("empleado")]
    public class Empleado
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("cedula")]
        [StringLength(10)]
        public string Cedula { get; set; } = string.Empty;

        [Required]
        [Column("nombres")]
        [StringLength(100)]
        public string Nombres { get; set; } = string.Empty;

        [Required]
        [Column("apellidos")]
        [StringLength(100)]
        public string Apellidos { get; set; } = string.Empty;
    }
}