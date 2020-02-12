using Microsoft.AspNetCore.Mvc;
using ProjetoCasaDeShow.Models;

namespace ProjetoCasaDeShow.Controllers
{
    public class CasaDeShowController : Controller
    {
        private IDataService dataService;

        public CasaDeShowController(IDataService dataService)
        {
            this.dataService = dataService;
        }
        public IActionResult CriarCasaDeShow(){
            ViewBag.casas = dataService.GetCasaDeShowRepository().GetCasas();
            return View();
        }

        public IActionResult AddCasa(CasaDeShow casaDeShow){
            dataService.GetCasaDeShowRepository().Add(casaDeShow);
            return RedirectToAction("CriarCasaDeShow");
        }
    }
}