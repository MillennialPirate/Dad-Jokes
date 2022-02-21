using DadJokes.Models.ViewModels;
namespace DadJokes.Services
{
    public interface IJokeService
    {
        public List<JokeVM> GetJokes();
        public Task<int> AddUpdate(JokeVM model);
    }
}
