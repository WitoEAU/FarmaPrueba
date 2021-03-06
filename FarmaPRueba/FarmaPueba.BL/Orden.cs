﻿using FarmaPrueba.BL;
using System;
using System.Collections.Generic;

namespace FarmaPrueba.BL
{
    public class Orden
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime Fecha { get; set; }
        public double Total { get; set; }
        public bool Activo { get; set; }

        public List<OrdenDetalle> ListadeOrdenDetalle { get; set; }
        
        public Orden()
        {
            Activo = true;
            Fecha = DateTime.Now;
        }

    }

    public class OrdenDetalle
    {
        public int Id { get; set; }
        public int OrdenId { get; set; }
        public Orden Orden { get; set; }

        public int ProductoId { get; set; }
        public int Producto { get; set; }

        public int Cantidad { get; set; }
        public double Precio { get; set; }
        public double Total { get; set; }

    }
}