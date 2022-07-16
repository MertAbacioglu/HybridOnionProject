using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using NLayer.Core.DTOs;
using NLayer.Core.Enums;
using NLayer.Core.Models;
using NLayer.Web.Services;
using System.Security.Claims;

namespace NLayer.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppUserApiService _appUserApiService;

        public HomeController(ILogger<HomeController> logger, AppUserApiService appUserApiService)
        {
            _logger = logger;
            _appUserApiService = appUserApiService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(AppUserDto appUserDto)
        {
            Task<AppUserDto> appUserDtoChecked = _appUserApiService.CheckAppUser(appUserDto);
            if (appUserDtoChecked.Result == null)
            {
                ViewBag.UserCheckFail = "user not found";
                return View();
            }
            bool isAuthenticate = false;
            ClaimsIdentity identity = null;

            if (appUserDtoChecked.Result.Role == AppUserRole.Admin)
            {
                identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);
                identity.AddClaim(new Claim(ClaimTypes.Role, Enum.GetName(typeof(AppUserRole), AppUserRole.Admin)));
                identity.AddClaim(new Claim(ClaimTypes.Name, appUserDto.UserName));
                identity.AddClaim(new Claim("UserName", appUserDto.UserName));
                isAuthenticate = true;
            }
            if (isAuthenticate)
            {
                ClaimsPrincipal principal = new ClaimsPrincipal(identity);
                HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, new AuthenticationProperties
                {
                    ExpiresUtc = DateTime.UtcNow.AddMinutes(1),
                    IsPersistent = false,
                    AllowRefresh = false
                });

                return RedirectToAction("Index", "Categories");
            }
            return RedirectToAction("Index", "Categories");
        }
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync();
            return LocalRedirect("/");
            //return RedirectToAction("Login", "Home");
        }
    }
}