using System.ComponentModel.DataAnnotations;

namespace primer_crud.Models
{
    public class ProductDto
    {
        public string Name { get; set; } = "";
        [Required, MaxLength(100)]
        public string Clave { get; set; } = "";
        [Required, MaxLength(100)]
        public DateTime Fecha { get; set; }
        
    }
}
