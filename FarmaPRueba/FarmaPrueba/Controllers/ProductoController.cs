using FarmaPrueba.web.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace FarmaPrueba.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Producto
        public ActionResult Index()
        {
            var producto1 = new ProductoModel();
            producto1.ID = 1;
            producto1.Descripcion = "Prd: A";

            var producto2 = new ProductoModel();
            producto2.ID = 2;
            producto2.Descripcion = "Prd: B";

            var producto3 = new ProductoModel();
            producto3.ID = 3;
            producto3.Descripcion = "Prd: C";

            var producto4 = new ProductoModel();
            producto4.ID = 4;
            producto4.Descripcion = "Prd: D";

            var listadeProductos = new List<ProductoModel>();

            listadeProductos.Add(producto1);
            listadeProductos.Add(producto2);
            listadeProductos.Add(producto3);
            listadeProductos.Add(producto4);


            return View(listadeProductos);
        }
    }
}