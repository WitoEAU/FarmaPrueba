using FarmaPrueba.BL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FarmaPrueba.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            var productosBl = new ProductosBL();
            var listadeProductos = productosBl.ObtenerProductosActivos();
            ViewBag.adminWebsiteUrl = ConfigurationManager.AppSettings["adminWebsiteUrl"];

            return View(listadeProductos);
        }
    }
}