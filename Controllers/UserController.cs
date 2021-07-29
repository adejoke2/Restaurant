using BeebarhRestaurant.Interface;
using BeebarhRestaurant.Models;
using BeebarhRestaurant.Models.ViewModel;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BeebarhRestaurant.Controllers
{    public class UserController : Controller
    {
        public IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Index()
        {

            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
           return View();
        }

        [HttpPost]
        public IActionResult Register(CreateUserViewModel model)
        {

            _userService.RegisterUser(model.Id,model.Email,model.Name, model.Gender, model.Password,model.userId,model.userEmail,model.FirstName,model.LastName,model.Address,model.PhoneNumber);
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel vm)
        {
            User user = _userService.LoginUser(vm.Email, vm.Password);

            if (user == null) return View();


            var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                    new Claim(ClaimTypes.Email, user.Email)
                };

            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            var principal = new ClaimsPrincipal(identity);

            var props = new AuthenticationProperties();

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, props);
            //return RedirectToAction("Index", "Dashboard");
            if (user.RoleId == 1)
            {
                   return RedirectToAction("Index", "admin");
            }
            else if(user.RoleId == 2)
            {
                   return RedirectToAction("Index", "manager");
            }
            else
            {
                return RedirectToAction("Index", "customer");
            }

        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login");
        }
    }
}
