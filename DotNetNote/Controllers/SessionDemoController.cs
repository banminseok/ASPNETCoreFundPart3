using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetNote.Controllers
{
    public class SessionDemoController : Controller
    {
        public IActionResult Index()
        {
            //세션 저장
            HttpContext.Session.SetString("UserName", "Green");
            return View();
        }

        public IActionResult GetSession()
        {
            ViewBag.UserName = HttpContext.Session.GetString("UserName");
            // 세션 읽기
            return View();
        }

        /// <summary>
        /// 세션에 날짜값 저장
        /// Extension/SessionExtensions.cs 파일이 필요
        /// </summary>
        /// <returns></returns>
        public IActionResult SetDate()
        {
            HttpContext.Session.Set<DateTime>("NowDate", DateTime.Now);
            //return View();
            return RedirectToAction("GetDate");
        }

        public IActionResult GetDate()
        {
            var date = HttpContext.Session.Get<DateTime>("NowDate");
            var sessionTime = date.TimeOfDay.ToString();
            var currentTime = DateTime.Now.TimeOfDay.ToString();

            return Content($"현재시간:{currentTime} - 세션에 저장되어있는 시간: {sessionTime}");
            //return View();
        }
    }
}
