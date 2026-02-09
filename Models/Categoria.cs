using System.ComponentModel.DataAnnotations;

namespace CulturalesAlcaldia.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        public string? Descripcion { get; set; }

        public bool Activo { get; set; } = true;
    }
}