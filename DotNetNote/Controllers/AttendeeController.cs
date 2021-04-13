using DotNetNote.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DotNetNote.Controllers
{
    public class AttendeeController : Controller
    {
        private readonly IAttendeeRepository _repository;

        public AttendeeController(IAttendeeRepository attendeeRepository)
        {
            _repository = attendeeRepository;
        }
        public IActionResult Index()
        {
            IEnumerable<Attendee> list = _repository.GetAll();
            return View(list);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Attendee model)
        {
            if (string.IsNullOrEmpty(model.Name) || string.IsNullOrEmpty(model.UserId))
            {
                ModelState.AddModelError("","잘못된 데이터 입니다.");
            }
            if (ModelState.IsValid)
            {
                _repository.Add(model);

                //Index로
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
