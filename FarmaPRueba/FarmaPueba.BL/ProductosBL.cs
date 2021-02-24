using FarmaPueba.BL;
using System.Collections.Generic;
using System.Linq;
using System;

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
            if (producto.ID == 0)
            {
                _contexto.Productos.Add(producto);
            } else
            {
                var productoExistente = _contexto.Productos.Find(producto.ID);
                productoExistente.Descripcion = producto.Descripcion;
                productoExistente.Precio = producto.Precio;
            }
            
            _contexto.SaveChanges();
        }

        public Producto ObtenerProducto(int id)
        {
            var producto = _contexto.Productos.Find(id);
            return producto;

        }

        public void EliminarProducto(int id)
        {
            var producto = _contexto.Productos.Find(id);
            _contexto.Productos.Remove(producto);
            _contexto.SaveChanges();
             
        }
    }
}

