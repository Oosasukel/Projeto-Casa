using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
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
            ViewBag.casaDeShowRepository = dataService.GetCasaDeShowRepository();
            ViewBag.eventoRepository = dataService.GetEventoRepository();

            return View();
        }

        public IActionResult Eventos(){
            ViewBag.casaDeShowRepository = dataService.GetCasaDeShowRepository();
            ViewBag.itemPedidoRepository = dataService.GetItemPedidoRepository();
            ViewBag.eventoRepository = dataService.GetEventoRepository();

            return View();
        }
        
        
        public IActionResult Evento(Evento evento){
            return Content(evento.Id.ToString());
            evento = dataService.GetEventoRepository().GetEventos().Where(e => e.Id == evento.Id).SingleOrDefault();
            return View(evento);
        }

        public IActionResult AddEvento(Evento evento){
            dataService.GetEventoRepository().Add(evento);
            return RedirectToAction("CriarEvento");
        }
    }
}