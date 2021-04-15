using DotNetNote.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetNote.Controllers
{
    public class MyNotificationController : Controller
    {
        private IMyNotificationRepository _repository;

        public MyNotificationController(IMyNotificationRepository repository)
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MyNotificaton()
        {
            ViewBag.UserId = 1;
            return View();
        }

        public IActionResult MyNotificatonWithModal()
        {
            ViewBag.UserId = 1;
            return View();
        }

        public IActionResult MyPage()
        {
            var userId = 1;
            ViewBag.UserId = userId;
            var noti = _repository.GetNotificationByUserid(userId);
            return View(noti);
        }

        [Route("api/IsNotification")]
        public bool IsNotification(int userId)
        {
            return _repository.IsNotification(userId);
        }

        [Route("api/Completefication")]
        public bool Completefication(int userId)
        {
            _repository.CompleteNotificationByUserid(userId);
            return true;
        }
    }
}
