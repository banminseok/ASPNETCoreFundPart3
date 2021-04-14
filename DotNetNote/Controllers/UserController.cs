using DotNetNote.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace DotNetNote.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository _Repository;

        public UserController(IUserRepository userRepository)
        {
            _Repository = userRepository;
        }
        public IActionResult Index()
        {
            return View();
        }


        /// <summary>
        /// 회원가입 폼 페이지
        /// </summary>
        /// <returns></returns>
        public IActionResult Register()
        {

            return View();
        }

        /// <summary>
        /// 회원가입 post add 처리
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Register(UserViewModel model)
        {
            if (ModelState.IsValid)
            {
                _Repository.AddUser(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]//인증되니 않은 사용자도 접근 가능.
        public IActionResult Login(string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        [HttpPost, AllowAnonymous]
        public async Task<IActionResult> Login(UserViewModel model, string returnUrl = null)
        {
            if (ModelState.IsValid)
            {
                //[!] 로그인 실패 5번 체크
                //if (_loginFailed.IsLoginFailed(model.UserId))
                //{
                //    ViewBag.IsLoginFailed = true;
                //    return View(model);
                //}
                UserViewModel r = _Repository.IsCorrectUserReturnModel(model.UserId, model.Password);
                if (r.UserId != null)
                {
                    //if (_repository.IsCorrectUser(model.UserId, (new Dul.Security.CryptorEngine()).EncryptPassword(model.Password)))
                    //if (_Repository.IsCorrectUser(model.UserId, model.Password))
                    //[인증부여]
                    //[!] 인증 부여: 인증된 사용자의 주요 정보(Name, Role, ...)를 기록
                    var claims = new List<Claim>()
                    {
                        // 로그인 아이디 지정
                        new Claim("UserId", r.UserId),
                            //new Claim("UserName", r.UserName),
                        new Claim(ClaimTypes.Name, r.UserName),
                        new Claim(ClaimTypes.NameIdentifier, r.UserId),

                        /*
                        new Claim(ClaimTypes.NameIdentifier, model.UserId),

                        new Claim(ClaimTypes.Name, model.UserId), 
                        //new Claim(ClaimTypes.Email, model.UserId), //

                        // 기본 역할 지정, "Role" 기능에 "Users" 값 부여
                        new Claim(ClaimTypes.Role, "Users") // 추가 정보 기록
                        */
                    };

                    //var ci = new ClaimsIdentity(claims, (new Dul.Security.CryptorEngine()).EncryptPassword(model.Password));
                    var ci = new ClaimsIdentity(claims, model.Password);

                    //[1] 로그인 처리: Authorize 특성 사용해서 로그인 체크 가능 
                    //[1][1] ASP.NET Core 1.X 사용: 버전업되면서 아래 메서드 사용 중지 
                    //await HttpContext.Authentication.SignInAsync(
                    //    "Cookies", new ClaimsPrincipal(ci));
                    //[1][2] ASP.NET Core 2.X 사용
                    var authenticationProperties = new AuthenticationProperties()
                    {
                        ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(60),
                        IssuedUtc = DateTimeOffset.UtcNow,
                        IsPersistent = true
                    };
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(ci)); // 기본
                    //await HttpContext.SignInAsync("Cookies", new ClaimsPrincipal(ci), new AuthenticationProperties { IsPersistent = true });
                    //await HttpContext.SignInAsync("Cookies", new ClaimsPrincipal(ci), authenticationProperties);
                    //await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(ci)); // 기본

                    //await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(ci), authenticationProperties); //옵션

                    return LocalRedirect("/User/HelloUser");
                }
                else
                {
                    ModelState.AddModelError("All", "해당 아이디, 패스워드로 등록된 회원이 없습니다.");
                }
                
            }
            return View(model);
        }

        public async Task<IActionResult> Logout()
        {
            #region Old Version
            // Startup.cs의 미들웨어에서 지정한 "Cookies" 이름 사용
            // ASP.NET Core 1.X
            //await HttpContext.Authentication.SignOutAsync("Cookies");
            // ASP.NET Core 2.X
            //await HttpContext.SignOutAsync("Cookies"); 
            #endregion

            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme); // 쿠키 인증 로그아웃
            //await HttpContext.SignOutAsync(OpenIdConnectDefaults.AuthenticationScheme); // 토큰 인증 로그아웃 
            //HttpContext.Session.Clear(); // 세션 인증 로그아웃

            return Redirect("/User/Index");
        }

        [Authorize]// 인증필요
        public IActionResult HelloUser()
        {
            return View();
        }

        [Authorize]
        public IActionResult UserInfor()
        {
            return View();
        }
    }
}
