using Microsoft.AspNetCore.Mvc;
using DadJokes.Models.ViewModels;
using DadJokes.Services;
namespace DadJokes.Controllers.API
{
    [Route("api/Jokes")]
    [ApiController]
    public class JokeApiControlller : Controller
    {
        private readonly IJokeService _jokeService;
        private readonly IHttpContextAccessor _httpContextAccessor; 
        public JokeApiControlller(IJokeService jokeService, IHttpContextAccessor httpContextAccessor)
        {
            _jokeService = jokeService;
            _httpContextAccessor = httpContextAccessor;
        }
        [HttpPost]
        [Route("SaveJoke")]
        public int AddUpdateJoke(JokeVM model)
        {
            int res = _jokeService.AddUpdate(model);
            return res;
        }

    }
}
