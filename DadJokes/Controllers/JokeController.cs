using Microsoft.AspNetCore.Mvc;

namespace DadJokes.Controllers
{
    public class JokeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
