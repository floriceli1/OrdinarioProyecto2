using Microsoft.AspNetCore.Mvc;
using OrdinarioProyecto.Models;
using System.Diagnostics;
//Controlador de home
namespace OrdinarioProyecto.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        //creacion de la accion para direccionarnos al index
        public IActionResult Index()
        {
            return View();
        }
        //creacion de la accion para direccionarnos a privacy
        public IActionResult Privacy()
        {
            return View();
        }
        //creacion de la accion para direccionarnos a la pagina de error
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}