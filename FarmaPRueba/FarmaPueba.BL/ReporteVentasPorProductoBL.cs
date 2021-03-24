using FarmaPrueba.BL;
using System.Collections.Generic;
using System.Linq;

namespace FarmaPueba.BL
{
    public class ReportedeVentasPorProductoBL
    {
        ContextoP _contexto;
        public List<ReporteVentasPorProducto> ListadeVentasPorProducto { get; set; }

        public ReportedeVentasPorProductoBL()
        {
            _contexto = new ContextoP();
            ListadeVentasPorProducto = new List<ReporteVentasPorProducto>();
        }

        public List<ReporteVentasPorProducto> ObtenerVentasPorProducto()
        {
            ListadeVentasPorProducto = _contexto.OrdenDetalle
                .Include("Producto")
                .Where(r => r.Orden.Activo)
                .GroupBy(r => r.Producto.Descripcion)
                .Select(r => new ReporteVentasPorProducto()
                {
                    Producto = r.Key,
                    Cantidad = r.Sum(s => s.Cantidad),
                    Total = r.Sum(s => s.Total)
                }).ToList();

            return ListadeVentasPorProducto;
        }
    }
}