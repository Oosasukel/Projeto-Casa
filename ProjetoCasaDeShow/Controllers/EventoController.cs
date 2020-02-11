using Microsoft.AspNetCore.Mvc;

namespace ProjetoCasaDeShow.Controllers
{
    public class EventoController : Controller
    {
        private IDataService dataService;

        public EventoController(IDataService dataService)
        {
            this.dataService = dataService;
        }

        public IActionResult CriarEvento(){
            return View();
        }

        public IActionResult Eventos(){
            return View();
        }

        [HttpGet]
        public IActionResult Evento(string test){
            return View(test);
        }
    }
}