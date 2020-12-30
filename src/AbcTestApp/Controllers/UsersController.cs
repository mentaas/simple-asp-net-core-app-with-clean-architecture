using AbcTestApp.Application.Interfaces;
using AbcTestApp.SharedModel.Administrations.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbcTestApp.Web.Controllers
{
    public class UsersController : Controller
    {
        private readonly IAdministrationService _service;

        public UsersController(IAdministrationService service)
        {
            _service = service;
        }

        //public IActionResult Index() => View();

        [HttpGet]
        [AllowAnonymous]
        public IActionResult SignUp() => View();

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> SignUp(NewUserModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            if (await _service.CreateUser(model) == null)
                return View(model);

            return RedirectToAction("SignIn");
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult SignIn() => View();

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> SignIn(Credentials model)
        {
            if (!ModelState.IsValid)
                return View(model);

            if (!(await _service.SignIn(model)))
                return View(model);

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> SignOut() => Redirect((await _service.SignOut()) ? "~/Users/SignIn" : "~/Home/Index");
    }
}
