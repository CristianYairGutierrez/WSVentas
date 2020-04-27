using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WSVentas.Data.Entities
{
    [Table("Clientes", Schema = "Ingresos")]
    public class Cliente
    {
        [Required]
        public int Id { get; set; }
        [Required, StringLength(250)]
        public string Nombre { get; set; }
    }
}
