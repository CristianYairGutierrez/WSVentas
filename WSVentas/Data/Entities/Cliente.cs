using System.ComponentModel.DataAnnotations;

namespace WSVentas.Data.Entities
{
    public class Cliente
    {
        [Required]
        public int Id { get; set; }
        [Required, StringLength(250)]
        public string Nombre { get; set; }
    }
}
