using DadJokes.Models;
using DadJokes.Models.ViewModels;
namespace DadJokes.Services
{
    public class JokeService : IJokeService
    {
        private readonly ApplicationDbContext _db; 
        public JokeService(ApplicationDbContext _db)
        {
            this._db = _db;
        }
        public async Task<int> AddUpdate(JokeVM model)
        {
            var question = model.Question; 
            var answer = model.Answer;
            var author = model.Author;
            JokeVM joke = new JokeVM()
            {
                Question = question,
                Answer = answer,    
                Author = author,
            };
            _db.Jokes.Add(joke);
            _db.SaveChanges();
            return 0;
        }
        public List<JokeVM> GetJokes()
        {
            List<JokeVM> temp = new List<JokeVM>();
            temp.Add(new JokeVM
            {
                Question = "Is this a dad joke",
                Answer = "Yes it is", 
                Author = "Siddharth"
            });
            return temp;
        }
    }
}
