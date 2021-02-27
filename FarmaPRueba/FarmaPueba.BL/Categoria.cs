using System.ComponentModel.DataAnnotations;

namespace FarmaPueba.BL
{
    public class Categoria
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ingrese la categoria")]
        public string Descripcion { get; set; }
    }
}
