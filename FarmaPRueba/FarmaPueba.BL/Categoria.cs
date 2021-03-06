using System.ComponentModel.DataAnnotations;

namespace FarmaPrueba.BL
{
    public class Categoria
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ingrese la categoria")]
        public string Descripcion { get; set; }
    }
}
