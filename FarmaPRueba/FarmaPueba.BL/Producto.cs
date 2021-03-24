using System.ComponentModel.DataAnnotations;

namespace FarmaPrueba.BL
{
    public class Producto
    {


        public Producto()
        {
            Activo = true;
        }

        public int Id { get; set; }

        [Display(Name = "Descripción")]
        [Required(ErrorMessage = "Ingrese la Descripción")]
        [MinLength(3, ErrorMessage = "Ingrese minimo 3 caracteres")]
        [MaxLength(30, ErrorMessage = "Ingrese un maximo de 20 caracteres")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Ingrese el precio")]
        [Range(0, 10000, ErrorMessage = "Ingrese un precio entre 0 y 10000")]
        public double Precio { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

        [Display(Name = "Imagen")]
        public string UrlImagen { get; set; }
        public bool Activo { get; set; }


    }
}
