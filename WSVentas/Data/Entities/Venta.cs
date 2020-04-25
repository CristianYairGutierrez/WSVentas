using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WSVentas.Data.Entities
{
    public class Venta
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int IdCliente { get; set; }
        public DateTime Fecha { get; set; }
        public int Total { get; set; }

        [ForeignKey("IdCliente")]
        public Cliente Cliente { get; set; }
    }
}
