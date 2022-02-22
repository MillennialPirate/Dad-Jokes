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
        public int AddUpdate(JokeVM model)
        {
            if(model.Id > 0)
            {
                //updating
                //find the object from the database 
                var joke = _db.Jokes.FirstOrDefault(x => x.Id == model.Id);
                joke.Id = model.Id;
                joke.Question = model.Question;
                joke.Answer = model.Answer; 
                joke.Author = model.Author;
                _db.SaveChanges();
                return 1; 
            }
            else
            {
                //inserting
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
        }
        public List<JokeVM> GetJokes()
        {
            List<JokeVM> temp = _db.Jokes.ToList();
            return temp;
        }
        public List<JokeVM> GetJokesByUser(string userName)
        {
            List<JokeVM> temp = _db.Jokes.Where(x => x.Author == userName).ToList();
            return temp;
        }
        public JokeVM GetJokeById(int id)
        {
            JokeVM joke = _db.Jokes.FirstOrDefault(x => x.Id == id);
            if (joke == null)
                return null;
            return joke;
        }
    }
}
