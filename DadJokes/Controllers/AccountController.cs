using DadJokes.Models;
using Microsoft.AspNetCore.Mvc;

namespace DadJokes.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _context; 
        public AccountController(ApplicationDbContext _db)
        {
            _context = _db;
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
    }
}
