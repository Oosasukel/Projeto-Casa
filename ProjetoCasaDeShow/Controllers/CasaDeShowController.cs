using Microsoft.AspNetCore.Mvc;

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
            return View();
        }
    }
}