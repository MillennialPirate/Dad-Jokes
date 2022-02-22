﻿using Microsoft.AspNetCore.Mvc;
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
    }
}
