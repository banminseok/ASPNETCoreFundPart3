using IdeaApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace IdeaApp.Core.Controllers
{
    public class IdeaController : Controller
    {
        private readonly IIdeaRepository _repository;

        public IdeaController(IIdeaRepository repository)
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
            IEnumerable<Idea> ideas = _repository.GetAll();
            return View(ideas);
        }

        [HttpPost]
        public IActionResult Index(Idea model)
        {
            Idea m = _repository.Add(model);
            return RedirectToAction(nameof(Index));
        }
    }
}
