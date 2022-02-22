using Microsoft.AspNetCore.Mvc;
using DadJokes.Models.ViewModels;
using DadJokes.Services;
namespace DadJokes.Controllers
{
    public class JokeController : Controller
    {
        private readonly IJokeService _jokeService; 
        public JokeController(IJokeService _js)
        {
            _jokeService = _js;
        }
        public IActionResult Index()
        {
            ViewBag.Jokes = _jokeService.GetJokes();
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult GetByAuthor(string username)
        {
            ViewBag.Jokes = _jokeService.GetJokesByUser(username);
            return View();
        }
        //we can pass model as a parameter
        public IActionResult Update(int id)
        {
            JokeVM joke = _jokeService.GetJokeById(id);
            ViewBag.joke = joke;
            return View();
        }
        public IActionResult Delete(int id)
        {
            JokeVM joke = _jokeService.GetJokeById(id);
            ViewBag.joke = joke;
            return View();
        }
    }
}
