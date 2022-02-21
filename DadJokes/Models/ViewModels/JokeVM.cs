using System.ComponentModel.DataAnnotations;

namespace DadJokes.Models.ViewModels
{
    public class JokeVM
    {
        public int Id { get; set; }
        [Required]
        public string Question { get; set; }
        [Required]
        public string Answer { get; set; }
        public string Author { get; set; }
    }
}
