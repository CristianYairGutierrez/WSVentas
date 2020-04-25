using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WSVentas.Data.Entities
{
    public class Concepto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int IdVenta { get; set; }
        [Required]
        public int IdProducto { get; set; }
        public decimal Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Importe { get; set; }

        [ForeignKey("IdVenta")]
        public Venta Venta { get; set; }

        [ForeignKey("IdProducto")]
        public Producto Producto { get; set; }
    }
}
