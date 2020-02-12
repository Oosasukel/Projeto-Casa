using Microsoft.AspNetCore.Mvc;
using ProjetoCasaDeShow.Models;

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
            ViewBag.casas = dataService.GetCasaDeShowRepository().GetCasas();
            ViewBag.eventos = dataService.GetEventoRepository().GetEventos();
            return View();
        }

        public IActionResult Eventos(Evento evento){
            return View(evento);
        }

        [HttpGet]
        public IActionResult Evento(string test){
            return View(test);
        }

        public IActionResult AddEvento(Evento evento){
            dataService.GetEventoRepository().Add(evento);
            return RedirectToAction("CriarEvento");
        }
    }
}