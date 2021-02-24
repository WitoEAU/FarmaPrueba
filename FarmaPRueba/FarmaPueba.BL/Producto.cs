using FarmaPueba.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaPrueba.BL
{
    public class Producto
    {


        public Producto()
        {
            Activo = true;
        }

        public int ID { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public Categoria categoria { get; set; }
        public bool Activo { get; set; }


    }
}
