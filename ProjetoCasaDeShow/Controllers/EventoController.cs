using Microsoft.AspNetCore.Mvc;

namespace ProjetoCasaDeShow.Controllers
{
    public class EventoController : Controller
    {

        public IActionResult CriarEvento(){
            return View();
        }
    }
}