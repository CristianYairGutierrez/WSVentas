using System;
using System.ComponentModel.DataAnnotations;

namespace WSVentas.Data.Entities
{
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
