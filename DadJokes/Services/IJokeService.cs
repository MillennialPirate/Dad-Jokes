using DadJokes.Models.ViewModels;
namespace DadJokes.Services
{
    public interface IJokeService
    {
        public List<JokeVM> GetJokes();
        public int AddUpdate(JokeVM model);
        public List<JokeVM> GetJokesByUser(string userName);
        public JokeVM GetJokeById(int id);
        public int DeleteJoke(int id);
    }
}
