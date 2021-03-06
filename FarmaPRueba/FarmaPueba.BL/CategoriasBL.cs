﻿using System.Collections.Generic;
using System.Linq;

namespace FarmaPrueba.BL
{
    public class CategoriasBL
    {

        ContextoP _contexto;

        public List<Categoria> ListadeCategorias { get; set; }

        public CategoriasBL()
        {
            _contexto = new ContextoP();
            ListadeCategorias = new List<Categoria>();
        }

        public List<Categoria> ObtenerCategorias()
        {
            ListadeCategorias= _contexto.Categorias.ToList();
            return ListadeCategorias;
        }

        public void GuardarCategoria(Categoria categoria)
        {
            if (categoria.Id == 0)
            {
                _contexto.Categorias.Add(categoria);
            }
            else
            {
                var categoriaExistente = _contexto.Categorias.Find(categoria.Id);
                categoriaExistente.Descripcion = categoria.Descripcion;
                
            }

            _contexto.SaveChanges();
        }

        public Categoria ObtenerCategoria(int id)
        {
            var categoria= _contexto.Categorias.Find(id);
            return categoria;

        }

        public void EliminarCategoria(int id)
        {
            var categoria = _contexto.Categorias.Find(id);
            _contexto.Categorias.Remove(categoria);
            _contexto.SaveChanges();

        }

    }
}
