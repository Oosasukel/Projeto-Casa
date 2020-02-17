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

        public IActionResult CriarEvento(Evento evento){
            ViewBag.casaDeShowRepository = dataService.GetCasaDeShowRepository();
            ViewBag.eventos = dataService.GetEventoRepository().GetEventos().Where(e => e.Id != evento.Id);
            
            return View(evento);
        }

        public IActionResult Eventos(){
            ViewBag.casaDeShowRepository = dataService.GetCasaDeShowRepository();
            ViewBag.historicoRepository = dataService.GetHistoricoRepository();
            ViewBag.eventoRepository = dataService.GetEventoRepository();

            return View();
        }
        
        public IActionResult EditEvento(int id){
            var evento = dataService.GetEventoRepository().GetEventoPeloId(id);
            return RedirectToAction("CriarEvento", evento);
        }
        
        public IActionResult Evento(int id){
            var evento = dataService.GetEventoRepository().GetEventos().Where(evento => evento.Id == id).SingleOrDefault();
            

            ViewBag.casaDeShowRepository = dataService.GetCasaDeShowRepository();
            ViewBag.historicoRepository = dataService.GetHistoricoRepository();

            return View(evento);
        }

        public IActionResult AddEvento(Evento evento){
            if(evento.Id == 0){
                dataService.GetEventoRepository().Add(evento);
            }
            else{
                dataService.GetEventoRepository().Update(evento);
            }
            return RedirectToAction("CriarEvento");
        }

        public IActionResult DeleteEvento(int id){
            dataService.GetEventoRepository().Delete(id);
            return RedirectToAction("CriarEvento");

        }
    }
}