using Microsoft.AspNetCore.Mvc;
using Servicios;

namespace mvc.Controllers
{
    public class HerramientaController : Controller
    {
        private Servicios.IHerramientaServicio _herramientaServicio;

        public HerramientaController(IHerramientaServicio herramientaServicio)
        {
            _herramientaServicio = herramientaServicio;
        }

        public IActionResult Index()
        {
            return View(_herramientaServicio.ObtenerHerramientas());
            
        }

        [HttpGet]
        public IActionResult Crear(){
            return View();
        }
        [HttpPost]
        public IActionResult CrearHerramienta(Entidades.Herramienta  herramienta){
            _herramientaServicio.AgregarHerramienta(herramienta);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Eliminar(int id){
            _herramientaServicio.EliminarHerramienta(id);
            return RedirectToAction("Index");
        }

    }
    /* sobrecarga de metodo 
             * View();-> entiende que el nombre del IActionResult sera misma a la Vista.cshtml x defecto
             * View("viewName", model)
             * View(model)
             * View("viewName")
             */
}
