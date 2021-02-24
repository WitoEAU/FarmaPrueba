using FarmaPueba.BL;
using System.Collections.Generic;
using System.Linq;

namespace FarmaPrueba.BL
{
    public class ProductosBL
    {
        ContextoP _contexto;

        public List<Producto> ListadeProductos { get; set; }

        public ProductosBL()
        {
            _contexto = new ContextoP();
        }
    
      public List<Producto> ObtenerProductos()
        {        
            return _contexto.Productos.ToList();
        }

        public void GuardarProducto (Producto producto)
        {
            _contexto.Productos.Add(producto);
            _contexto.SaveChanges();
        }
    }
}

