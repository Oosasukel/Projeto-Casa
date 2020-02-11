using Microsoft.AspNetCore.Mvc;

namespace ProjetoCasaDeShow.Controllers
{
    public class CasaDeShowController : Controller
    {
        public IActionResult CriarCasaDeShow(){
            return View();
        }
    }
}