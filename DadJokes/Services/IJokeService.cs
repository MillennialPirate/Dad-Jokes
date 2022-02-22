using DadJokes.Models.ViewModels;
namespace DadJokes.Services
{
    public interface IJokeService
    {
        public List<JokeVM> GetJokes();
        public int AddUpdate(JokeVM model);
    }
}
