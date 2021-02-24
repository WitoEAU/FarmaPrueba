using FarmaPrueba.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FarmaPrueba.webAdmin.Controllers
{
    public class ProductosController : Controller
    {

        ProductosBL _productosBL;
        public ProductosController()
        {
            _productosBL = new ProductosBL();
        }

        // GET: Productos
        public ActionResult Index()
        {
            var listadeProdcutos = _productosBL.ObtenerProductos();

            return View(listadeProdcutos);
        }

       
        public ActionResult Crear()
        {
            var nuevoProducto = new Producto();
            return View(nuevoProducto);
        }

        [HttpPost]
        public ActionResult Crear(Producto producto)
        {
            _productosBL.GuardarProducto(producto);
            return RedirectToAction("Index");
        }


    }
}