using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WSVentas.Data.Entities
{
    [Table("Productos", Schema = "Ingresos")]
    public class Producto
    {
        [Required]
        public int Id { get; set; }
        [Required, StringLength(250)]
        public string Nombre { get; set; }
        [Required]
        [Range(16, 2)]
        public decimal PrecioUnitario { get; set; }
        [Required]
        public decimal Costo { get; set; }
    }
}
