using FarmaPrueba.BL;
using System.Web.Mvc;

namespace FarmaPrueba.Controllers
{
    public class ProductoController : Controller
    {
       

        // GET: Producto
        public ActionResult Index()
        {

            var productosBl = new ProductosBL();
            var listadeProductos = productosBl.ObtenerProductos();


            return View(listadeProductos);
        }
    }
}