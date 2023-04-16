using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using app.Core.Service;
using app.Model.Service;
using app.Model.ViewModel.Auth;
using app.Model.ViewModel.JsonResult;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace app.Web.Controllers
{
    public class AuthController : Controller
    {
        private readonly IUserService _userService;

        public AuthController(IUserService userService)
        {
            _userService = userService;
        }

        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken()]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            JsonResultModel jsonResultModel = new JsonResultModel();
            try
            {
                var (result, roles) = await _userService.Login(model.Email, model.Password);
                if (result.IsSucceeded)
                {
                    var claims = new List<Claim> { new Claim(ClaimTypes.Name, model.Email) };
                    if(model.Email == app.Common.Constants.ADMIN_EMAIL)
                    {
                        claims.Add(new Claim(ClaimTypes.Role, app.Common.Constants.ADMIN_ROLE));
                    }
                    
                    foreach(var role in roles)
                    {
                        claims.Add(new Claim(ClaimTypes.Role, role));
                    }
                    var userIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
                    jsonResultModel.IsSucceeded = true;
                    jsonResultModel.IsRedirect = true;
                    jsonResultModel.RedirectUrl = "/Product";
                }
                else
                {
                    jsonResultModel.IsSucceeded = false;
                    jsonResultModel.UserMessage = result.UserMessage;
                }
            }
            catch (Exception ex)
            {
                jsonResultModel.IsSucceeded = false;
                jsonResultModel.UserMessage = ex.Message;
            }
            return Json(jsonResultModel);
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Redirect("~/auth/login");
        }
    }
}
